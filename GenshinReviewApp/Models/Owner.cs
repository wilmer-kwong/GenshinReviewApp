using Microsoft.AspNetCore.Authentication;

namespace GenshinReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country Country { get; set; }
        public ICollection<CharacterOwner> CharacterOwners { get; set; }
    }
}
