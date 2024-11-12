namespace BlogDomain.Models;

public class Author
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public AuthorType AuthorType { get; set; }
    public virtual List<Blog> Blogs { get; set; } = [];
}
