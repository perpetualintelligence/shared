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
[![License: Apache](https://img.shields.io/badge/License-Apache-yellow.svg)](https://opensource.org/licenses/MIT)
[![Nuget](https://img.shields.io/nuget/vpre/PerpetualIntelligence.Protocols)](https://www.nuget.org/packages/PerpetualIntelligence.Protocols)

The `PerpetualIntelligence.Protocols` package is a free cross platform protocols and standards abstraction that is shared across application stack. To get up and running with Nuget packages see [NuGet documentation](https://docs.microsoft.com/en-us/nuget/).

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

### Unopinionated

There are a million and one great ways to build your next website or application. To support the technologies you choose, creating unopinionated code is at the center of every decision we make in FAST.

This principle of being unopinionated manifests in several important ways including:

* A flat component architecture that lets you compose what you need without struggling with rigid patterns and complex objects.
* Separating base components from styles and design systems to support multiple implementations without re-writing or duplicating styles. Use the design system to customize existing styled components, or build your own styles, with your design system, without having to rebuild or duplicate the base components.
* Framework agnostic tooling that lets you use our development tools with any view framework.
* The ability to replace almost any FAST package with your package of choice. Get started with our animation package and add more as you need them. Alternatively, use our suite of packages to build your next project from the ground up; it's your call.

### UI development and style guide tools

When developing components and views, excellent development tooling can make all the difference. FAST offers development and style guide tools that work with FAST components, components from other frameworks, or your components.

Try out component properties with an auto-generated property UI, get a live preview of the code based on any property’s configuration, preview localization (RTL/LTR) and themes, and preview component compositing with a transparency grid.

Also, we built FAST development tools from re-usable packages, so if you have special needs, you can build your tools from the same shared libraries.

### Bring your design system

Widely available design systems from companies like Microsoft (Fluent), Google (Material), or Salesforce (Lightning) are useful when it is essential to align with a platform or take advantage of a polished system at low cost, but many companies have a design system of their own, and some may have multiple design systems or variations.

Because FAST has abstracted base components from their style, you get a head start on your design system by building on top of tried and true base components and style libraries like our offerings for color, animation, and elevation.

## Contact

* Submit requests and issues on [GitHub](https://github.com/perpetualintelligence/protocols/issues).

