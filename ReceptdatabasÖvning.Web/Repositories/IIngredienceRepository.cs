using ReceptdatabasÖvning.Web.Models;

namespace ReceptdatabasÖvning.Web.Repositories;
public interface IIngredienceRepository
{
    Task AddIngredienceAsync(Ingredience ingredience);
    Task EditIngredienceAsync(int id);
    Task DeleteIngredienceAsync(int id);
    Task<List<Ingredience>> GetIngrediencesAsync();
    Task<Ingredience> GetOneIngredienceAsync(int id);
}