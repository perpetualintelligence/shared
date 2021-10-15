/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

// Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C. https://perpetualintelligence.com https://api.perpetualintelligence.com

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PerpetualIntelligence.Data.Shared.Validation
{
    /// <summary>
    /// Specifies the minimum and maximum length of characters that are allowed in each data field of a list.
    /// </summary>
    public class StringLengthListAttribute : StringLengthAttribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="maximumLength"></param>
        public StringLengthListAttribute(int maximumLength)
            : base(maximumLength) { }

        /// <inheritdoc/>
        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return true;
            }

            if (value is IList<string> arr)
            {
                return !arr.Any(e => e.Length > MaximumLength || e.Length < MinimumLength);
            }
            else
            {
                return false;
            }
        }
    }
}
