using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BloggerApp.Models;

/// <summary>
/// Post model ver.2.1
/// </summary>
public class Post  
{
    [Key]
    public int Id { get; set; } 
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Updated { get; set; }
    [Precision(8,2)]
    public decimal Balance { get; set; }
    public double Amount { get; set; }
    public string Author { get; set; } = string.Empty;
}
