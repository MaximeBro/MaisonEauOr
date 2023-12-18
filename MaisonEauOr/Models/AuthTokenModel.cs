namespace MaisonEauOr.Models;

public class AuthTokenModel
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid ClientID { get; set; }
	public DateTime CreatedAt { get; set; } = DateTime.Now;
	public string Code { get; set; }
}