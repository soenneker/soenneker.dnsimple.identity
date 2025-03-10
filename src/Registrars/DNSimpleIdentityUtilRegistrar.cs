using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.DNSimple.Client.Registrars;
using Soenneker.DNSimple.Identity.Abstract;

namespace Soenneker.DNSimple.Identity.Registrars;

/// <summary>
/// A .NET typesafe implementation of DNSimple's Identity API
/// </summary>
public static class DNSimpleIdentityUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IDNSimpleIdentityUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddDNSimpleIdentityUtilAsSingleton(this IServiceCollection services)
    {
        services.AddDNSimpleClientUtilAsSingleton();
        services.TryAddSingleton<IDNSimpleIdentityUtil, DNSimpleIdentityUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IDNSimpleIdentityUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddDNSimpleIdentityUtilAsScoped(this IServiceCollection services)
    {
        services.AddDNSimpleClientUtilAsScoped();
        services.TryAddScoped<IDNSimpleIdentityUtil, DNSimpleIdentityUtil>();

        return services;
    }
}
