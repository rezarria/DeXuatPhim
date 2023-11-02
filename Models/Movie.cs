using System.ComponentModel.DataAnnotations;

namespace DeXuatApp.Models;

public class Movie
{
    [Key] public Guid Id { get; set; }
    public long DataId { get; set; }
    public string Homepage { get; set; }
    public string Title { get; set; }
    public string OriginalTile { get; set; }
    public string OriginalLanguage { get; set; }
    public string Tagline { get; set; }
    public int Runtime { get; set; }
    public Director Director { get; set; } = null!;
    public HashSet<Cast> Casts { get; set; } = new();
    public HashSet<Crew> Crews { get; set; } = new();
    public long VoteCount { get; set; }
    public double VoteAverage { get; set; }
    public long Revenue { get; set; }
    public DateTime ReleaseDate { get; set; }
    public HashSet<Language> SpokenLanguages { get; set; } = new();
    public HashSet<Country> ProductionCountries { get; set; } = new();
    public HashSet<Company> ProductionCompanies { get; set; } = new();
    public double Popularity { get; set; }
    public string Overview { get; set; }
    public HashSet<Keyword> Keywords { get; set; } = new();
    public HashSet<Genre> Genres { get; set; } = new();
    public long Budget { get; set; }
}