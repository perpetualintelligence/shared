/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// A generic <see cref="Claim"/> based license.
    /// </summary>
    /// <remarks>
    /// A <see cref="License"/> must have <c>exp</c> claim to determine its expiration. If a <see cref="License"/> does
    /// not expire then set <c>exp</c> to <see cref="DateTimeOffset.MaxValue"/> by using the method <see cref="DateTimeOffset.ToUnixTimeSeconds()"/>.
    /// </remarks>
    public abstract class License : System.ComponentModel.License
    {
        /// <summary>
        /// The license claims.
        /// </summary>
        public IEnumerable<Claim> Claims => ClaimsPrincipal.Claims;

        /// <summary>
        /// The license principal.
        /// </summary>
        public ClaimsPrincipal ClaimsPrincipal { get; }

        /// <summary>
        /// The license expiration based on <c>exp</c> claim;
        /// </summary>
        public DateTime Expiration { get; set; }

        /// <summary>
        /// Initialize a new instance with the specified claims.
        /// </summary>
        /// <param name="claims">The license claims.</param>
        protected License(params Claim[] claims) : this(new ClaimsPrincipal(new ClaimsIdentity(claims)))
        {
        }

        /// <summary>
        /// Initialize a new instance with the specified <see cref="ClaimsPrincipal"/>.
        /// </summary>
        /// <param name="claimsPrincipal">The license claims principal.</param>
        protected License(ClaimsPrincipal claimsPrincipal)
        {
            ClaimsPrincipal = claimsPrincipal ?? throw new System.ArgumentNullException(nameof(claimsPrincipal));

            // All license must have an exp claim.
            Claim expClaim = claimsPrincipal.FindFirst("exp");
            if (expClaim != null)
            {
                // Check the exp value
                if (long.TryParse(expClaim.Value, out long expValue))
                {
                    DateTime dateTime = new(expValue);
                    Expiration = dateTime.ToUniversalTime();
                }
                else
                {
                    throw new ErrorException("invalid_license", "The 'exp' claim value is not valid. exp={0}", expValue);
                }
            }
        }
    }
}
