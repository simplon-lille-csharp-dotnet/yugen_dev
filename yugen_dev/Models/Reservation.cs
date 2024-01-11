 using System.ComponentModel.DataAnnotations;
 namespace  yugen_dev.Models;
 using yugen_dev.ValidationAttributes;
 
 public class Reservation {
    public int Id { get; set; }
    [Required]
    [RegularExpression(@"^\d{1,4}$", ErrorMessage = "Invalid number of people.")]
    public int NumberPeople { get; set; }
    [Required]
    public DateTime DateReservation { get; set; }
    [Required]
    [CustomTimeReservation(ErrorMessage = "Invalid time reservation value.")]
    public TimeSpan TimeReservation { get; set; }
    public string? Message { get; set; }
    public Client? Client { get; set; } //One reservation belong to a single client  
 }