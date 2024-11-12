using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns2.AdapterPattern;

// The Adapter makes ThirdPartyService compatible with ITarget
public class Adapter : ITarget
{
    private readonly ThirdPartyService _thirdPartyService;

    public Adapter(ThirdPartyService thirdPartyService)
    {
        _thirdPartyService = thirdPartyService;
    }

    public string GetData()
    {
        // Adapting the method call
        return _thirdPartyService.FetchInfo();
    }
}
