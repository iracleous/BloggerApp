
using BlogDomain.Dtos;
using BlogDomain.Models;
using BlogDomain.Repositories;

namespace BlogDomain.Services;

/// <summary>
/// 
/// </summary>
public class PostService : IPostService
{
    private readonly IRepository<Post, long> _postRepository;

    public PostService(IRepository<Post, long> postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<PostResponseDto?> CreatePostAsync(PostRequestDto post)
    {
         Post? postdb =     await _postRepository.CreateAsync(new Post { 
             Created=DateTime.Now, 
             Title= post.Title,
             BlogId=post.BlogId,
             Description=post.Description ,
         });
        return new PostResponseDto { 
            Id=postdb?.Id, 
            Title=postdb?.Title,
            AuthorId=postdb?.Blog?.AuthorId,
            AuthorName=postdb?.Blog?.Author?.Name,
            BlogId = postdb?.BlogId,
            BlogTitle = postdb?.Blog?.Name,
        };
    }

    public Task<bool> DeleteByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<PostResponseDto?> FindByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PostResponseDto>> GetAllPostAsync()
    {
        List<Post> posts = await _postRepository.GetAsync(1, 20);
        return posts.Select(item => new PostResponseDto { 
            AuthorId=item?.Blog?.Author?.Id, 
            Id=item?.Id, 
            Title=item?.Title,
            AuthorName=item?.Blog?.Author?.Name,
            BlogId=item?.Blog?.Id,
            BlogTitle = item?.Blog?.Name
        }).ToList();
    }

    public Task<PostResponseDto?> UpdatePostAsync(long id, PostRequestDto post)
    {
        throw new NotImplementedException();
    }
}
