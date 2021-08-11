![fast_banner_github_914.png](https://en.gravatar.com/userimage/152742631/4ab9cb340649391354d65b592b744114.png)

# protocols
The repository tracks issues and features requests towards PerpetualIntelligence.Protocols package.

[![License: Apache](https://img.shields.io/badge/License-Apache-yellow.svg)](https://opensource.org/licenses/MIT)
[![Build status](https://dev.azure.com/perpetualintelligence/Services/_apis/build/status/Continuous%20Integration/Packages/PerpetualIntelligence.Protocols)](https://dev.azure.com/perpetualintelligence/Services/_build/latest?definitionId=23)

:star: `src` is maintained in a private repo.

## Introduction

Perpetual Intelligence's `imlx` provides managed services for identity, multi-language, licensing, rbac, multi-tenancy, and adaptive UX components.

 `protocols` is a collection of cross-platform abstractions built on top of the .NET Core layer and includes the modern Web authorization and authentication standards. This enables you to address website and application design and development challenges, microservices, authentication, authorization, licensing, and localization in a standard way.

You can use the abstraction as a common foundation to build your custom implementations or use the OOTB default implementation.

This is the FAST monorepo, containing web component packages, tools, examples, and documentation. FAST tech can be used à la carte or as a suite to build enterprise-grade websites, applications, components, design systems, and more.

**TL;DR**

* Create reusable UI components based on web component standards.
* Use our standard library of pre-built web components in your apps.
* Choose between two *adaptive* design systems: Fluent Design and FAST Frame.
* Build your own design system without re-implementing component logic.
* Integrate with any front-end framework or build system.

For an in-depth explanation of FAST [see our docs introduction](https://www.fast.design/docs/introduction/).

## Packages

### `@microsoft/fast-element`

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![npm version](https://badge.fury.io/js/%40microsoft%2Ffast-element.svg)](https://badge.fury.io/js/%40microsoft%2Ffast-element)

The `@microsoft/fast-element` library is a lightweight means to easily build performant, memory-efficient, standards-compliant Web Components. FAST Elements work in every major browser and can be used in combination with any front-end framework or even without a framework. To get up and running with `@microsoft/fast-element` see [the Getting Started guide](https://fast.design/docs/fast-element/getting-started).

### `@microsoft/fast-foundation`

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![npm version](https://badge.fury.io/js/%40microsoft%2Ffast-foundation.svg)](https://badge.fury.io/js/%40microsoft%2Ffast-foundation)

The `@microsoft/fast-foundation` package is a library of Web Component classes, templates, and other utilities intended to be composed into registered Web Components by design systems (e.g. Fluent Design, Material Design, etc.). The exports of this package can generally be thought of as un-styled base components that implement semantic and accessible markup and behavior.

This package does not export Web Components registered as [custom elements](https://developer.mozilla.org/en-US/docs/Web/Web_Components/Using_custom_elements) - it exports parts and pieces intended to be *composed* into Web Components, allowing you to implement your own design language by simply applying CSS styles and behaviors without having to write all the JavaScript that's involved in building production-quality component implementations.

### `@microsoft/fast-components`

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![npm version](https://badge.fury.io/js/%40microsoft%2Ffast-components.svg)](https://badge.fury.io/js/%40microsoft%2Ffast-components)

`@microsoft/fast-components` is a library of Web Components that *composes* the exports of `@microsoft/fast-foundation` with stylesheets aligning to the FAST Frame design system. This composition step registers a custom element. See the [quick start](https://fast.design/docs/components/getting-started) to get started using the components.

### `@fluentui/web-components`

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![npm version](https://badge.fury.io/js/%40fluentui%2Fweb-components.svg)](https://badge.fury.io/js/%40fluentui%2Fweb-components)

`@fluentui/web-components` is a library of Web Components that *composes* `@microsoft/fast-foundation`. `@fluentui/web-components` makes use of different stylesheets and may include components that specifically support Microsoft's Fluent design language.

The source for `@fluentui/web-components` is hosted in [the Fluent UI monorepo](https://github.com/microsoft/fluentui/tree/master/packages/web-components).

### Component Explorer

Launch our [Component Explorer](https://explore.fast.design) to experience our [FAST Components](https://www.npmjs.com/package/@microsoft/fast-components) and development tools.

## Getting Started

We hope you're excited by the possibilities that FAST presents. But, you may be wondering where to start. Here are a few statements that describe various members of our community. We recommend that you pick the statement you most identify with and follow the links where they lead. You can always come back and explore another topic at any time.

* "I just want ready-made components!"
  * [Jump to the component docs.](https://fast.design/docs/components/getting-started)
* "I want to build my own design system."
  * [Jump to the design system docs.](https://fast.design/docs/design-systems/overview)
* "I want to build my own components."
  * [Jump to the fast-element docs.](https://fast.design/docs/fast-element/getting-started)
* "I need to integrate FAST with another framework or build system."
  * [Jump to the integration docs.](https://fast.design/docs/integrations/introduction)

## Joining the Community

Looking to get answers to questions or engage with us in realtime? Our community is most active [on Discord](https://discord.gg/FcSNfg4). Submit requests and issues on [GitHub](https://github.com/Microsoft/fast/issues/new/choose), or join us by contributing on [some good first issues via GitHub](https://github.com/Microsoft/fast/labels/community:good-first-issue).

We look forward to building an amazing open source community with you!

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

* Join the community and chat with us in real-time on [Discord](https://discord.gg/FcSNfg4).
* Submit requests and issues on [GitHub](https://github.com/Microsoft/fast/issues/new/choose).
* Contribute by helping out on some of our recommended first issues on [GitHub](https://github.com/Microsoft/fast/labels/community:good-first-issue).

