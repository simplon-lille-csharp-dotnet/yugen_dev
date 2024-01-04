namespace yugen_dev.Models;
public class MenuDish
{
    public int Id { get; set; }
    public Menu Menu { get; set; } = null!;
    public int MenuId { get; set; }
    public int DishId { get; set; }
    public Dish Dish { get; set; } = null!;

}