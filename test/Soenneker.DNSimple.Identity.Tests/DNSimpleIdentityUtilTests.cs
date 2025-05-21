using Soenneker.DNSimple.Identity.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.DNSimple.Identity.Tests;

[Collection("Collection")]
public class DNSimpleIdentityUtilTests : FixturedUnitTest
{
    private readonly IDNSimpleIdentityUtil _util;

    public DNSimpleIdentityUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IDNSimpleIdentityUtil>(true);
    }

    [Fact]
    public void Default()
    {
    }
}
