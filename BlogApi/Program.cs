using BlogDomain.Models;
using BlogDomain.Context;
using BlogDomain.Repositories;
using BlogDomain.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);





// Add services to the container.
builder.Services.AddControllers();
      //    .AddJsonOptions(o => o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BlogDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); ;


builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IRepository<Post,long>, PostRepository>();

//cors 1/3 
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
//cors 2/3 
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:51133")
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
                      });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


//cors 3/3
app.UseCors(MyAllowSpecificOrigins);


app.Run();
