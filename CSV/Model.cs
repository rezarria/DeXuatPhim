using System.Collections.ObjectModel;
using CsvHelper.Configuration.Attributes;

namespace DeXuatApp.CSV;

public class Model
{
    public ulong? Index { get; set; }
    public ulong? Budget { get; set; }
    public string? Genres { get; set; }
    public string? Homepage { get; set; }
    public ulong? Id { get; set; }
    public string? Keywords { get; set; }
    [Name("original_language")]
    public string? OriginalLanguage { get; set; }
    [Name("original_title")]
    public string? OriginalTitle { get; set; }
    public string? Overview { get; set; }
    public double? Popularity { get; set; }
    [Name("production_companies")]
    public string? ProductionCompanies { get; set; }
    [Name("production_countries")]
    public string? ProductionCountries { get; set; }
    [Name("release_date")]
    public DateTime? ReleaseDate { get; set; }
    public string? Revenue { get; set; }
    public double? Runtime { get; set; }
    [Name("spoken_languages")]
    public string? SpokenLanguages { get; set; }
    public string? Status { get; set; }
    public string? Tagline { get; set; }
    public string? Title { get; set; }
    [Name("vote_average")]
    public double? VoteAverage { get; set; }
    [Name("vote_count")]
    public ulong?  VoteCount { get; set; }
    public string? Cast { get; set; }
    public string? Crew { get; set; }
    public string? Director { get; set; }
}