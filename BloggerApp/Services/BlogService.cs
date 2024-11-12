
using BlogDomain.Dtos;
using BlogDomain.Models;
using BlogDomain.Repositories;

namespace BlogDomain.Services;

/// <summary>
/// 
/// </summary>
public class BlogService : IPostService
{
    private readonly IRepository<Post, int> _postRepository;

    public BlogService(IRepository<Post, int> postRepository)
    {
        _postRepository = postRepository;
    }

    public Task<PostResponseDto?> CreatePostAsync(PostRequestDto post)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<PostResponseDto?> FindByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<PostResponseDto>> GetAllPostAsync()
    {
        throw new NotImplementedException();
    }

    public Task<PostResponseDto?> UpdatePostAsync(long id, PostRequestDto post)
    {
        throw new NotImplementedException();
    }
}
