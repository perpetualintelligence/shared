/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Protocols.Authorization
{
    /// <summary>
    /// Defines a well known base address with associated HTTP client name.
    /// </summary>
    public class WellKnownBaseAddress
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="name">The HTTP client name.</param>
        /// <param name="baseAddress">The base address.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public WellKnownBaseAddress(string name, string baseAddress)
        {
            BaseAddress = baseAddress ?? throw new ArgumentNullException(nameof(baseAddress));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// The base address.
        /// </summary>
        public string BaseAddress { get; set; }

        /// <summary>
        /// The HTTP client name.
        /// </summary>
        public string Name { get; set; }
    }
}
