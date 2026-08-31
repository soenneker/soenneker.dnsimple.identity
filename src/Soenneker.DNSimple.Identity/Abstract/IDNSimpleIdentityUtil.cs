using System.Threading;
using System.Threading.Tasks;
using Soenneker.DNSimple.OpenApiClient.Models;

namespace Soenneker.DNSimple.Identity.Abstract;

/// <summary>
/// Utility class for managing DNSimple identity operations
/// </summary>
public interface IDNSimpleIdentityUtil
{
    /// <summary>
    /// Retrieves the details about the current authenticated entity used to access the API.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>The authenticated account or user identity, or <see langword="null"/> when DNSimple returns no identity data.</returns>
    ValueTask<Whoami200ResponseData?> Whoami(CancellationToken cancellationToken = default);
}
