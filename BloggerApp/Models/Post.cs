using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Models;
/// <summary>
/// Post model ver.2.1
/// </summary>
public class Post  
{
    public int Id { get; set; } = 2_147_483_647;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Author Author { get; set; } = new Author();
    public string Content { get; set; } = string.Empty;
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Updated { get; set; }
    public decimal Balance { get; set; }
    public double Amount { get; set; }
}
