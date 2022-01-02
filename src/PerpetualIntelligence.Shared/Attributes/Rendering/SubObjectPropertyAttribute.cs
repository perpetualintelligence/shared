/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.ComponentModel.DataAnnotations;

namespace PerpetualIntelligence.Shared.Attributes.Rendering
{
    /// <summary>
    /// Instructs the UX rendering to apply the <see cref="DataType"/> and <see cref="Display"/> to the sub-object <see cref="PropertyName"/>.
    /// </summary>
    /// <remarks>
    /// Use this attribute to re-position your property of a sub-object while rendering it in the context of a parent entity.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public sealed class SubObjectPropertyAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="propertyName">The sub-object property to override.</param>
        /// <param name="dataType">The overridden <see cref="DataTypeAttribute.DataType"/></param>
        /// <param name="name">The overridden <see cref="DisplayAttribute.Name"/>.</param>
        /// <param name="description">The overridden <see cref="DisplayAttribute.Description"/>.</param>
        /// <param name="groupName">The overridden <see cref="DisplayAttribute.GroupName"/>.</param>
        /// <param name="order">The overridden <see cref="DisplayAttribute.Order"/>.</param>
        /// <param name="prompt">The overridden <see cref="DisplayAttribute.Prompt"/>.</param>
        /// <param name="shortName">The overridden <see cref="DisplayAttribute.ShortName"/>.</param>
        /// <param name="autoGenerateField">The overridden <see cref="DisplayAttribute.AutoGenerateField"/>.</param>
        /// <param name="autoGenerateFilter">The overridden <see cref="DisplayAttribute.AutoGenerateFilter"/>.</param>
        /// <param name="resourceType">The overridden <see cref="DisplayAttribute.ResourceType"/>.</param>
        public SubObjectPropertyAttribute(
            string propertyName,
            DataType dataType,
            string? name,
            string? description,
            string? groupName,
            int order,
            string? prompt = null,
            string? shortName = null,
            bool autoGenerateField = true,
            bool autoGenerateFilter = false,
            Type? resourceType = null)
        {
            PropertyName = propertyName;

            DataType = new DataTypeAttribute(dataType);

            Display = new DisplayAttribute() { Name = name, Prompt = prompt, Description = description, GroupName = groupName, Order = order, AutoGenerateField = autoGenerateField, AutoGenerateFilter = autoGenerateFilter, ResourceType = resourceType, ShortName = shortName };
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="propertyName">The sub-object property to override.</param>
        /// <param name="customDataType">The overridden <see cref="DataTypeAttribute.CustomDataType"/></param>
        /// <param name="name">The overridden <see cref="DisplayAttribute.Name"/>.</param>
        /// <param name="description">The overridden <see cref="DisplayAttribute.Description"/>.</param>
        /// <param name="groupName">The overridden <see cref="DisplayAttribute.GroupName"/>.</param>
        /// <param name="order">The overridden <see cref="DisplayAttribute.Order"/>.</param>
        /// <param name="prompt">The overridden <see cref="DisplayAttribute.Prompt"/>.</param>
        /// <param name="shortName">The overridden <see cref="DisplayAttribute.ShortName"/>.</param>
        /// <param name="autoGenerateField">The overridden <see cref="DisplayAttribute.AutoGenerateField"/>.</param>
        /// <param name="autoGenerateFilter">The overridden <see cref="DisplayAttribute.AutoGenerateFilter"/>.</param>
        /// <param name="resourceType">The overridden <see cref="DisplayAttribute.ResourceType"/>.</param>
        public SubObjectPropertyAttribute(
            string propertyName,
            string customDataType,
            string? name,
            string? description,
            string? groupName,
            int order,
            string? prompt = null,
            string? shortName = null,
            bool autoGenerateField = true,
            bool autoGenerateFilter = false,
            Type? resourceType = null)
        {
            PropertyName = propertyName;

            DataType = new DataTypeAttribute(customDataType);

            Display = new DisplayAttribute() { Name = name, Prompt = prompt, Description = description, GroupName = groupName, Order = order, AutoGenerateField = autoGenerateField, AutoGenerateFilter = autoGenerateFilter, ResourceType = resourceType, ShortName = shortName };
        }

        /// <summary>
        /// The overridden <see cref="DataTypeAttribute"/>.
        /// </summary>
        public DataTypeAttribute DataType { get; }

        /// <summary>
        /// The overridden <see cref="DisplayAttribute"/>.
        /// </summary>
        public DisplayAttribute Display { get; }

        /// <summary>
        /// The sub-object property to override.
        /// </summary>
        public string? PropertyName { get; set; }
    }
}
