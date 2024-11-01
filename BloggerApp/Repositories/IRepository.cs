using BloggerApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerApp.Repositories;



/// <summary>
/// This is the generic repository  
/// the CRUD is defined
/// </summary>
public interface IRepository<T,K> where T : class
{
    T? Create(T t);
    T? Update(T t);
    bool Delete(K id); 
    T? Get(K id);
    ImmutableList<T> Get();  
}
