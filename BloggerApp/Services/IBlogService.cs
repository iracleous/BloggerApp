using BloggerApp.Dtos;
using BloggerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Services;

public interface IBlogService
{
    Post? FindById(int id);
    List<Post> GetAllPost();
    Post? CreatePost(PostDto post);
}
