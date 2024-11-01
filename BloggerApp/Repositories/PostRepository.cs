using BloggerApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Repositories;

public class PostRepository : IRepository<Post, int>
{
    private readonly List<Post> posts = [];
    private int indexer = 0;

    public Post? Create(Post post)
    {
        posts.Add(post);
        indexer++;
        post.Id = indexer;
        return post;
    }

    public bool Delete(int id)
    {
        Post? post = Get(id);
        if (post == null)
            return false;
        posts.Remove(post);
        return true;
    }
     
    public Post? Get(int id)
    {
        return posts
             .FirstOrDefault(post => post.Id == id);
    }

    public ImmutableList<Post> Get()
    {
       return  ImmutableList.Create(posts.ToArray());
    }

    public Post? Update(Post post)
    {
        Post? postDb = Get(post.Id);
        if (postDb == null)
            return null;
        postDb.Description = post.Description;
        postDb.Title = post.Title;
        return postDb;
    }
}
