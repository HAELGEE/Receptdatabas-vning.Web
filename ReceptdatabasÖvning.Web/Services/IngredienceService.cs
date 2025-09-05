using ReceptdatabasÖvning.Web.Models;
using ReceptdatabasÖvning.Web.Repositories;
using System.Collections.Generic;

namespace ReceptdatabasÖvning.Web.Services;

public class IngredienceService : IIngredienceService
{
    private readonly IIngredienceRepository _ingredienceRepository;
    private readonly IDishRepository _dishRepository;

    public IngredienceService(IIngredienceRepository ingredienceRepository, IDishRepository dishRepository)
    {
        _ingredienceRepository = ingredienceRepository;
        _dishRepository = dishRepository;
    }

    public async Task<List<Ingredience>> GetIngrediencesAsync()
    {

        return await _ingredienceRepository.GetIngrediencesAsync();
    }

    public async Task<Ingredience> GetOneIngredienceAsync(int id)
    {
        return await _ingredienceRepository.GetOneIngredienceAsync(id);
    }

    public async Task AddIngredienceAsync(Ingredience ingredience)
    {
        _ingredienceRepository.AddIngredienceAsync(ingredience);
    }

    public async Task EditIngredienceAsync(int id)
    {
        Ingredience ingredience = await GetOneIngredienceAsync(id);

    }

    public async Task DeleteIngredienceAsync(int id)
    {
        Ingredience ingredience = await GetOneIngredienceAsync(id);
    }
}
