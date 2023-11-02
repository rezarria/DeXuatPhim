using System.ComponentModel.DataAnnotations;

namespace DeXuatApp.Models;

public class Genre
{
    [Key] public Guid id { get; set; }
    public string name { get; set; }
    public HashSet<Movie> Movies { get; set; } = new();
}