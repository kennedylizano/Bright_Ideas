using System.ComponentModel.DataAnnotations;

namespace Bright_Ideas.Models
{
  public class LoginViewModel
  {
    [Required]
    [MinLength(1)]
    [EmailAddress]
    public string Email {get; set;}
    [Required]
    [MinLengthAttribute(8)]
    public string Password {get; set;}
  }
}