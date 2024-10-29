using BloggerApp.Models;
using BloggerApp.Services;

Post post = new Post();
post.Title = "This is my post";
post.Description = "This is the description of the post";
post.Created = DateTime.Now;

BlogService blogService = new BlogService();
blogService.CreatePost(post);

Console.WriteLine(blogService.ReadPost());

