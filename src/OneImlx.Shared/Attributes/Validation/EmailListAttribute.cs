/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    /// <summary>
    /// Specifies that a data field value is a list of well formed emails.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class EmailListAttribute : ValidationAttribute
    {
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return true;
            }

            if (value is IList<string> urlArray)
            {
                return !urlArray.Any(e => !IsEmailValid(e));
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
            if (value is IList<string> urlArray)
            {
                // If any of the email is not valid the entire collection is invalid.
                valid = !urlArray.Any(e => !IsEmailValid(e));
            }

            if (valid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("The field value must be a valid email address.");
            }
        }

        /// <summary>
        /// https://github.com/dotnet/runtime/blob/main/src/libraries/System.ComponentModel.Annotations/src/System/ComponentModel/DataAnnotations/EmailAddressAttribute.cs
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private bool IsEmailValid(string? val)
        {
            if (val == null)
            {
                return true;
            }

            // only return true if there is only 1 '@' character and it is neither the first nor the last character
            int index = val.IndexOf('@');

            return
                index > 0 &&
                index != val.Length - 1 &&
                index == val.LastIndexOf('@');
        }
    }
}
