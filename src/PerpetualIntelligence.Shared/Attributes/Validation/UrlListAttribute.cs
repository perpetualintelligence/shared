/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    /// <summary>
    /// Specifies that a data field value is a list of well formed URL.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class UrlListAttribute : ValidationAttribute
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
                return !urlArray.Any(e => !IsUrlValid(e));
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// https://github.com/dotnet/runtime/blob/main/src/libraries/System.ComponentModel.Annotations/src/System/ComponentModel/DataAnnotations/UrlAttribute.cs
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private bool IsUrlValid(string? val)
        {
            if (val == null)
            {
                return true;
            }

            return val.StartsWith("http://", StringComparison.OrdinalIgnoreCase)
                || val.StartsWith("https://", StringComparison.OrdinalIgnoreCase)
                || val.StartsWith("ftp://", StringComparison.OrdinalIgnoreCase);
        }
    }
}
