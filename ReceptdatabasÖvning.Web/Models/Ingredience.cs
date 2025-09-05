namespace ReceptdatabasÖvning.Web.Models;

public class Ingredience
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public ICollection<Dish>? Dishes { get; set; }
}
