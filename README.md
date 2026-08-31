[![](https://img.shields.io/nuget/v/soenneker.stripe.enums.setupintentusage.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.setupintentusage/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.setupintentusage/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.setupintentusage/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.stripe.enums.setupintentusage.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.enums.setupintentusage/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.enums.setupintentusage/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.enums.setupintentusage/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Stripe.Enums.SetupIntentUsage

Provides strongly typed `on_session` and `off_session` usage values for configuring how a payment method saved by a Stripe SetupIntent will be used later.

## Installation

```bash
dotnet add package Soenneker.Stripe.Enums.SetupIntentUsage
```

## Usage

```csharp
using Soenneker.Stripe.Enums.SetupIntentUsage;

SetupIntentUsage usage = SetupIntentUsage.OffSession;
string stripeValue = usage.Value; // "off_session"
```

Choose `OnSession` when the customer is expected to be present for later payments. Choose `OffSession` when the payment method is being optimized for merchant-initiated use without the customer present; this does not remove authentication or consent requirements.
