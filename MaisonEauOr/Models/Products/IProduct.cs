namespace MaisonEauOr.Models.Products;

// This class is only used for data aggregation
public class IProduct
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string? Name { get; set; }
	public List<Option> Options { get; set; } = new();
	public double Price { get; set; }
	public string? Description { get; set; }
	public DateTime AddedAt { get; set; }
	public int StockAmount { get; set; }
	public bool IsAvailable { get; set; }
	public string? ImagePath { get; set; }
}