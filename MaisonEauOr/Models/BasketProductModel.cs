using System.ComponentModel.DataAnnotations.Schema;

namespace MaisonEauOr.Models;

public class BasketProductModel
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid ProductID { get; set; }
	[NotMapped]
	public ProductModel Product { get; set; }
	public Guid ClientID { get; set; }
	[NotMapped]
	public UserAccount User { get; set; }
	public int ProductAmount { get; set; }
	public string? Option { get; set; }

	[NotMapped] 
	public double TotalPrice => ProductAmount * (Product.Price * (Product.Tva+1));
	[NotMapped] 
	public string OptionText => Option ?? "STANDARD";
}