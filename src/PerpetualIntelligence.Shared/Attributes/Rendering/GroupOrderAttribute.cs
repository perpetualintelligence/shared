/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;
using System.ComponentModel.DataAnnotations;

namespace PerpetualIntelligence.Shared.Attributes.Rendering
{
    /// <summary>
    /// The relative group order for <see cref="DisplayAttribute.GroupName"/> defined in a class. The group order and
    /// <see cref="DisplayAttribute.Order"/> are not the same. The <see cref="DisplayAttribute.Order"/> defines order of
    /// elements inside the group.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class GroupOrderAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="groupName">The group name.</param>
        /// <param name="groupOrder">The group order.</param>
        public GroupOrderAttribute(string groupName, int groupOrder)
        {
            GroupName = groupName;
            GroupOrder = groupOrder;
        }

        /// <summary>
        /// The group name.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// The group order.
        /// </summary>
        public int GroupOrder { get; set; }
    }
}
