using BloggerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BlogReader.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<BlogController> logger;

    public BlogController(HttpClient httpClient, ILogger<BlogController> logger)
    {
        _httpClient = httpClient;
        this.logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<List<Post>>> GetPostsAsync()
    {
        HttpResponseMessage httpMessage = await _httpClient.GetAsync($"https://localhost:7147/api/posts");
     httpMessage.EnsureSuccessStatusCode();
     string responseBody = await httpMessage.Content.ReadAsStringAsync();
     List<Post>? posts =  JsonSerializer.Deserialize<List<Post>>(responseBody);
     return Ok(posts);
    }
}
