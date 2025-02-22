using System.ComponentModel.DataAnnotations;

public class UserModel
{
    [Required] public string Name { get; set; } = "";
}