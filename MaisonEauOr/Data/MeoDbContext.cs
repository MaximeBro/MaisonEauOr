using MaisonEauOr.Models;
using Microsoft.EntityFrameworkCore;

namespace MaisonEauOr.Data;

public class MeoDbContext : DbContext
{
    public DbSet<UserAccount> UserAccounts;
    
    public MeoDbContext(DbContextOptions<MeoDbContext> options) : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../meo-data/meo.db");
    }
}