namespace MaisonEauOr.Models;

public class Option
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public Guid ProductID { get; set; }
	public string Name { get; set; }
}