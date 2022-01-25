/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Collections.Generic;
using System.Security.Claims;

namespace PerpetualIntelligence.Protocols.Abstractions.Claims
{
    /// <summary>
    /// An abstraction of <see cref="Claim"/> comparer.
    /// </summary>
    public interface IClaimComparer : IEqualityComparer<Claim>
    {
    }
}
