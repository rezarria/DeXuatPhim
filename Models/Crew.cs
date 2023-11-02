using System.ComponentModel.DataAnnotations;

namespace DeXuatApp.Models;

public class Crew
{
    [Key] public Guid Id { get; set; }
    public string DataId { get; set; }
    public string CreditId { get; set; }
    public int Gender { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Job { get; set; }
    public HashSet<Movie> Movies { get; set; } = new();
}