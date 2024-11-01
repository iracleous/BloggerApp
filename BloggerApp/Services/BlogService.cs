using BloggerApp.Dtos;
using BloggerApp.Models;
using BloggerApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Services;

public class BlogService : IBlogService
{
    private readonly IRepository<Post, int> _postRepository;

    public BlogService(IRepository<Post, int> postRepository)
    {
        _postRepository = postRepository;
    }

    public Post? CreatePost(PostDto post)
    {
        if (post == null) { return null; }
        if (!post.Title.Contains("technology")  ) { return null; }
        if (post.Description.Length>100) post.Description = post.Description.Substring(0,100); 

        return 
            _postRepository.Create(
                new Post { Title= post.Title, Description=post.Description, Author = post.Author}
                );
    }

    public Post? FindById(int id)
    {
        return _postRepository.Get(id);
    }

    public List<Post> GetAllPost()
    {
        return _postRepository.Get().ToList();
    }
}
