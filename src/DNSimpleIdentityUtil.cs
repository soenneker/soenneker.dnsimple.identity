using Soenneker.DNSimple.Identity.Abstract;
using Soenneker.DNSimple.OpenApiClient;
using Soenneker.DNSimple.OpenApiClient.Whoami;
using Soenneker.DNSimple.OpenApiClientUtil.Abstract;
using Soenneker.Extensions.Task;
using Soenneker.Extensions.ValueTask;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.DNSimple.Identity;

///<inheritdoc cref="IDNSimpleIdentityUtil"/>
public sealed class DNSimpleIdentityUtil : IDNSimpleIdentityUtil
{
    private readonly IDNSimpleOpenApiClientUtil _clientUtil;

    public DNSimpleIdentityUtil(IDNSimpleOpenApiClientUtil clientUtil)
    {
        _clientUtil = clientUtil;
    }

    public async ValueTask<WhoamiGetResponse.WhoamiGetResponse_data?> Whoami(CancellationToken cancellationToken = default)
    {
        DNSimpleOpenApiClient client = await _clientUtil.Get(cancellationToken).NoSync();
        WhoamiGetResponse? response = await client.Whoami.GetAsync(cancellationToken: cancellationToken).NoSync();
        return response?.Data;
    }
}