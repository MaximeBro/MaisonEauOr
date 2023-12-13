using MaisonEauOr.Models;
using MaisonEauOr.Models.Products;
using Microsoft.EntityFrameworkCore;

namespace MaisonEauOr.Databases;

public class MeoDbContext : DbContext
{
    public DbSet<UserAccount> UserAccounts { get; set; }
    public DbSet<Cosmetics> Cosmetics { get; set; }
    public DbSet<HairProduct> HairProducts { get; set; }
    public DbSet<Honey> Honeys { get; set; }
    public DbSet<MadeHome> MadeHome { get; set; }
    public DbSet<Mist> Mists { get; set; }
    public DbSet<MuscTahara> MuscTaharas { get; set; }
    public DbSet<Perfume> Perfumes { get; set; }
    
    public MeoDbContext(DbContextOptions<MeoDbContext> options) : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../meo-data/meo.db");
    }
}