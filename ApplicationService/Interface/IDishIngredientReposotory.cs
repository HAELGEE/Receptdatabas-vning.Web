
namespace EFCore;

public interface IDishIngredientReposotory
{
    Task DishIngredienceTogetherAsync(List<int> ingredienceID, int id);
}