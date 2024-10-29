using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Models;

public class NewsPost : Post
{
    public string NewsDetails { get; set; } = string.Empty;
}
