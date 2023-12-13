using MaisonEauOr.Models;
using MaisonEauOr.Models.Products;

namespace MaisonEauOr.Extensions;

public static class ProductExtensions
{
    public static List<ProductModel> ToProductModel(this List<IProduct> products, ProductCategory category)
    {
        return products.ConvertAll<ProductModel>(x => new ProductModel
        {
            ProductID = x.Id,
            AmountInStock = x.StockAmount,
            Name = x.Name,
            Category = category,
            Price = x.Price,
            IsAvailable = x.IsAvailable,
            AddedAt = x.AddedAt,
            Options = x.Options
        });
    }

    public static List<IProduct> ToIProduct<T>(this List<T> products) where T : IProduct
    {
        return products.ConvertAll<IProduct>(x => new IProduct
        {
            Id = x.Id,
            IsAvailable = x.IsAvailable,
            AddedAt = x.AddedAt,
            Description = x.Description,
            Name = x.Name,
            Price = x.Price,
            StockAmount = x.StockAmount,
            Options = x.Options
        });
    }
}