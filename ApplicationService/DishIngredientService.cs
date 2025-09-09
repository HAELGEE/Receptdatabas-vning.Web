using EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService;
internal class DishIngredientService : IDishIngredientService
{
    private readonly IDishIngredientReposotory _dishIngredientReposotory;

    public DishIngredientService(IDishIngredientReposotory dishIngredientReposotory)
    {
        _dishIngredientReposotory = dishIngredientReposotory;
    }


    public async Task DishIngredienceTogetherAsync(List<int> ingredienceID, int id)
    {

        _dishIngredientReposotory.DishIngredienceTogetherAsync(ingredienceID, id);
    }
}
