/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PerpetualIntelligence.Data.Shared.Validation
{
    /// <summary>
    /// Specifies the allowed values for a property or a field.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    [ToUnitTest]
    public sealed class AllowedAttribute : ValidationAttribute
    {
        /// <summary>
        /// Initializes a new instance with the specified allowed values.
        /// </summary>
        /// <param name="allowedValues">Allowed values</param>
        public AllowedAttribute(params object?[] allowedValues)
        {
            AllowedValues = allowedValues ?? throw new ArgumentNullException(nameof(allowedValues));
        }

        /// <summary>
        /// The allowed values.
        /// </summary>
        public object?[] AllowedValues { get; }

        /// <inheritdoc/>
        public override bool IsValid(object? value)
        {
            // Null value is OK, this may mean that user has not yet entered any value.
            if (value == null)
            {
                return true;
            }

            // If value is an array compute the difference otherwise check if it exist in the allowed values.
            if (value is object?[] valArray)
            {
                return !valArray.Except(AllowedValues).Any();
            }
            else
            {
                return AllowedValues.Contains(value);
            }
        }
    }
}
