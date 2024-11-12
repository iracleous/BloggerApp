namespace BlogDomain.Dtos;

public class ResponseAPI<T>
{
    public int StatusCode { get; set; }
    public string description { get; set; } = string.Empty;
    public T? Value { get; set; }
}

public class AuthorRequestDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class AuthorResponseDto
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class BlogRequestDto
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class BlogResponseDto
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public long AuthorId { get; set; }
    public string AuthorName { get; set; } = string.Empty;
}

public class PostRequestDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public long BlogId { get; set; } 
}

public class PostResponseDto
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public long AuthorId { get; set; }
    public string AuthorName { get; set; } = string.Empty;
    public long BlogId { get; set; }
    public string BlogTitle { get; set; } = string.Empty;
}
