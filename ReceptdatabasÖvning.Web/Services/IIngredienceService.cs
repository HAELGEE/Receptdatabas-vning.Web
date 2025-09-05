using ReceptdatabasÖvning.Web.Models;

namespace ReceptdatabasÖvning.Web.Services;
public interface IIngredienceService
{
    Task AddIngredienceAsync(Ingredience ingredience);
    Task DeleteIngredienceAsync(int id);
    Task EditIngredienceAsync(int id);
    Task<List<Ingredience>> GetIngrediencesAsync();
    Task<Ingredience> GetOneIngredienceAsync(int id);
}