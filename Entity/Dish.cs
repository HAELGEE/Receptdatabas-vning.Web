using System.ComponentModel.DataAnnotations;

namespace ReceptdatabasÖvning.Web.Models;

public class Dish
{
    public int Id { get; set; }

    [Display(Name = "Ange namnet på maträtten", Prompt = "Ange namnet här...")]
    [Required(ErrorMessage = "Något blev fel")]
    public string? Name { get; set; }

    [Display(Name = "Ange info om rätten", Prompt = "Ange infot här...")]    
    [Required]
    public string? Description { get; set; }

    public ICollection<Ingredience>? Ingrediences { get; set; }
}
