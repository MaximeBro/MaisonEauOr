using System.ComponentModel.DataAnnotations;

namespace MaisonEauOr.Models;

public class RegisterModel
{
	[Required(ErrorMessage = "Veuillez renseigner votre prénom")]
	public string Firstname { get; set; } = string.Empty;
        
	[Required(ErrorMessage = "Veuillez renseigner votre nom")]
	public string Lastname { get; set; } = string.Empty;
        
	[Required(ErrorMessage = "Veuillez renseigner votre email")]
	public string Email { get; set; } = string.Empty;
        
	[Required(ErrorMessage = "Veuillez renseigner votre date de naissance")]
	public DateTime? BornAt { get; set; }
        
	[Required(ErrorMessage = "Veuillez renseigner votre téléphone")]
	public string PhoneNumber { get; set; } = string.Empty;
        
	[Required(ErrorMessage = "Veuillez renseigner votre adresse")]
	public string Address { get; set; } = string.Empty;
        
	[Required(ErrorMessage = "Veuillez renseigner votre ville")]
	public string Town { get; set; } = string.Empty;
	
	[Required(ErrorMessage = "Veuillez renseigner votre pays")]
	public string Country { get; set; } = string.Empty;
        
	[Required(ErrorMessage = "Veuillez renseigner votre code postal")]
	public int PostalCode { get; set; }
        
	[Required(ErrorMessage = "Veuillez renseigner votre mot de passe")]
	public string Password { get; set; } = string.Empty;
        
	[Required(ErrorMessage = "Veuillez confirmer votre mot de passe")]
	public string Confirm { get; set; } = string.Empty;
}