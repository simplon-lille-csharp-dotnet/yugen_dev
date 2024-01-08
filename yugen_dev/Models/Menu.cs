namespace yugen_dev.Models;

public class Menu
{
    public int Id { get; set; }
    public string NameFr { get; set; }
    public string NameJap { get; set; }
    public int Price { get; set; } //One review belong to a single client  
    public ICollection<MenuDish> MenusDishes { get; set; }

}