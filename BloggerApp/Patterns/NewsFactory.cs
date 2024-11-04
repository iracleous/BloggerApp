using BloggerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Patterns;

public class NewsFactory
{

    public Post PostFactory(PostCategory category)
    {
        switch (category)
        {
            case PostCategory.None:
                throw new Exception("none category is not supported");
            case PostCategory.SimplePost:
                return new Post { };
            case PostCategory.NewsPost:
                return new NewsPost { };
             default:
                throw new Exception("No such category");
        }

    }

}
