using MaisonEauOr.Models;

namespace MaisonEauOr.Extensions;

public static class BasketProducts
{
    public static double TotalTva(this List<BasketProductModel> products) => products.Sum(x => x.Product!.Tva * x.Product.Price * x.ProductAmount);
    
    public static double Total(this List<BasketProductModel> products) => products.Sum(x => x.Product!.Price * x.ProductAmount);

    public static double TotalWithTva(this List<BasketProductModel> products) => products.Sum(x => x.Product!.Price * (1 + x.Product.Tva) * x.ProductAmount);

    public static double TotalWithTva(this List<BasketProductModel> products, double discount, bool isPercent = false)
    {
        return isPercent ? 
            products.Sum(x => x.Product!.Price * (1 + x.Product.Tva) * (1 - discount) * x.ProductAmount) : 
            products.Sum(x => (x.Product!.Price * (1 + x.Product.Tva) - discount) * x.ProductAmount);
    }

    public static double TotalWithTva(this BasketProductModel product) =>
        product.ProductAmount * (1 + product.Product!.Tva) * product.Product!.Price;
}