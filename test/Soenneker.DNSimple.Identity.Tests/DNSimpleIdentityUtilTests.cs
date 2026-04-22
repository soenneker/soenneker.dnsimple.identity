using Soenneker.DNSimple.Identity.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.DNSimple.Identity.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class DNSimpleIdentityUtilTests : HostedUnitTest
{
    private readonly IDNSimpleIdentityUtil _util;

    public DNSimpleIdentityUtilTests(Host host) : base(host)
    {
        _util = Resolve<IDNSimpleIdentityUtil>(true);
    }

    [Test]
    public void Default()
    {
    }
}
