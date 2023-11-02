using System.ComponentModel.DataAnnotations;

namespace DeXuatApp.Models;

public class Language
{
    [Key] public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public HashSet<Movie> Movies { get; set; } = new();
}