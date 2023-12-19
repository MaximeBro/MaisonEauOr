using MaisonEauOr.Models;

namespace MaisonEauOr.Extensions;

public static class BasketProducts
{
    public static double TotalTva(this List<BasketProductModel> products) => products.Sum(x => x.Product!.Tva * x.Product.Price * x.ProductAmount);
    
    public static double Total(this List<BasketProductModel> products) => products.Sum(x => x.Product!.Price * x.ProductAmount);

    public static double TotalWithTva(this List<BasketProductModel> products) => products.Sum(x => x.Product!.Price * (1 + x.Product.Tva) * x.ProductAmount);
}