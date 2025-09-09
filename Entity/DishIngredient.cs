using ReceptdatabasÖvning.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity;
public class DishIngredient
{
    public int? DishId { get; set; }
    public int? IngredienceId { get; set; }

    public Dish? Dish { get; set; }
    public Ingredience? ingredience { get; set; }
}
