using MaisonEauOr.Databases;
using MaisonEauOr.Models;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace MaisonEauOr.Services;

public class BasketService
{
    private readonly IDbContextFactory<MeoDbContext> _factory;

    public BasketService(IDbContextFactory<MeoDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<List<BasketProductModel>> GetBasketProductsAsync(UserSession session)
    {
        var context = await _factory.CreateDbContextAsync();
        var user = context.UserAccounts.AsNoTracking().FirstOrDefault(x => x.Email == session.Email);
        if (user is not null)
        {
            return await context.BasketProducts.AsSplitQuery()
                .Include(x => x.Product)
                .Where(x => x.ClientID == user.Id && x.OrderID == Guid.Empty).ToListAsync();
        }
        

        return new List<BasketProductModel>();
    }

    public async Task UpdateBasketProductAsync(BasketProductModel product)
    {
        var context = await _factory.CreateDbContextAsync();
        var actualProduct = context.BasketProducts.AsSplitQuery().Include(x => x.Product)
                                                  .FirstOrDefault(x => x.ClientID == product.ClientID && x.ProductID == product.ProductID && x.OrderID == Guid.Empty);
        if (actualProduct != null)
        {
            actualProduct.ProductAmount = product.ProductAmount;
            context.BasketProducts.Update(actualProduct);
            await context.SaveChangesAsync();
        }
    }

    public async Task RemoveBasketProductAsync(BasketProductModel product)
    {
        var context = await _factory.CreateDbContextAsync();
        context.BasketProducts.Remove(product);
        await context.SaveChangesAsync();
    }

    public async Task<int> TryAddToBasketAsync(BasketProductModel product, ProductModel model)
    {
        var context = await _factory.CreateDbContextAsync();
        var actualProduct = context.BasketProducts.AsSplitQuery().Include(x => x.Product)
                                                  .FirstOrDefault(x => x.ClientID == product.ClientID && x.ProductID == product.ProductID && x.OrderID == Guid.Empty);
        if (actualProduct is null)
        {
            if (product.ProductAmount <= model.AmountInStock)
            {
                context.BasketProducts.Add(product);
                await context.SaveChangesAsync();
                return -1;
            }

            return model.AmountInStock;
        }

        if (actualProduct.ProductAmount + product.ProductAmount > model.AmountInStock)
        {
            return model.AmountInStock;
        }

        actualProduct.ProductAmount += product.ProductAmount;
        context.BasketProducts.Update(actualProduct);
        await context.SaveChangesAsync();
        return -1;
    }

    public async Task<int> GetBasketCountAsync(UserSession session)
    {
        var context = await _factory.CreateDbContextAsync();
        var user = context.UserAccounts.AsNoTracking().FirstOrDefault(x => x.Email == session.Email);
        if (user != null)
        {
            return context.BasketProducts.Where(x => x.ClientID == user.Id && x.OrderID == Guid.Empty).Sum(x => x.ProductAmount);
        }

        return 0;
    }
}