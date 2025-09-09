
namespace ApplicationService;

internal interface IDishIngredientService
{
    Task DishIngredienceTogetherAsync(List<int> ingredienceID, int id);
}