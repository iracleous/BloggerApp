using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns2.AdapterPattern;

public static class Client
{
    public static void Main(string[] args)
    {
        // Use the Adapter to connect to the ThirdPartyService
        ThirdPartyService thirdPartyService = new ThirdPartyService();
        ITarget adapter = new Adapter(thirdPartyService);

        // The client code can use the target interface
        Console.WriteLine(adapter.GetData());
    }
}
