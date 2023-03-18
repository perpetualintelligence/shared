/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Collections.Generic;
using System.Security.Claims;

namespace PerpetualIntelligence.Shared.Abstractions.Comparers
{
    /// <summary>
    /// An abstraction of <see cref="Claim"/> comparer.
    /// </summary>
    public interface IClaimComparer : IEqualityComparer<Claim>
    {
    }
}
