using BlogDomain.Dtos;
using BlogDomain.Models;
using BlogDomain.Repositories;
using BlogDomain.Services;
using Moq;

namespace TestBlogger;

public class PostServiceTest
{
    private readonly Mock<IRepository<Post, long>> _repositoryMock;
    private readonly PostService _postService;

    public PostServiceTest()
    {
        _repositoryMock = new Mock<IRepository<Post, long>>();
        _postService = new PostService(_repositoryMock.Object);
    }

    [Fact]
    public async Task CreatePost_ShouldCallRepositoryAndReturnPost()
    {
        // Arrange
        var authorId = 1;
        var blogId = 1;
        var postTitle = "Title 1";
        var postGivenId = 1;
        var post = new Post
        {
            Id = authorId,
            Title = postTitle,
        };
        var postRequest = new PostRequestDto
        {   BlogId = blogId,
            Title = postTitle ,
        };
        var postResponse = new PostResponseDto
        { 
            AuthorId = authorId,
            Id = postGivenId,
            Title = postTitle,
            BlogId = blogId
        };
        _repositoryMock.Setup(
            repo => repo
            .CreateAsync(It.IsAny<Post>()))
            .ReturnsAsync(post);

        // Act
        var result = await _postService.CreatePostAsync(postRequest);

        // Assert
        _repositoryMock.Verify(repo => repo.CreateAsync(It.IsAny<Post>()), Times.Once);
        Assert.NotNull(result);
        Assert.Equal(post.Title, result.Title);
    }

    [Theory]
    [InlineData(1, "Post 1")]
    [InlineData(2, "Post 2")]
    public async Task GetPostsByBlog_ShouldCallRepositoryAndReturnPosts(
        int postId, string postTitle)
    {
        // Arrange
        var post = new Post {
            Id = postId, 
            Title = postTitle, 
            Description = "Content",
              } ;

        var posts = new List<Post> { post };
        _repositoryMock.Setup(repo => 
        repo.GetAsync(It.IsAny<int>(), It.IsAny<int>()))
            .ReturnsAsync(posts);

        // Act
        var result = await _postService.GetAllPostAsync();
            

        // Assert
        _repositoryMock.Verify(repo => 
        repo.GetAsync(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal(postTitle, result[0].Title);
    }
   
}

