/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
