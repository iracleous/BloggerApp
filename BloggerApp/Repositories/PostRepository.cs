

using BlogDomain.Models;
using BlogDomain.Context;

namespace BlogDomain.Repositories;


public class PostRepository : IRepository<Post, long>
{
    private readonly BlogDbContext _dbContext;

    public PostRepository(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<Post?> CreateAsync(Post t)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Post?> GetAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Post>> GetAsync(int pageCount, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task<Post?> UpdateAsync(Post t)
    {
        throw new NotImplementedException();
    }
}
