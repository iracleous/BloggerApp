using BloggerApp.Context;
using BloggerApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace BloggerApp.Repositories;

public class PostRepository : IRepository<Post, int>
{
    private readonly BlogDbContext _dbContext;

    public PostRepository(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Post?> CreateAsync(Post post)
    {
        _dbContext.Posts.Add(post);
        await _dbContext.SaveChangesAsync();
        return post;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        Post? post = await GetAsync(id);
        if (post == null)
            return false;
        _dbContext
            .Posts
            .Remove(post);
        await _dbContext.SaveChangesAsync();
        return true;
    }
     
    public async Task<Post?> GetAsync(int id)
    {
        return await  _dbContext
            .Posts
            .FirstOrDefaultAsync(post => post.Id == id);
    }

    public async Task<List<Post>> GetAsync(int pageCount, int pageSize)
    {
        if(pageCount <= 0)
            pageCount = 1;
        if(pageSize <= 0 || pageSize>20)
            pageSize = 10;
        return await
                _dbContext
                .Posts
                .Skip((pageCount - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
    }

    public async Task<Post?> UpdateAsync(Post post)
    {
        Post? postDb = await GetAsync(post.Id);
        postDb.Description = post.Description;
        postDb.Title = post.Title;
        _dbContext.Posts.Update(postDb);
        await _dbContext.SaveChangesAsync();
        return postDb;
    }
}
