using MaisonEauOr.Models;
using Microsoft.EntityFrameworkCore;

namespace MaisonEauOr.Databases;

public class MeoDbContext : DbContext
{
    public DbSet<UserAccount> UserAccounts { get; set; }
    
    public MeoDbContext(DbContextOptions<MeoDbContext> options) : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../meo-data/meo.db");
    }
}