namespace GenshinReviewApp.Models
{
    public class CharacterOwner
    {
        public int CharacterId { get; set; }
        public int OwnerId { get; set; }
        public Character Character { get; set; }
        public Owner Owner { get; set; }
    }
}
