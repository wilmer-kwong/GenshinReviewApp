namespace GenshinReviewApp.Models
{
    public class Character
    {
        public int Id { get; set; }
        public int Rarity { get; set; }
        public string Name { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<CharacterCategory> CharacterCategories { get; set; }
        public ICollection<CharacterOwner> CharacterOwners { get; set; }

    }
}
