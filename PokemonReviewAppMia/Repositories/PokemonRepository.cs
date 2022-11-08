using PokemonReviewAppMia.Data;
using PokemonReviewAppMia.Interfaces;
using PokemonReviewAppMia.Models;

namespace PokemonReviewAppMia.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {

        private readonly DataContext _context;

        public PokemonRepository(DataContext _context)
        {
            this._context = _context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemons.Where(x=> x.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemons.Where(x => x.Name == name).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int id)
        {
            return _context.Pokemons.Any(x => x.Id == id);
        }
    }
}
