 namespace  yugen_dev.Models;
 
 public class Reservation {
    public int Id { get; set; }
    public int NumberPeople { get; set; }
    public DateTime DateReservation { get; set; }
    public TimeSpan TimeReservation { get; set; }
    public int Fk_ClientId{ get; set; }
    public Client Client { get; set; } //One reservation belong to a single client  
 }