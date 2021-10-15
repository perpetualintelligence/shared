/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System;

namespace PerpetualIntelligence.Data.Shared.Models
{
    /// <summary>
    /// Represents a login hint that can identify an end-user.
    /// </summary>
    [Flags]
    [ToUnitTest]
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
