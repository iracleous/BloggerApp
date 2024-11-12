using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns2.AdapterPattern;

// The Adaptee has a different interface
public class ThirdPartyService
{
    public string FetchInfo()
    {
        return "Data from ThirdPartyService";
    }
}