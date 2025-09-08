using ReceptdatabasÖvning.Web;

namespace ReceptdatabasÖvning.Web.Repositories;
public interface IDishRepository
{
    Task AddDishAsync(Dish ingreddishence);
    Task DeleteDishAsync(int id);
    Task EditDishAsync(int id);
    Task<List<Dish>> GetDishAsync();
    Task<Dish> GetOneDishAsync(int id);
}