using System.ComponentModel;
using MaisonEauOr.Models.Products;

namespace MaisonEauOr.Models;

public class ProductModel
{
    public Guid ProductID { get; set; }
    public int AmountInStock { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ProductCategory Category { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime AddedAt { get; set; }
    public List<Option> Options { get; set; } 
    public string ImagePath { get; set; }
}

public enum ProductCategory
{
    [Description("Cosmétique")]
    Cosmetic,
    
    [Description("Produit capillaire")]
    HairProduct,
    
    [Description("Miellerie")]
    Honey,
    
    [Description("Maison")]
    MadeHome,
    
    [Description("Brume")]
    Mist,
    
    [Description("Musc Tahara Intime")]
    MuscTahara,
    
    [Description("Parfum")]
    Perfume
}