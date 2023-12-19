using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MaisonEauOr.Models;

public class OrderModel
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid ClientID { get; set; }
	public UserAccount? Client { get; set; }
	public DateTime? OrderedAt { get; set; }
	public double ShippingPrice { get; set; }
	public string ShippingTown { get; set; }
	public int ShippingPostalCode { get; set; }
	public string ShippingAddress { get; set; }
	public double Total { get; set; }
	public ICollection<BasketProductModel>? Products { get; set; }
	public bool Payed { get; set; }

	[NotMapped] public string ShippingPriceText => ShippingPrice <= 0 ? "GRATUIT" : ShippingPrice.ToString("C");
}