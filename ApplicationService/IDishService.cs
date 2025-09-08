using ReceptdatabasÖvning.Web.Models;

namespace ReceptdatabasÖvning.Web.Services;
public interface IDishService
{
    Task AddDishAsync(Dish Ingredience);
    Task DeleteDishAsync(int id);
    Task EditDishAsync(int id);
    Task<List<Dish>> GetDishAsync();
    Task<Dish> GetOneDishAsync(int id);
}