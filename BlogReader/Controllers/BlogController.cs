
using BlogDomain.Dtos;
using BlogDomain.Models;
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
    public async Task<ActionResult<List<PostResponseDto>>> GetPostsAsync()
    {
        string url = $"https://localhost:7147/api/post";
        HttpResponseMessage httpMessage = await _httpClient.GetAsync(url);
     httpMessage.EnsureSuccessStatusCode();
     string responseBody = await httpMessage.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        List<PostResponseDto>? posts = JsonSerializer.Deserialize<List<PostResponseDto>>(responseBody, options);

         
     return Ok(posts);
    }

    [HttpPost]
    public async Task<ActionResult<Post>> CreatePostAsync(PostRequestDto post)
    {
        string url = $"https://localhost:7147/api/post";
        HttpResponseMessage httpMessage = await _httpClient.PostAsJsonAsync(url, post);
        httpMessage.EnsureSuccessStatusCode();
        string responseBody = await httpMessage.Content.ReadAsStringAsync();
        Post? posted = JsonSerializer.Deserialize<Post>(responseBody);
        return Ok(posted);
    }

}
