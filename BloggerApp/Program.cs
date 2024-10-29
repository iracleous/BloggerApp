using BloggerApp.Models;
using BloggerApp.Services;

Post post = new NewsPost {
    Title = "This is my post",
    Description = "This is the description of the post",
    Created = DateTime.Now,
    Id = 300,
    Amount = 10,
    Author = new Author { Name = "Dimitris" }
};

var blogService = new BlogService { };
blogService.CreatePost(post);

Console.WriteLine(blogService.ReadPost());
int days = BlogHandler.DaysElapsed(post);


Console.WriteLine(days);
try {Console.WriteLine($"the lenght of the name of the post is {post.Author.Length}"); }
  catch(Exception ex) {Console.WriteLine("error");}


Console.WriteLine("end");

Guid guid = Guid.NewGuid();


Console.WriteLine(guid);