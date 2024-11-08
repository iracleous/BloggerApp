using BloggerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BloggerApp.Context;

public class BlogDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
}
