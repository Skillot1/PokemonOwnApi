using PokemonReviewAppMia.Models;

namespace PokemonReviewAppMia.Interfaces
{
    public interface ICategoryRepository
    {

        ICollection<Category> GetCategories();

        Category GetCategory(int id);

        bool CategoryExists(int id);

        ICollection<Pokemon> GetPokemonByCategory(int categoryId);

    }
}
