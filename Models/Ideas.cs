using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bright_Ideas.Models;

namespace Bright_Ideas
{
  public class Idea : BaseEntity
  {
    [Key]
    public int IdeaId {get; set;}

    public int UserId {get; set;}
    [Required]
    [MinLength(2, ErrorMessage="Name must be at least 2 characters!")]
    public string UserIdea {get; set;}
    public User Owner {get; set;}
    public List<Like> LikedBy {get; set;}
    public Idea()
    {
      LikedBy = new List<Like>();
    }
  }
}