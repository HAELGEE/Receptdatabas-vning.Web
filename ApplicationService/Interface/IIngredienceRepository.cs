using ReceptdatabasÖvning.Web;

namespace ReceptdatabasÖvning.Web.Repositories;
public interface IIngredienceRepository
{
    Task AddIngredienceAsync(Ingredience ingredience);
    Task EditIngredienceAsync(List<int> ingredience, int id);
    Task DeleteIngredienceAsync(int id);
    Task<List<Ingredience>> GetIngrediencesAsync();
    Task<Ingredience> GetOneIngredienceAsync(int id);
}