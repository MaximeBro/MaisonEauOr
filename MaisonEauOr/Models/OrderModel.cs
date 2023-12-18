using System.ComponentModel.DataAnnotations.Schema;

namespace MaisonEauOr.Models;

public class OrderModel
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid ClientID { get; set; }
	public double ShippingPrice { get; set; }
	public string ShippingTown { get; set; }
	public int ShippingPostalCode { get; set; }
	public string ShippingAddress { get; set; }
	public double Total { get; set; }
	public List<BasketProductModel> BasketProducts { get; set; } = new();

	[NotMapped] public string ShippingPriceText => ShippingPrice <= 0 ? "GRATUIT" : ShippingPrice.ToString("C");
}