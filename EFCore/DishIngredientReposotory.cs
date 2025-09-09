using Microsoft.EntityFrameworkCore;
using System;
using EFCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore;
internal class DishIngredientReposotory : IDishIngredientReposotory
{
    private readonly MyDbContext _dbContext;

    public DishIngredientReposotory(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }



    public async Task DishIngredienceTogetherAsync(List<int> ingredienceID, int id)
    {

        var dish = await _dbContext.Dish
            .Where(x => x.Id == id)
            .Include(d => d.Ingrediences)
            .FirstOrDefaultAsync();

        //if (dish == null)
        //    return;


        var ingrediences = await _dbContext.Ingredience
            .Include(i => i.Dishes)
            .ToListAsync();

        foreach (var item in ingredienceID)
        {
            foreach (var ing in ingrediences)
            {
                dish.Ingrediences.Add(ing);
            }
        }

        await _dbContext.SaveChangesAsync();
    }
}
