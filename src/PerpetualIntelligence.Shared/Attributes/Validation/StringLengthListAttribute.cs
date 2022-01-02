/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PerpetualIntelligence.Shared.Attributes.Validation
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
