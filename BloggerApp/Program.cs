using BloggerApp.Dtos;
using BloggerApp.Models;
using BloggerApp.Repositories;
using BloggerApp.Services;

PostDto post = new PostDto
{
    Title = "This is my post about technology",
    Description = "This is the description of the post",
    Author = "Dimitris" 
};


IRepository<Post,int> postRepository = new PostRepository();
BlogService blogService = new BlogService(postRepository);
blogService.CreatePost(post);
blogService.CreatePost(post);
blogService.CreatePost(post);


blogService.GetAllPost().ForEach( post => Console.WriteLine(
    $"{post.Id},{post.Created},{post.Title},{post.Author}"));




Console.WriteLine("--------------------------------");
ListManipulation listManipulation = new ListManipulation();
listManipulation
    .CountAuthorCities()
    .ForEach(analysis => Console.WriteLine($"{analysis.CityName},{analysis.Count}"));