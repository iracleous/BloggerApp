using BloggerApp.Dtos;
using BloggerApp.Models;

namespace BloggerApp.Services;

public interface IBlogService
{
    Task<Post?> FindByIdAsync(int id);
    Task<List<Post>> GetAllPostAsync(int pageCount, int pageSize);
    Task<Post?> CreatePostAsync(PostDto post);
}
