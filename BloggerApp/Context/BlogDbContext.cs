using BloggerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BloggerApp.Context;

public class BlogDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    public BlogDbContext(DbContextOptions<BlogDbContext> options): base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Set up your connection string and other configuration here
        optionsBuilder.UseSqlServer("Server=localhost; Initial Catalog = Plaisio_EF; Trusted_Connection =true; TrustServerCertificate=true");

        // Enable sensitive data logging (only in development)
        optionsBuilder.EnableSensitiveDataLogging();

        // Additional configurations as needed
    }
}
