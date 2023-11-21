/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    /// <summary>
    /// Specifies the allowed values for a property or a field.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    [WriteUnitTest]
    public sealed class OneOfAttribute : ValidationAttribute
    {
        /// <summary>
        /// Initializes a new instance with the specified allowed values.
        /// </summary>
        /// <param name="allowedValues">Allowed values</param>
        public OneOfAttribute(params object?[] allowedValues)
        {
            AllowedValues = allowedValues ?? throw new ArgumentNullException(nameof(allowedValues));
        }

        /// <summary>
        /// The allowed values.
        /// </summary>
        public object?[] AllowedValues { get; }

        /// <summary>
        /// Validates the specified value with respect to the current validation attribute.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="validationContext">The context information about the validation operation.</param>
        /// <returns>An instance of the <see cref="ValidationResult"/>.</returns>
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Null value is OK, this may mean that user has not yet entered any value.
            if (value == null)
            {
                return ValidationResult.Success;
            }

            // If value is an array compute the difference otherwise check if it exist in the allowed values.
            bool isValid;
            if (value is object?[] valArray)
            {
                isValid = !valArray.Except(AllowedValues).Any();
            }
            else
            {
                isValid = AllowedValues.Contains(value);
            }

            if (isValid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"The field value must be one of the valid values.");
            }
        }
    }
}
