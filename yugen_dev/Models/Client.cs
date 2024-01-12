using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace yugen_dev.Models;

public class Client
{
   public int Id { get; set; }
   [Display(Name = "Prénom")]
   public string FirstName { get; set; }
   [Display(Name = "Nom")]
   public string LastName { get; set; }
   [Display(Name = "Adresse")]
   public string? Address { get; set; }
   [Display(Name = "Préférences")]
   public string? Preferences { get; set; }

   public string IdentityUserId { get; set; }
   public IdentityUser IdentityUser { get; set; }
   public ICollection<Review>? Reviews { get; set; } // A client can have several reviews
   public ICollection<Reservation>? Reservations { get; set; } // A client can have several reservations
}