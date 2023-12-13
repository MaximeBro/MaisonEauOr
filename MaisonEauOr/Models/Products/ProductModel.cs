using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaisonEauOr.Models;

public class ProductModel
{
    public Guid Id { get; set; }
    public int AmountInStock { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ProductCategory Category { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime AddedAt { get; set; }
    [NotMapped] 
    public List<Option> Options { get; set; } = new();
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