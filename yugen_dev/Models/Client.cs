namespace yugen_dev.Models;

public class Client
{
   public int Id { get; set; }
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string Email { get; set; }
   public string Address { get; set; }
   public string PhoneNumber { get; set; }
   public string Password { get; set; }
   public string Preferences { get; set; }
   public ICollection<Review>? Reviews { get; set; } // A client can have several reviews
   public ICollection<Reservation>? Reservations { get; set; } // A client can have several reservations
}