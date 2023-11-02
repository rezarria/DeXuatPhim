using DeXuatApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DeXuatApp.DbContexts;

public class MovieDbContext : DbContext
{
    public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; } = null!;
    public DbSet<Cast> Casts { get; set; } = null!;
    public DbSet<Company> Companies { get; set; } = null!;
    public DbSet<Country> Countries { get; set; } = null!;
    public DbSet<Crew> Crews { get; set; } = null!;
    public DbSet<Director> Directors { get; set; } = null!;
    public DbSet<Genre> Genres { get; set; } = null!;
    public DbSet<Keyword> Keywords { get; set; } = null!;
    public DbSet<Language> Languages { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>()
            .HasMany(e => e.Casts)
            .WithMany(e => e.Movies);
        modelBuilder.Entity<Movie>()
            .HasMany(e => e.Crews)
            .WithMany(e => e.Movies);
        modelBuilder.Entity<Movie>()
            .HasMany(e => e.Keywords)
            .WithMany(e => e.Movies);
        modelBuilder.Entity<Movie>()
            .HasMany(e => e.ProductionCompanies)
            .WithMany(e => e.Movies);
        modelBuilder.Entity<Movie>()
            .HasMany(e => e.Genres)
            .WithMany(e => e.Movies);
        modelBuilder.Entity<Movie>()
            .HasMany(e => e.ProductionCountries)
            .WithMany(e => e.Movies);
        modelBuilder.Entity<Movie>()
            .HasMany(e => e.SpokenLanguages)
            .WithMany(e => e.Movies);
        modelBuilder.Entity<Movie>()
            .HasIndex(e => e.DataId).IsUnique();
        modelBuilder.Entity<Movie>()
            .HasOne(e => e.Director)
            .WithMany(e => e.Movies);
    }
}