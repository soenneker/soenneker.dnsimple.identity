using System.Threading;
using System.Threading.Tasks;
using Soenneker.DNSimple.OpenApiClient.Whoami;

namespace Soenneker.DNSimple.Identity.Abstract;

/// <summary>
/// Utility class for managing DNSimple identity operations
/// </summary>
public interface IDNSimpleIdentityUtil
{
    /// <summary>
    /// Retrieves the details about the current authenticated entity used to access the API.
    /// </summary>
    ValueTask<WhoamiGetResponse_data?> Whoami(CancellationToken cancellationToken = default);
}