/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The <see cref="Claim"/> comparer for OAuth or OpenID Connect authorization protocol.
    /// </summary>
    /// <remarks>
    /// The <see cref="ClaimComparer"/> checks <see cref="Claim.Type"/>, <see cref="Claim.Value"/>,
    /// <see cref="Claim.ValueType"/> and <see cref="Claim.Issuer"/> for equality. The string comparison for
    /// <see cref="Claim.ValueType"/> is <see cref="StringComparison.Ordinal"/> for others it is <see cref="StringComparison.OrdinalIgnoreCase"/>.
    /// </remarks>
    [WriteDocumentation("Explain comparison logic in docs.")]
    [Todo("Do we need to make issuer check optional and configurable ? Can there be a case of same claims from different issuer ? When can it happen ?")]
    public class ClaimComparer : EqualityComparer<Claim>
    {
        /// <inheritdoc/>
        public override bool Equals(Claim x, Claim y)
        {
            if (x == null && y == null)
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            return string.Equals(x.Type, y.Type, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(x.Value, y.Value, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(x.ValueType, y.ValueType, StringComparison.Ordinal) &&
                    string.Equals(x.Issuer, y.Issuer, StringComparison.OrdinalIgnoreCase);
        }

        /// <inheritdoc/>
        public override int GetHashCode(Claim claim)
        {
#if NETSTANDARD2_1_OR_GREATER
            return HashCode.Combine(claim.Type, claim.Value, claim.ValueType, claim.Issuer);
#else
            return GetHashCodeLegacy(claim);
#endif
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "NETSTANDARD2_0")]
        private int GetHashCodeLegacy(Claim claim)
        {
            if (claim is null) return 0;

            int typeHash = claim.Type?.ToLowerInvariant().GetHashCode() ?? 0;
            int valueTypeHash = claim.ValueType?.GetHashCode() ?? 0; // Ordinal Case Sensitive
            int valueHash = claim.Value?.ToLowerInvariant().GetHashCode() ?? 0;
            int issuerHash = claim.Issuer?.ToLowerInvariant().GetHashCode() ?? 0;
            return typeHash ^ valueTypeHash ^ valueHash ^ issuerHash;
        }
    }
}
