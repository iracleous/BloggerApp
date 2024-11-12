

using BlogDomain.Models;

namespace BlogDomain.Services;

public class Analysis
{
    public string CityName { get; set; }
    public int Count { get; set; }
}

public  class ListManipulation
{
    private List<Author> data = [
        new Author { Name="Dimitris", Address="Athens"},
        new Author { Name="George",Address="Salonica" },
        new Author { Name="Nick",Address="Salonica" },
        new Author { Name="Ratios",Address="Salonica" },
    ];


    public List<string> GetAuthorCities()
    {
       return  data
            .Select(author => author.Address)  
            .Distinct()
            .ToList();
    }

    public List<Analysis> CountAuthorCities()
    {
        return data
            .GroupBy(author => author.Address)
            .Select(city => new Analysis 
             {  CityName = city.Key,
                Count = city.Count()
             })
             .ToList();
    }

    public List<string> GetAuthorStartingFrom(string query)
    {
        return data
             .Where(author => author.Name.StartsWith(query))
             .Select(author =>author.Name)
             .OrderBy(name => name)
             .Distinct()
             .ToList();
    }


}
