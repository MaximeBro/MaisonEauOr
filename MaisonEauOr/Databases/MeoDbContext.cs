using MaisonEauOr.Extensions;
using MaisonEauOr.Models;
using Microsoft.EntityFrameworkCore;

namespace MaisonEauOr.Databases;

public class MeoDbContext : DbContext
{
    public DbSet<UserAccount> UserAccounts { get; set; }
    public DbSet<AuthTokenModel> AuthTokens { get; set; }
    public DbSet<BasketProductModel> BasketProducts { get; set; }
    public DbSet<ProductModel> Products { get; set; }
    public DbSet<Option> Options { get; set; }
    public DbSet<DisplayModel> DisplayedProducts { get; set; }
    public DbSet<OrderModel> Orders { get; set; }
    public DbSet<DiscountModel> Discounts { get; set; }
    public DbSet<UsedDiscount> UsedDiscounts { get; set; }
    
    public MeoDbContext(DbContextOptions<MeoDbContext> options) : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../meo-data/meo.db");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DiscountModel>()
            .Property(e => e.Categories)
            .HasConversion(v => v.EnumsToString<ProductCategory>(),
                v => v.StringToEnums<ProductCategory>());
        
        modelBuilder.Entity<DisplayModel>()
            .HasOne(x => x.Product)
            .WithMany()
            .HasForeignKey(x => x.ProductID)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<BasketProductModel>()
            .HasOne(x => x.Product)
            .WithMany()
            .HasForeignKey(x => x.ProductID)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<BasketProductModel>()
            .HasOne(x => x.User)
            .WithMany(x => x.BasketProducts)
            .HasForeignKey(x => x.ClientID)
            .OnDelete(DeleteBehavior.Cascade);
    }
}