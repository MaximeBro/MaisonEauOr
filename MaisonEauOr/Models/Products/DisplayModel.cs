namespace MaisonEauOr.Models;

public class DisplayModel
{
    public Guid Id { get; set; }
    public Guid ProductID { get; set; }
    public ProductModel? Product { get; set; }
    public int Index { get; set; }
}