using System.ComponentModel.DataAnnotations;

namespace DeXuatApp.Models;

public class Company
{
    [Key] public Guid Id { get; set; }
    public string Name { get; set; }
    public int DataId { get; set; }
    public HashSet<Movie> Movies { get; set; } = new();
}