using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaisonEauOr.Models;

public class DiscountModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string CodeName { get; set; }
    public double Discount { get; set; }
    public double DiscountPercent { get; set; }
    public bool IsPercent { get; set; }
    public Guid ProductID { get; set; }
    public DiscountType Type { get; set; }
    public ICollection<ProductCategory> Categories { get; set; }
    public DateTime? StartsAt { get; set; }
    public DateTime? EndsAt { get; set; }
    public bool IsActive { get; set; }

    [NotMapped] public string DiscountFormat => IsPercent ? "P2" : "C";
}

public enum DiscountType
{
    [Description("Produit spécifique")]
    Product,
    
    [Description("Catégories de produits")]
    Category,
    
    [Description("Tous les produits")]
    All
}