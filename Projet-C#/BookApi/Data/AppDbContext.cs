using Microsoft.EntityFrameworkCore;
using BookApi.Models;

namespace BookApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Media> Livres => Set<Media>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ebook>().HasBaseType<Media>();
        modelBuilder.Entity<PaperBook>().HasBaseType<Media>();
    }
}
