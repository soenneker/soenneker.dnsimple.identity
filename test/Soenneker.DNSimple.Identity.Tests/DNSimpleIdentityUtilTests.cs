using FluentAssertions;
using Soenneker.DNSimple.Identity.Abstract;
using Soenneker.Facts.Local;
using Soenneker.Tests.FixturedUnit;
using System.Threading.Tasks;
using Soenneker.DNSimple.Identity.Responses;
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

    [LocalFact]
    public async ValueTask Whoami_should_not_fail()
    {
        DNSimpleWhoamiResponse? result = await _util.Whoami(CancellationToken);
        result.Should().NotBeNull();
    }
}
