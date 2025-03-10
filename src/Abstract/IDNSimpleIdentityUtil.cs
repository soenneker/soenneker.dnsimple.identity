using Soenneker.DNSimple.Identity.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.DNSimple.Identity.Abstract;

/// <summary>
/// A .NET typesafe implementation of DNSimple's Identity API
/// </summary>
public interface IDNSimpleIdentityUtil
{
    ValueTask<DNSimpleWhoamiResponse?> Whoami(CancellationToken cancellationToken = default);
}
