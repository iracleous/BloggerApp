

using BlogDomain.Models;
using BlogDomain.Context;
using Microsoft.EntityFrameworkCore;

namespace BlogDomain.Repositories;

public class PostRepository : IRepository<Post, long>
{
    private readonly BlogDbContext _dbContext;

    public PostRepository(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Post>> GetAsync(int pageCount, int pageSize)
    {
        return await _dbContext.Posts.ToListAsync();
    }

    public async Task<Post?> CreateAsync(Post t)
    {
        _dbContext.Posts.Add(t);
        await _dbContext.SaveChangesAsync();
        return t; 
    }

    public Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Post?> GetAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Post?> UpdateAsync(Post t)
    {
        throw new NotImplementedException();
    }
}
