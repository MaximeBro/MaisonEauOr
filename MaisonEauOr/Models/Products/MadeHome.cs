namespace MaisonEauOr.Models.Products;

public class MadeHome
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public List<Option> Options { get; set; }
	public double Price { get; set; }
	public string Description { get; set; }
	public DateTime AddedAt { get; set; }
	public int StockAmount { get; set; }
	public bool IsAvailable { get; set; }
	public string ImagePath { get; set; }
}