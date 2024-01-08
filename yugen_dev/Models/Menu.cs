using System.ComponentModel.DataAnnotations;

namespace yugen_dev.Models;

public class Menu
{
    public int Id { get; set; }

    [Display(Name = "Nom du menu en français")]
    public string NameFr { get; set; }
    [Display(Name = "Nom du menu en japonais")]
    public string NameJap { get; set; }
    [Display(Name = "Prix")]
    public int Price { get; set; } //One review belong to a single client  
    public ICollection<MenuDish>? MenusDishes { get; set; }

}