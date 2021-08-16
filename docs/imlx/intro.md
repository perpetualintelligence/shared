![pi-banner](https://en.gravatar.com/userimage/152742631/4ab9cb340649391354d65b592b744114.png)

# protocols:imlx
[![status: preview](https://img.shields.io/badge/status-preview-yellow)]()
[![src: private](https://img.shields.io/badge/src-private-red)]()
[![usage: paid](https://img.shields.io/badge/usage-paid-green)]()
[![License: Apache](https://img.shields.io/badge/License-TOS-yellow.svg)](https://opensource.org/licenses/MIT)

[![Issues](https://img.shields.io/github/issues/perpetualintelligence/protocols)](https://github.com/perpetualintelligence/protocols/issues)
![Deployment](https://vsrm.dev.azure.com/perpetualintelligence/_apis/public/Release/badge/4c5f1531-e837-40e9-9e5e-47abaa3fab37/2/2)
[![Nuget](https://img.shields.io/nuget/vpre/PerpetualIntelligence.Protocols)](https://www.nuget.org/packages/PerpetualIntelligence.Protocols)

The Perpetual Intelligence `imlx` well-known configuration. `imlx` provides managed services for identity, multi-language, licensing, rbac, multi-tenancy, and adaptive UX components. 
 
> **Note:** These configurations are part of the Perpetual Intelligence infrastructure. Please do not use it directly in your application code.

The Perpetual Intelligence `oidc` protocol implementation supports following well-known configurations. This document also defines additional configurations to enable enhanced authentication and authorization capabilities.

* The ***Field*** identifies the code element that defines a configuration
* The ***Value*** is the configuration value itself
* The [![infra](https://img.shields.io/badge/-infra-red)]() identifies a configuration, value, parameter, protocol or name defined by the Perpetual Intelligence infrastructure. *Infrastructure components are subject to change without any advance notice. Please do not use it directly in your application code.*

### API Constants 
`PerpetualIntelligence.Protocols.Imlx.ApiConstants`
| Field | Value | Description 
|-|-|-|
| ApiServerHttpClient | `urn:pi:protocols:imlx:api:serverhttp` | The named HTTP client for an API server. |
| ClientAppHttpClient | `urn:pi:protocols:oidc:at:opaque` | The named HTTP client for the client application.
| ContentTypeForm | `application/x-www-form-urlencoded` | The API form content type.
| ContentTypeHtml | `text/html; charset=UTF-8` | The API HTML content type.
| ContentTypeJson | `application/json` | The API JSON content type.
| ContentTypeMultipart | `multipart/form-data` | The API Multipart content type.
| LocalhostEndpoint | `urn:pi:protocols:imlx:api:localhost` | The localhost endpoint.
| ProductionEndpoint | `urn:pi:protocols:imlx:api:production` | The production endpoint.
| LivePayment [![infra](https://img.shields.io/badge/-infra-red)]() | `urn:pi:protocols:imlx:payment:live` | The live mode of payments.
| TestPayment [![infra](https://img.shields.io/badge/-infra-red)]() | `urn:pi:protocols:imlx:payment:test` | The test mode of payments.
| VersionV1Url [![infra](https://img.shields.io/badge/-infra-red)]() | `v1` | The v1 version identifier in the URL.
| VersionV1 [![infra](https://img.shields.io/badge/-infra-red)]() | `1.0` | The v1 version identifier.




