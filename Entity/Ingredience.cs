using System.ComponentModel.DataAnnotations;

namespace ReceptdatabasÖvning.Web;

public class Ingredience
{
    public int Id { get; set; }

    [Display(Name = "Namn på ingrediens", Prompt = "Ange namnet här...")]
    [Required]
    public string? Name { get; set; }

    public ICollection<Dish>? Dishes { get; set; } = new List<Dish>();
}
