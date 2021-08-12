![fast_banner_github_914.png](https://en.gravatar.com/userimage/152742631/4ab9cb340649391354d65b592b744114.png)

# protocols [![status: preview](https://img.shields.io/badge/status-preview-yellow)](https://opensource.org/licenses/MIT)
[![License: Apache](https://img.shields.io/badge/License-Apache-yellow.svg)](https://opensource.org/licenses/MIT)
[![Issues](https://img.shields.io/github/issues/perpetualintelligence/protocols)](https://github.com/perpetualintelligence/protocols/issues)
![Deployment](https://vsrm.dev.azure.com/perpetualintelligence/_apis/public/Release/badge/4c5f1531-e837-40e9-9e5e-47abaa3fab37/2/2)
[![Nuget](https://img.shields.io/nuget/vpre/PerpetualIntelligence.Protocols)](https://www.nuget.org/packages/PerpetualIntelligence.Protocols)

This repository tracks issues and features requests towards Perpetual Intelligence `protocols`.

> **Note:** The source `src` is maintained in a private Azure DevOps repo. This is a ***preview*** release, and it is subject to design changes without any advance notice.

## Introduction

Perpetual Intelligence's `imlx` provides managed services for identity, multi-language, licensing, rbac, multi-tenancy, and adaptive UX components.

 `protocols` is a collection of cross-platform abstractions built on top of the .NET Core layer and includes the modern Web authorization and authentication standards. This enables you to address website and application design and development challenges, microservices, authentication, authorization, licensing, and localization in a standard and integrated way.

You can use the `protocols` as a common foundation to build your custom implementations or use our default implementations (planned for furture release).

### Overview

* Perpetual Intelligence `imlx` abstraction and its well-known configurations
* OpenID Connect and OAuth 2.0 abstraction and well-known configurations
* Custom endpoint request, handling, and result abstraction that integrates seamlessly with your existing controllers and API
* Event-driven microservices abstraction
* Common security abstraction

## Packages

### `PerpetualIntelligence.Protocols`
[![usage: free](https://img.shields.io/badge/usage-free-green)]()
[![License: Apache](https://img.shields.io/badge/License-Apache-yellow.svg)](https://opensource.org/licenses/MIT)
[![Nuget](https://img.shields.io/nuget/vpre/PerpetualIntelligence.Protocols)](https://www.nuget.org/packages/PerpetualIntelligence.Protocols)

The `PerpetualIntelligence.Protocols` package is a free cross platform protocols and standards abstraction that is shared across application stack. To get up and running with Nuget packages see [NuGet documentation](https://docs.microsoft.com/en-us/nuget/).

The source `src` is maintained in a private [Azure DevOps](https://azure.microsoft.com/en-us/services/devops/) repo. 


### `PerpetualIntelligence.Protocols.Defaults`
[![usage: paid](https://img.shields.io/badge/usage-paid-orange)]()
[![License: Apache](https://img.shields.io/badge/License-Apache-yellow.svg)](https://opensource.org/licenses/MIT)
[![Nuget](https://img.shields.io/nuget/vpre/PerpetualIntelligence.Protocols)](https://www.nuget.org/packages/PerpetualIntelligence.Protocols)

The `PerpetualIntelligence.Protocols.Defaults` package is a paid cross platform protocols and standards implementation that is shared across application stack. To get up and running with Nuget packages see [NuGet documentation](https://docs.microsoft.com/en-us/nuget/).

The source `src` is maintained in a private [Azure DevOps](https://azure.microsoft.com/en-us/services/devops/) repo. 


## Getting Started

We hope you're excited by the possibilities that `protocols` presents. But, you may be wondering where to start. We recommend that you pick the statement you most identify with and follow the links where they lead. You can always come back and explore another topic at any time.

* "I just want ready-made implementation!"
  * [Jump to the default implementation docs.]()
* "I want to build my own custom implementation."
  * [Jump to the custom implementation docs.]()
* "I want to see examples with ready-made implementation!"
  * [Jump to the default implementation example docs.]()
* "I need to integrate `protocols` with another framework or system."
  * [Jump to the integration docs.](https://fast.design/docs/integrations/introduction)

## Features & benefits

| Topic | Feature | Description | Namespace | 
| ----- | ------- | ----------- | --------- |
| Communication | [Messages](https://github.com/perpetualintelligence/protocols/blob/main/docs/communication/messages.md) | The general purpose messaging abstraction. | `PerpetualIntelligence.Protocols.Communication`
| Communication | [Endpoints](https://github.com/perpetualintelligence/protocols/blob/main/docs/communication/endpoints/intro.md) | The custom endpoint and middleware abstraction to integrate seamlessly with your controllers and API. | `PerpetualIntelligence.Protocols.Communication.Endpoints`
| Communication | [Events](https://github.com/perpetualintelligence/protocols/blob/main/docs/communication/events/intro.md) | The event-driven or subscriber-publisher microservices abstraction. | `PerpetualIntelligence.Protocols.Communication.Events`
| imlx |  well-known | `PerpetualIntelligence.Protocols.Imlx` | [Go to imlx abstraction and its well-known configuration documentation](https://github.com/perpetualintelligence/protocols/blob/main/docs/imlx/intro.md)
| oidc | well-known | `PerpetualIntelligence.Protocols.Oidc` | [Go to OAuth 2.0 and OpenID Connect 1.0 abstraction and its well-known configuration documentation](https://github.com/perpetualintelligence/protocols/blob/main/docs/oidc/intro.md)
| Security | Services | `PerpetualIntelligence.Protocols.Security` | [Go to common security services documentation ](https://github.com/perpetualintelligence/protocols/blob/main/docs/security/intro.md)
| Security | X509 Certificates | `PerpetualIntelligence.Protocols.Security.Certificates.X509` | [Go to X509 certificate based authentication documentation ](https://github.com/perpetualintelligence/protocols/blob/main/docs/se/events/intro.md)

## Contact

* Submit requests and issues on [GitHub](https://github.com/perpetualintelligence/protocols/issues).

