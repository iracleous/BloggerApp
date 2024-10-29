using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Models;

public class Product
{
    public int Id { get; set; }  
    public string? Name { get; set; } = string.Empty;
    public DateTime RegistrationDate { get; set; }

}
