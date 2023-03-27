using GenshinReviewApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GenshinReviewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories{ get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterOwner> CharacterOwners { get; set; }
        public DbSet<CharacterCategory> CharacterCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // link these two ids together (CharacterId and Category Id)
            modelBuilder.Entity<CharacterCategory>()
                .HasKey(pc => new {pc.CharacterId, pc.CategoryId});
            modelBuilder.Entity<CharacterCategory>()
                .HasOne(p => p.Character)
                .WithMany(pc => pc.CharacterCategories)
                .HasForeignKey(p => p.CharacterId);
            modelBuilder.Entity<CharacterCategory>()
                .HasOne(p => p.Category)
                .WithMany(pc => pc.CharacterCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<CharacterOwner>()
                .HasKey(po => new { po.CharacterId, po.OwnerId });
            modelBuilder.Entity<CharacterOwner>()
                .HasOne(p => p.Character)
                .WithMany(po => po.CharacterOwners)
                .HasForeignKey(p => p.CharacterId);
            modelBuilder.Entity<CharacterOwner>()
                .HasOne(p => p.Owner)
                .WithMany(po => po.CharacterOwners)
                .HasForeignKey(c => c.OwnerId);
        }
    }
}
