

using BlogDomain.Models;

namespace BlogDomain.Services;

public static class BlogHandler
{
    /// <summary>
    /// Calculates the time period in days between today 
    /// and the post creation
    /// </summary>
    /// <param name="post"></param>
    /// <returns></returns>
    public static  int DaysElapsed(Post post)
    {
        return post.Created.Subtract(DateTime.Today).Days;
    }
}
