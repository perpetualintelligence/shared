/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
