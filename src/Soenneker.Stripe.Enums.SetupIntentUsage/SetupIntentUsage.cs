using Soenneker.Gen.EnumValues;

namespace Soenneker.Stripe.Enums.SetupIntentUsage;

/// <summary>
/// Represents how a payment method saved by a Stripe SetupIntent will be used later.
/// </summary>
[EnumValue<string>]
public sealed partial class SetupIntentUsage
{
    /// <summary>
    /// The payment method will be used immediately while the customer is present.
    /// </summary>
    public static readonly SetupIntentUsage OnSession = new("on_session");

    /// <summary>
    /// The payment method will be used later without the customer present (e.g., auto-recharges).
    /// </summary>
    public static readonly SetupIntentUsage OffSession = new("off_session");
}
