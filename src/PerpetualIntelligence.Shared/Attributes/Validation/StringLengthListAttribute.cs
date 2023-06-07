/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
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

        /// <summary>
        /// Validates the specified value with respect to the current validation attribute.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="validationContext">The context information about the validation operation.</param>
        /// <returns>An instance of the <see cref="ValidationResult"/>.</returns>
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            bool valid = false;
            if (value is IList<string> arr)
            {
                // If any of the string length is not valid the entire collection is invalid.
                valid = !arr.Any(e => e.Length > MaximumLength || e.Length < MinimumLength);
            }

            if (valid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("The field value must have a valid string length.");
            }
        }
    }
}
