using PokemonReviewAppMia.Interfaces;
using PokemonReviewAppMia.Repositories;

namespace PokemonReviewAppMia.Helpers
{
    public static class ConfigurationHelpers
    {
        public static void AddRepositoriesDependencyInjection(this IServiceCollection Services)
        {
            Services.AddScoped<IPokemonRepository, PokemonRepository>();
            Services.AddScoped<ICategoryRepository, CategoryRepository>();
        }

    }
}
