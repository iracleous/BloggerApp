namespace BloggerApp.Models;
/// <summary>
/// Model class of the product
/// </summary>
public class Product
{
    public int Id { get; set; } 
    public string? Name { get; set; } = string.Empty;
    public DateTime RegistrationDate { get; set; }
    public decimal Price { get; set; }
    public string? Category { get; set; }
}
