using BloggerApp.Dtos;
using BloggerApp.Models;
using BloggerApp.Repositories;
using System.Collections.Immutable;

namespace BloggerApp.Services;

public class BlogService : IBlogService
{
    private readonly IRepository<Post, int> _postRepository;

    public BlogService(IRepository<Post, int> postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<Post?> CreatePostAsync(PostDto post)
    {
        if (post == null) { return null; }
        if (!post.Title.Contains("technology")  ) { return null; }
        if (post.Description.Length>100) post.Description = post.Description.Substring(0,100); 

        return 
            await _postRepository.CreateAsync(
                new Post { Title= post.Title, Description=post.Description, Author = post.Author}
                );
    }

    public async Task<Post?> FindByIdAsync(int id)
    {
        return await _postRepository.GetAsync(id);
    }

    public async Task<List<Post>> GetAllPostAsync(int pageCount, int pageSize)
    {
        return await  _postRepository.GetAsync(pageCount, pageSize);
    }
}
