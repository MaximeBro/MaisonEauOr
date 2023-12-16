using MaisonEauOr.Databases;
using MaisonEauOr.Models;
using Microsoft.EntityFrameworkCore;

namespace MaisonEauOr.Services;

public class BasketService
{
	public BasketService() { }

	public async Task<List<BasketProductModel>> GetBasketProductsAsync(UserSession session)
	{
		await using (var context = new MeoDbContext(new DbContextOptions<MeoDbContext>()))
		{
			var user = context.UserAccounts.FirstOrDefault(x => x.Email == session.Email);
			if (user != null)
			{
				return context.BasketProducts.Where(x => x.ClientID == user.Id).AsNoTracking().ToList();
			}	
		}
		
		return new List<BasketProductModel>();
	}

	public async Task UpdateBasketProduct(BasketProductModel product)
	{
		await using (var context = new MeoDbContext(new DbContextOptions<MeoDbContext>()))
		{
			var productToDelete = context.BasketProducts.FirstOrDefault(x => x.Id == product.Id);
			if (productToDelete != null)
			{
				context.BasketProducts.Remove(productToDelete);
				context.BasketProducts.Add(product);
				await context.SaveChangesAsync();
			}
		}
	}

	public async Task RemoveBasketProduct(BasketProductModel product)
	{
		await using (var context = new MeoDbContext(new DbContextOptions<MeoDbContext>()))
		{
			context.BasketProducts.Remove(product);
			await context.SaveChangesAsync();
		}
	}
}