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


var daysElapsed = BlogHandler.DaysElapsed(post);
Console.WriteLine(daysElapsed.ToString());
