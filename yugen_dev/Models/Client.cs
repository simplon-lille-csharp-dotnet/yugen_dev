using System.ComponentModel.DataAnnotations;
namespace yugen_dev.Models;

public class Client
{
   public int Id { get; set; }
   [Display(Name = "Prénom")]
   public string FirstName { get; set; }
   [Display(Name = "Nom")]
   public string LastName { get; set; }
   public string Email { get; set; }
   [Display(Name = "Adresse")]
   public string Address { get; set; }
   [Display(Name = "Numéro de téléphone")]
   public string PhoneNumber { get; set; }
   [Display(Name = "Mot de passe")]
   public string Password { get; set; }
   [Display(Name = "Préférences")]
   public string Preferences { get; set; }
   public ICollection<Review>? Reviews { get; set; } // A client can have several reviews
   public ICollection<Reservation>? Reservations { get; set; } // A client can have several reservations
}