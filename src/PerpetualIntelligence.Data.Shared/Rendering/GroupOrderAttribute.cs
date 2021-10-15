/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;
using System.ComponentModel.DataAnnotations;

namespace PerpetualIntelligence.Data.Shared.Rendering
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
