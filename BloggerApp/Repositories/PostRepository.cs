using BloggerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Repositories;

public class PostRepository
{
    private Post? _post;

    public void CreatePost(Post post)
    {
        _post = post;
    }
    public Post ReadPost()
    {
        return _post ?? new Post();
    }
    public void UpdatePost(Post post)
    {
        _post = post;
    }

    public void DeletePost()
    {
        _post = null;
    }


}
