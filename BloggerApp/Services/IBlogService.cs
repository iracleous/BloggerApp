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
    Task<Post?> FindByIdAsync(int id);
    Task<List<Post>> GetAllPostAsync();
    Task<Post?> CreatePostAsync(PostDto post);
}
