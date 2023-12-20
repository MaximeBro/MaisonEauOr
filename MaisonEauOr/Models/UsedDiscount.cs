namespace MaisonEauOr.Models;

public class UsedDiscount
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; }
    public Guid DiscountID { get; set; }
}