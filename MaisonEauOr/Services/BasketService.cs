using MaisonEauOr.Databases;
using MaisonEauOr.Models;
using Microsoft.EntityFrameworkCore;

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
        var user = context.UserAccounts.FirstOrDefault(x => x.Email == session.Email);
        if (user is not null)
        {
            return await context.BasketProducts.AsSplitQuery()
                .Include(x => x.Product)
                .Where(x => x.ClientID == user.Id).ToListAsync();
        }
        

        return new List<BasketProductModel>();
    }

    public async Task AddBasketProductAsync(BasketProductModel product)
    {
        var context = await _factory.CreateDbContextAsync();
        var actualProduct = context.BasketProducts.AsSplitQuery().Include(x => x.Product)
                                                  .FirstOrDefault(x => x.ClientID == product.ClientID && x.ProductID == product.ProductID);

        if (actualProduct != null)
        {
            actualProduct.ProductAmount += product.ProductAmount;
            context.BasketProducts.Update(actualProduct);
        }
        else
        {
            context.BasketProducts.Add(product);
        }
        await context.SaveChangesAsync();
    }

    public async Task UpdateBasketProductAsync(BasketProductModel product)
    {
        var context = await _factory.CreateDbContextAsync();
        var actualProduct = context.BasketProducts.AsSplitQuery().Include(x => x.Product)
                                                  .FirstOrDefault(x => x.ClientID == product.ClientID && x.ProductID == product.ProductID);
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
                                                  .FirstOrDefault(x => x.ClientID == product.ClientID && x.ProductID == product.ProductID);
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

        if (actualProduct.ProductAmount + 1 > model.AmountInStock)
        {
            return model.AmountInStock;
        }

        actualProduct.ProductAmount++;
        context.BasketProducts.Update(actualProduct);
        await context.SaveChangesAsync();
        return -1;
    }

    public async Task<int> GetBasketCountAsync(UserSession session)
    {
        var context = await _factory.CreateDbContextAsync();
        var user = context.UserAccounts.FirstOrDefault(x => x.Email == session.Email);
        if (user != null)
        {
            return context.BasketProducts.Where(x => x.ClientID == user.Id).Sum(x => x.ProductAmount);
        }

        return 0;
    }
}