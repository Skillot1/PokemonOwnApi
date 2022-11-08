using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewAppMia.Data;
using PokemonReviewAppMia.DTOs;
using PokemonReviewAppMia.Interfaces;
using PokemonReviewAppMia.Models;

namespace PokemonReviewAppMia.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly DataContext context;
        private readonly IPokemonRepository pokemonRepository;
        private readonly IMapper mapper;

        public PokemonController(DataContext context, IPokemonRepository pokemonRepository, IMapper mapper)
        {
            this.context = context;
            this.pokemonRepository = pokemonRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Pokemon>), 200)]
        public IActionResult GetPokemons()
        {
            var pokemons = pokemonRepository.GetPokemons();

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(pokemons);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Pokemon), 200)]
        public IActionResult GetPokemon( int id)
        {
            var pokemon = pokemonRepository.GetPokemon(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else if (pokemon == null)
                return BadRequest();

           PokemonDto result= mapper.Map<PokemonDto>(pokemon);

            return Ok(result);
        }

        [HttpGet("name/{name}")]
        [ProducesResponseType(typeof(Pokemon), 200)]
        public IActionResult GetPokemon(string name)
        {
            var pokemon = pokemonRepository.GetPokemon(name);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else if (pokemon == null)
                return BadRequest();

            return Ok(pokemon);
        }






    }
}