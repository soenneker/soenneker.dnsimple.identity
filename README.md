[![](https://img.shields.io/nuget/v/soenneker.dnsimple.identity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dnsimple.identity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dnsimple.identity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dnsimple.identity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dnsimple.identity.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dnsimple.identity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dnsimple.identity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dnsimple.identity/actions/workflows/codeql.yml)

# Soenneker.DNSimple.Identity

Retrieves the DNSimple account or user associated with the configured API token.

## Installation

```bash
dotnet add package Soenneker.DNSimple.Identity
```

## Configuration and registration

```json
{
  "DNSimple": {
    "Token": "your-api-token",
    "Test": false
  }
}
```

```csharp
using Soenneker.DNSimple.Identity.Registrars;

services.AddDNSimpleIdentityUtilAsScoped();
```

## Usage

```csharp
using Soenneker.DNSimple.Identity.Abstract;
using Soenneker.DNSimple.OpenApiClient.Models;

public sealed class IdentityReader(IDNSimpleIdentityUtil identity)
{
    public ValueTask<Whoami200ResponseData?> Get(CancellationToken cancellationToken)
    {
        return identity.Whoami(cancellationToken);
    }
}
```

The response identifies the authenticated account, user, or both, depending on the token. A `null` result means DNSimple returned no identity data; authentication and transport failures still propagate from the generated client.
