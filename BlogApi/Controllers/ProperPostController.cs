using BloggerApp.Dtos;
using BloggerApp.Models;
using BloggerApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProperPostController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IBlogService _service;

    public ProperPostController(ILogger logger, IBlogService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Post>>> GetPostsAsync()
    {
        return await _service.GetAllPostAsync(1, 20);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Post?>> GetPostsAsync(int id)
    {
        return await _service.FindByIdAsync(id);
    }

    [HttpPost]
    public async Task<ActionResult<Post?>> CreatePostAsync(PostDto post)
    {
        return await _service.CreatePostAsync(post);
    }
}
