using EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ReceptdatabasÖvning.Web;
using ReceptdatabasÖvning.Web.Services;

namespace ReceptdatabasÖvning.Web.Repositories;

public class IngredienceRepository : IIngredienceRepository
{
    private readonly MyDbContext _dbContext;
    private readonly IDishRepository _dishRepository;

    public IngredienceRepository(MyDbContext dbContext, IDishRepository dishRepository)
    {
        _dbContext = dbContext;
        _dishRepository = dishRepository;
    }

    public async Task<List<Ingredience>> GetIngrediencesAsync()
    {
        return await _dbContext.Ingredience.OrderBy(i => i.Name).Include(i => i.Dishes).ToListAsync();
    }

    public async Task<Ingredience> GetOneIngredienceAsync(int id)
    {
        return await _dbContext.Ingredience.Include(d => d.Dishes).Where(i => i.Id == id).SingleOrDefaultAsync();
    }

    public async Task AddIngredienceAsync(Ingredience ingredience)
    {
        _dbContext.Add(ingredience);
        await _dbContext.SaveChangesAsync();
    }

    public async Task EditIngredienceAsync(List<int> ingredienceID, int id)
    {
        var dish = await _dbContext.Dish
            .Include(d => d.Ingrediences)
            .FirstOrDefaultAsync();

        if (dish == null)        
            return;

        dish.Ingrediences.Clear();


        var ingrediences = await _dbContext.Ingredience
            .Where(i => ingredienceID.Contains(i.Id))
            .Include(i => i.Dishes)
            .ToListAsync();

        foreach (var ing in ingrediences)
        {
            dish.Ingrediences.Add(ing);
            ing.Dishes.Add(dish);
        }
            await _dbContext.SaveChangesAsync();
    }
    public async Task DeleteIngredienceAsync(int id)
    {
        Ingredience ingredience = await GetOneIngredienceAsync(id);

    }
}
