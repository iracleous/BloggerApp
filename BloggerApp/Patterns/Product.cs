﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns;
 
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
