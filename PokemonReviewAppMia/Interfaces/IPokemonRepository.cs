﻿using PokemonReviewAppMia.Models;

namespace PokemonReviewAppMia.Interfaces
{
    public interface IPokemonRepository
    {
         ICollection<Pokemon> GetPokemons();

        Pokemon GetPokemon(int id);

        Pokemon GetPokemon(string name);

        bool PokemonExists (int id);


    }
}
