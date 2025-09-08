using Microsoft.EntityFrameworkCore;
using ReceptdatabasÖvning.Web.Data;
using ReceptdatabasÖvning.Web.Models;
using ReceptdatabasÖvning.Web.Services;

namespace ReceptdatabasÖvning.Web.Repositories;

public class IngredienceRepository : IIngredienceRepository
{
    private readonly MyDbContext _dbContext;

    public IngredienceRepository(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Ingredience>> GetIngrediencesAsync()
    {
        return await _dbContext.Ingredience.ToListAsync();
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

    public async Task EditIngredienceAsync(List<Ingredience> ingredience, int id)
    {
        foreach (var item in ingredience)
        {

        }


    }
    public async Task DeleteIngredienceAsync(int id)
    {
        Ingredience ingredience = await GetOneIngredienceAsync(id);

    }
}
