using System.ComponentModel.DataAnnotations.Schema;

namespace MaisonEauOr.Models;

public class UserAccount
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Lastname { get; set; }
    public string? Firstname { get; set; }
    public string Email { get; set; }
    public DateTime BornAt { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Town { get; set; }
    public string? Country { get; set; }
    public int PostalCode { get; set; }
    public UserRole Role { get; set; }
    public string Password { get; set; }
    public bool DoubleAuth { get; set; } = true;
    public ICollection<BasketProductModel>? BasketProducts { get; set; }

    [NotMapped] public string FullName => $"{Firstname} {Lastname}";
}