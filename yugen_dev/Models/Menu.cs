using System.ComponentModel.DataAnnotations;
namespace yugen_dev.Models;

public class Menu
{
    public int Id { get; set; }
    [Display(Name = "Nom de menu en français")]
    public string NameFr { get; set; }
    [Display(Name = "Nom de menu en japonais")]
    public string NameJap { get; set; }
    [Display(Name = "Prix")]
    public int Price { get; set; }
    [Display(Name = "Chemin d'accès de l'image")]
    public string ImagePath { get; set; }
    public ICollection<MenuDish>? MenusDishes { get; set; }

}