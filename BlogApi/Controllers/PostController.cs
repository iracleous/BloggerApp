using BlogDomain.Dtos;
using BlogDomain.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly ILogger<PostController> _logger;
    private readonly IPostService _service;

    public PostController(ILogger<PostController> logger, IPostService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<PostResponseDto>>> GetPostsAsync()
    {
        return await _service.GetAllPostAsync();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<PostResponseDto?>> GetPostsAsync(long id)
    {
        return await _service.FindByIdAsync(id);
    }

    [HttpPost]
    public async Task<ActionResult<PostResponseDto?>> CreatePostAsync(PostRequestDto post)
    {
        return await _service.CreatePostAsync(post);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<PostResponseDto?>> UpdatePost(long id, PostRequestDto post)
    {
        return await _service.UpdatePostAsync(id, post);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> DeletePostAsync(long id)
    {
        return await _service.DeleteByIdAsync(id);
    }
}