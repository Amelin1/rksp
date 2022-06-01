using Microsoft.EntityFrameworkCore;
using labs_rksp.Data.Models;
public class EducationContext : DbContext
{
    public DbSet<Service> Services { get; set; }
    
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder); optionsBuilder.UseNpgsql(@"Host=localhost;Database=krsv1;Username=postgres;Password=28062002")
            .UseSnakeCaseNamingConvention()
            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole())).EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Service>().Property(p => p.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Order>().Property(p => p.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Address>().Property(p => p.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Product>().HasMany(sl => sl.Orders).WithMany(pr => pr.Products);
        modelBuilder.Entity<Service>().HasMany(sl => sl.Orders).WithMany(pr => pr.Services);
        modelBuilder.Entity<Address>().HasMany(sl => sl.Orders).WithMany(pr => pr.Addresses);
    }

}
