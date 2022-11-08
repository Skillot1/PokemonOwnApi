using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewAppMia.Data;
using PokemonReviewAppMia.Interfaces;
using PokemonReviewAppMia.Models;

namespace PokemonReviewAppMia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly DataContext context;
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryController(DataContext context, ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.context = context;
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPokemonsByCategory(int id)
        {
            var pokemons = categoryRepository.GetPokemonByCategory(id);

            return Ok(pokemons);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = categoryRepository.GetCategory(id);

            return Ok(category);
        }

        [HttpPost]
        public IActionResult createCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return Ok(category);
        }



    }
}
