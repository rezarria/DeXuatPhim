using System.ComponentModel.DataAnnotations;

namespace DeXuatApp.Models;

public class Director
{
    [Key] public Guid Id { get; set; }

    public string Name { get; set; }

    public HashSet<Movie> Movies { get; set; }
}