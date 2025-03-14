using KnoxLibrary.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace KnoxLibrary.Persistence;

internal class AppDbContext : DbContext
{
    DbSet<Entry> Entries { get; set; }
    DbSet<Genre> Genres { get; set; }
    DbSet<LiturgicalSeason> LiturgicalSeasons { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var relativePath = @"Data\KnoxLibrary.db";
        var absolutePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).FullName, relativePath);
        optionsBuilder.UseSqlite($"Data Source={absolutePath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Entry>()
            .HasOne(e => e.Genre)
            .WithMany(g => g.Entries);

        modelBuilder.Entity<Entry>()
            .HasOne<LiturgicalSeason>(e => e.LiturgicalSeason)
            .WithMany(ls => ls.Entries);
    }
}