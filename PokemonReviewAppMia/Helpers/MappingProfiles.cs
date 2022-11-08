using AutoMapper;
using PokemonReviewAppMia.DTOs;
using PokemonReviewAppMia.Models;

namespace PokemonReviewAppMia.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
        }

  
    }
}
