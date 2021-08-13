![pi-banner](https://en.gravatar.com/userimage/152742631/4ab9cb340649391354d65b592b744114.png)

# protocols:oidc
[![status: preview](https://img.shields.io/badge/status-preview-yellow)]()
[![src: private](https://img.shields.io/badge/src-private-red)]()
[![usage: free](https://img.shields.io/badge/usage-free-green)]()
[![License: Apache](https://img.shields.io/badge/License-Apache-yellow.svg)](https://opensource.org/licenses/MIT)

[![Issues](https://img.shields.io/github/issues/perpetualintelligence/protocols)](https://github.com/perpetualintelligence/protocols/issues)
![Deployment](https://vsrm.dev.azure.com/perpetualintelligence/_apis/public/Release/badge/4c5f1531-e837-40e9-9e5e-47abaa3fab37/2/2)
[![Nuget](https://img.shields.io/nuget/vpre/PerpetualIntelligence.Protocols)](https://www.nuget.org/packages/PerpetualIntelligence.Protocols)

The OAuth 2.0 and OpenID Connect 1.0 well-known configuration. For more information see [OAuth 2.0 Authorization Framework](https://datatracker.ietf.org/doc/html/rfc6749) and [OpenID Connect](https://openid.net/connect/) standards.
 
> **Note:** The OAuth 2.1 protocol spec is in progress. Its new features will be supported once the spec is finalized. See [OAuth 2.1 Authorization Protocol](https://datatracker.ietf.org/doc/html/draft-ietf-oauth-v2-1-02) for more details.

The Perpetual Intelligence `oidc` protocol implementation supports following well-known configurations. This document also defines additional configurations to enable enhanced authentication and authorization capabilities. The ***Field*** identifies the code element that defines a configuration. The ***OIDC Value*** identifies a configuration, parameter, protocol or flow name as defined by the OpenID Connect specification.

### Access Token Types 
`PerpetualIntelligence.Protocols.Oidc.AccessTokenTypes`
| Field | Value | Description 
|-|-|-|
| Jwt | `urn:pi:protocols:oidc:at:jwt` | Self-contained Json Web Token. See [JSON Web Token (JWT)](https://datatracker.ietf.org/doc/html/rfc7519) for more information. |
| Opaque | `urn:pi:protocols:oidc:at:opaque` | Opaque token do not embed any identifiable information.

### Acr Values 
`PerpetualIntelligence.Protocols.Oidc.AcrValues`
| Field | Value | Description 
|-|-|-|
| AllowedChargeables | `urn:pi:protocols:oidc:acr:achrgs` | The allowed chargeables. |
| SubscribedChargeables | `uurn:pi:protocols:oidc:acr:schrgs` | The subscribed chargeables. |
| IdentityProvider | `urn:pi:protocols:oidc:acr:idp` | The IDP or an Identity Provider.
| Tenant | `urn:pi:protocols:oidc:acr:tenant` | The tenant for multi-tenancy.

### Application Types 
`PerpetualIntelligence.Protocols.Oidc.ApplicationTypes`
| Field | OIDC Value | Description 
|-|-|-|
| Native | `native` | Native or mobile applications. |
| Web | `web` | The web applications. |

