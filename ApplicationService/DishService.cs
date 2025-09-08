using ReceptdatabasÖvning.Web.Models;
using ReceptdatabasÖvning.Web.Repositories;

namespace ReceptdatabasÖvning.Web.Services;

public class DishService : IDishService
{
    private readonly IDishRepository _dishRepository;
    private readonly IIngredienceRepository _ingredienceRepository;

    public DishService(IDishRepository dishRepository, IIngredienceRepository ingredienceRepository)
    {
        _dishRepository = dishRepository;
        _ingredienceRepository = ingredienceRepository;
    }

    public async Task<List<Dish>> GetDishAsync()
    {
        return await _dishRepository.GetDishAsync();
    }
    public async Task<Dish> GetOneDishAsync(int id)
    {
        return await _dishRepository.GetOneDishAsync(id);
    }

    public async Task AddDishAsync(Dish dish)
    {
        await _dishRepository.AddDishAsync(dish);
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
