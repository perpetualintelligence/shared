/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// Represents a login hint that can identify an end-user.
    /// </summary>
    [Flags]
    [MustDo("Why do we need this ?")]
    public enum LoginHintType
    {
        /// <summary>
        /// Email address.
        /// </summary>
        Email = 1,

        /// <summary>
        /// Phone number.
        /// </summary>
        Phone = 2,

        /// <summary>
        /// Username
        /// </summary>
        Username = 4,

        /// <summary>
        /// User identifier.
        /// </summary>
        UserId = 8
    }
}
