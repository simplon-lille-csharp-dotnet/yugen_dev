namespace yugen_dev.Models;
public class Dish
{
    public int Id { get; set; }
    public string NameFr { get; set; }
    public string NameJap { get; set; }
    public string Description { get; set; }
    public string DetailedDescription { get; set; }
    public bool SignatureDish { get; set; }
}