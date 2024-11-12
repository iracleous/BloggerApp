using BlogDomain.Dtos;
using BlogDomain.Models;

namespace BlogDomain.Services;

public interface IPostService
{
    Task<List<PostResponseDto>> GetAllPostAsync();
    Task<PostResponseDto?> FindByIdAsync(long id);
    Task<PostResponseDto?> CreatePostAsync(PostRequestDto post);
    Task<PostResponseDto?>  UpdatePostAsync(long id, PostRequestDto post);
    Task<bool> DeleteByIdAsync(long id);
}
