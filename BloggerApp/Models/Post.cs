using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlogDomain.Models;

/// <summary>
/// Post model ver.2.1
/// </summary>
public class Post  
{
    [Key]
    public int Id { get; set; } 
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Updated { get; set; }
    public virtual long? BlogId { get; set; }
    public virtual Blog? Blog { get; set; }
    public virtual long? BlogAuthor => Blog?.Author?.Id;
}
