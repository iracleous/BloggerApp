using BloggerApp.Context;
using BloggerApp.Dtos;
using BloggerApp.Models;
using BloggerApp.Patterns;
using BloggerApp.Repositories;
using BloggerApp.Services;

PostDto post = new PostDto
{
    Title = "This is my post about technology",
    Description = "This is the description of the post",
    Author = "Dimitris" 
};

BlogDbContext blogDbContext = new BlogDbContext();

IRepository<Post,int> postRepository = new PostRepository(blogDbContext);
BlogService blogService = new BlogService(postRepository);
await blogService.CreatePostAsync(post);



var pages = await blogService.GetAllPostAsync(1, 10);
    pages.ForEach( post => Console.WriteLine(
    $"{post.Id},{post.Created},{post.Title},{post.Author}"));




Console.WriteLine("--------------------------------");
ListManipulation listManipulation = new ListManipulation();
listManipulation
    .CountAuthorCities()
    .ForEach(analysis => Console.WriteLine($"{analysis.CityName},{analysis.Count}"));



Console.WriteLine("--------------------------------");

List<string> names = listManipulation.GetAuthorStartingFrom("D");
names.ForEach(name => Console.WriteLine(name));


Console.WriteLine("--------------------------------");
Singleton singleton =   Singleton.GetInstance();
singleton.DoWork();

Console.WriteLine("--------------------------------");
UseOfSpecifications.UsingSpecifications();