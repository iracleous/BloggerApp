using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns2.AdapterPattern;

// ITarget interface that the client expects
public interface ITarget
{
    string GetData();
}