 namespace  yugen_dev.Models;

 public class Review {
    public int Id { get; set; }
    public string Message { get; set; }
    public int Rating { get; set; }
    public int Fk_ClientId{ get; set; }
 }