using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Models;

public class Author
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Post Post { get; set; }  
    public string Address { get; set; }
}
