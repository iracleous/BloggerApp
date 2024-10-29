using BloggerApp.Models;
using BloggerApp.Services;

namespace TestBlogger;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Post post = new Post();

        int days = BlogHandler.DaysElapsed(post);
        Assert.Equal(0, days);
    }
}