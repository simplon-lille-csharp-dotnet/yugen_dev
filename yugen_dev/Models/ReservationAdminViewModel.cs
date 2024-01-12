 using System.ComponentModel.DataAnnotations;
 namespace  yugen_dev.Models;
 using yugen_dev.ValidationAttributes;
 
 public class ReservationAdminViewModel {
    [Required]
    [RegularExpression(@"^\d{1,4}$", ErrorMessage = "Invalid number of people.")]
    [Display(Name = "Nombre de personnes")]
    public int NumberPeople { get; set; }
    [Required]
    [Display(Name = "Date de réservation")]
    public DateTime DateReservation { get; set; }
    [Required]
    [CustomTimeReservation(ErrorMessage = "Invalid time reservation value.")]
    [Display(Name = "Heure de réservation")]
    public TimeSpan TimeReservation { get; set; }
    public string? Message { get; set; }
    public Client? Client { get; set; } //One reservation belong to a single client
    public string? ClientName { get; set; }
 }