using System.Threading;
using System.Threading.Tasks;
using Soenneker.DNSimple.Identity.Abstract;
using Soenneker.DNSimple.OpenApiClient;
using Soenneker.DNSimple.OpenApiClient.Whoami;
using Soenneker.DNSimple.OpenApiClientUtil.Abstract;

namespace Soenneker.DNSimple.Identity;

///<inheritdoc cref="IDNSimpleIdentityUtil"/>
public sealed class DNSimpleIdentityUtil : IDNSimpleIdentityUtil
{
    private readonly IDNSimpleOpenApiClientUtil _clientUtil;

    public DNSimpleIdentityUtil(IDNSimpleOpenApiClientUtil clientUtil)
    {
        _clientUtil = clientUtil;
    }

    public async ValueTask<WhoamiGetResponse_data?> Whoami(CancellationToken cancellationToken = default)
    {
        DNSimpleOpenApiClient client = await _clientUtil.Get(cancellationToken);
        WhoamiGetResponse? response = await client.Whoami.GetAsWhoamiGetResponseAsync(cancellationToken: cancellationToken);
        return response?.Data;
    }
}