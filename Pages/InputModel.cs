using System.ComponentModel.DataAnnotations;

namespace DeXuatApp.Pages;

public class InputModel
{
    public InputModel()
    {
    }

    [Required] public string Username { get; set; }
    public string Password { get; set; }
}