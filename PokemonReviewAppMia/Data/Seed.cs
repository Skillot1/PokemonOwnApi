using PokemonReviewAppMia.Models;

namespace PokemonReviewAppMia.Data
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Pokemons.Any())
            {
                var pokemons = new List<Pokemon>()
                {
                    new Pokemon()
                    {
                            Name = "Pikachu",
                            BirthDate = new DateTime(1903,1,1),
                            Categories = new List<Category>()
                            {
                                new Category () { Name = "Electric"}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", 
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pikachu", Text = "Pickachu is the best a killing rocks", 
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pikachu",Text = "Pickchu, pickachu, pikachu", 
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } ,
                            }
                        },
                        Owners = new List<Owner>()
                        {
                            new Owner(){
                            Name = "Jack London",
                            Gym = "Brocks Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                            }
                        }
                },

                            new Pokemon()
                    {
                            Name = "Squirtle",
                            BirthDate = new DateTime(1903,1,1),
                            Categories = new List<Category>()
                            {
                                new Category () { Name = "Water"}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Squirtle",Text = "Squirtle is the best pokemon, because it is water",
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Squirtle", Text = "Pickachu is the best a killing rocks",
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Squirtle",Text = "Water is the best",
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } ,
                            }
                        },
                        Owners = new List<Owner>()
                        {
                            new Owner(){
                            Name = "Juan Magan",
                            Gym = "Water Gym",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                            }
                        }
                },
                                    new Pokemon()
                    {
                            Name = "Venasuar",
                            BirthDate = new DateTime(1903,1,1),
                            Categories = new List<Category>()
                            {
                                new Category () { Name = "Leaf"}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pikachu",Text = "Venasuar is the best pokemon, because it is lead",
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pikachu", Text = "Venasuar is the best a killing electrics",
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pikachu",Text = "Venasuar, Venasuar, Venasuar",
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } ,
                            }
                        },
                        Owners = new List<Owner>()
                        {
                            new Owner(){
                            Name = "Ash Ketchum",
                            Gym = "Ashs Gym",
                            Country = new Country()
                            {
                                Name = "Millet Town"
                            }
                            }
                        }
                }

                };
                dataContext.Pokemons.AddRange(pokemons);
                dataContext.SaveChanges();
            }
        }
    }
}
