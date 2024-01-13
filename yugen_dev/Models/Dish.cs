using System.ComponentModel.DataAnnotations;
namespace yugen_dev.Models;
public class Dish
{
    public int Id { get; set; }
    [Display(Name = "Nom du plat en français")]
    public string NameFr { get; set; }
    [Display(Name = "Nom du plat en japonais")]
    public string NameJap { get; set; }
    public string Description { get; set; }
    [Display(Name = "Description détaillée")]
    public string DetailedDescription { get; set; }
    [Display(Name = "Plat phare")]
    public bool SignatureDish { get; set; }
    [Display(Name = "Chemin d'accès de l'image")]
    public string ImagePath { get; set; }
    [Display(Name = "Catégorie")]
    public int Category { get; set; }
    public ICollection<MenuDish>? MenusDishes { get; set; }

}