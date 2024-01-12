 using System.ComponentModel.DataAnnotations;
 namespace yugen_dev.Models;
 using yugen_dev.ValidationAttributes;
 
 public class Reservation {
    public int Id { get; set; }
    [Required]
    [RegularExpression(@"^\d{1,4}$", ErrorMessage = "Nombre de personnes non valide.")]
    [Display(Name = "Nombre de personnes")]
    public int NumberPeople { get; set; }
    [Required]
    [CustomDateOnOrAfterTodayAttribute(ErrorMessage = "La date de réservation doit être aujourd'hui ou ultérieure.")]
    [Display(Name = "Date de réservation")]
    public DateTime DateReservation { get; set; }
    [Required]
    [CustomTimeReservation(ErrorMessage = "Heure non valide.")]
    [Display(Name = "Heure de réservation")]
    public TimeSpan TimeReservation { get; set; }
    [Display(Name = "Nom si client non enregistré et message")]
    public string? Message { get; set; }
    public Client? Client { get; set; } //One reservation belong to a single client  
 }