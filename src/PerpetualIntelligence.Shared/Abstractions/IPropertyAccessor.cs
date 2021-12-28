/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Shared.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to query the property parameters for UX rendering.
    /// </summary>
    [Refactor("This interface should not be in the shared.")]
    public interface IPropertyAccessor
    {
        /// <summary>
        /// The property data type.
        /// </summary>
        /// <value>An instance of <see cref="DataTypeAttribute"/></value>
        DataTypeAttribute DataType { get; }

        /// <summary>
        /// The property display parameters.
        /// </summary>
        /// <value>An instance of <see cref="DisplayAttribute"/></value>
        DisplayAttribute Display { get; }

        /// <summary>
        /// The property to render.
        /// </summary>
        /// <value>An instance of <see cref="PropertyInfo"/></value>
        PropertyInfo Property { get; }
    }
}
