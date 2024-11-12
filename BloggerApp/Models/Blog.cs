namespace BlogDomain.Models;

public class Blog
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public virtual long? AuthorId { get; set; }
    public virtual Author? Author { get; set; }
    public virtual List<Post> Posts { get; set; } = [];
}
