using EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ReceptdatabasÖvning.Web;
using ReceptdatabasÖvning.Web.Services;
using System.Security.Cryptography.X509Certificates;

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
        var dish = await _dishRepository.GetOneDishAsync(id);
                     
        if (dish == null)
            return;
               

        foreach (var item in ingredienceID)
        {
            foreach (var ing in await GetIngrediencesAsync())
            {
                if (item == ing.Id)
                {
                    dish.Ingrediences.Add(ing);
                }
            }
        }
                    await _dbContext.SaveChangesAsync();

    }
    public async Task DeleteIngredienceAsync(int id)
    {
        Ingredience ingredience = await GetOneIngredienceAsync(id);

    }
}
