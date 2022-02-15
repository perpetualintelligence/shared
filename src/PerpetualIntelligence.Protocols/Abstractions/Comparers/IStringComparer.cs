/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;
using System.Collections.Generic;

namespace PerpetualIntelligence.Protocols.Abstractions.Comparers
{
    /// <summary>
    /// An abstraction to compare <see cref="string"/>.
    /// </summary>
    public interface IStringComparer : IEqualityComparer<string?>
    {
        /// <summary>
        /// <see cref="StringComparison"/> used to compare string.
        /// </summary>
        StringComparison Comparison { get; }
    }
}
