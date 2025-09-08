using EFCore;
using Microsoft.EntityFrameworkCore;
using ReceptdatabasÖvning.Web.Models;

namespace ReceptdatabasÖvning.Web.Repositories;

public class DishRepository : IDishRepository
{
    private readonly MyDbContext _dbContext;

    public DishRepository(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<List<Dish>> GetDishAsync()
    {
        return await _dbContext.Dish.ToListAsync();
    }

    public async Task<Dish> GetOneDishAsync(int id)
    {
        return await _dbContext.Dish.Include(d => d.Ingrediences).Where(i => i.Id == id).SingleOrDefaultAsync();
    }

    public async Task AddDishAsync(Dish dish)
    {
        _dbContext.Add(dish);
        await _dbContext.SaveChangesAsync();
    }

    public async Task EditDishAsync(int id)
    {
        Dish dish = await GetOneDishAsync(id);

    }
    public async Task DeleteDishAsync(int id)
    {
        Dish ingredience = await GetOneDishAsync(id);
    }
}
