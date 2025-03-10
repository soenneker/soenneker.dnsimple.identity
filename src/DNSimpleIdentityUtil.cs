using Soenneker.DNSimple.Identity.Abstract;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Soenneker.Extensions.HttpClient;
using Soenneker.DNSimple.Client.Abstract;
using Soenneker.DNSimple.Identity.Responses;
using Soenneker.Extensions.ValueTask;

namespace Soenneker.DNSimple.Identity;

/// <inheritdoc cref="IDNSimpleIdentityUtil"/>
public class DNSimpleIdentityUtil: IDNSimpleIdentityUtil
{
    private readonly IDNSimpleClientUtil _clientUtil;

    public DNSimpleIdentityUtil(IDNSimpleClientUtil clientUtil)
    {
        _clientUtil = clientUtil;
    }

    public async ValueTask<DNSimpleWhoamiResponse?> Whoami(CancellationToken cancellationToken = default)
    {
        const string endpoint = "whoami";

        HttpClient client = await _clientUtil.Get(false, cancellationToken).NoSync();

        return await client.SendToType<DNSimpleWhoamiResponse>(HttpMethod.Get, endpoint, cancellationToken: cancellationToken).NoSync();
    }
}
