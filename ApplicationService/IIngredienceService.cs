using ReceptdatabasÖvning.Web;

namespace ReceptdatabasÖvning.Web.Services;
public interface IIngredienceService
{
    Task AddIngredienceAsync(Ingredience ingredience);
    Task DeleteIngredienceAsync(int id);
    Task EditIngredienceAsync(List<int> ingredience, int id);
    Task<List<Ingredience>> GetIngrediencesAsync();
    Task<Ingredience> GetOneIngredienceAsync(int id);
}