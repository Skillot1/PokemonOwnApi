using PokemonReviewAppMia.Data;
using PokemonReviewAppMia.Interfaces;
using PokemonReviewAppMia.Models;

namespace PokemonReviewAppMia.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext context;

        public CategoryRepository(DataContext _context)
        {
            this.context = _context;
        }

        public bool CategoryExists(int id)
        {
            return context.Categories.Any(c => c.Id == id);
        }

        public ICollection<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            var category = context.Categories.Where(c => c.Id == categoryId).FirstOrDefault();
            var leti = 5;

            return category.Pokemons;
        }
    }
}
