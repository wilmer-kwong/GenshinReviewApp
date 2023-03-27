/* Pre-populate the database with data 
 * Test file
 */
using GenshinReviewApp.Data;
using GenshinReviewApp.Models;

namespace GenshinReviewApp
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
            if (!dataContext.CharacterOwners.Any())
            {
                var CharacterOwners = new List<CharacterOwner>()
                {
                    new CharacterOwner()
                    {
                        Character = new Character()
                        {
                            Name = "Jean",
                            Rarity = 5,
                            CharacterCategories = new List<CharacterCategory>()
                            {
                                new CharacterCategory { Category = new Category() { Name = "Wind"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Jean",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Jean", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Jean",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jack",
                            LastName = "Atlas",
                            Country = new Country()
                            {
                                Name = "Canada"
                            }
                        }
                    },
                    new CharacterOwner()
                    {
                        Character = new Character()
                        {
                            Name = "Lisa",
                            Rarity = 4,
                            CharacterCategories = new List<CharacterCategory>()
                            {
                                new CharacterCategory { Category = new Category() { Name = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Lisa",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Lisa", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Lisa",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Sam",
                            LastName = "Smtih",
                            Country = new Country()
                            {
                                Name = "USA"
                            }
                        }
                    },
                    new CharacterOwner()
                    {
                        Character = new Character()
                        {
                            Name = "Amber",
                            Rarity = 4,
                            CharacterCategories = new List<CharacterCategory>()
                            {
                                new CharacterCategory { Category = new Category() { Name = "Fire"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Amber",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Amber", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Amber",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jnine",
                            LastName = "West",
                            Country = new Country()
                            {
                                Name = "Germany"
                            }
                        }
                    }
                };
                dataContext.CharacterOwners.AddRange(CharacterOwners);
                dataContext.SaveChanges();
            }
        }
    }
}
