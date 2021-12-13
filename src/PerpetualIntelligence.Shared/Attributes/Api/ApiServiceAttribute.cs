/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes.Api
{
    /// <summary>
    /// Defines an Api service.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ApiServiceAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="serviceId"></param>
        public ApiServiceAttribute(string serviceId)
        {
            this.ServiceId = serviceId;
        }

        /// <summary>
        /// Service identifier.
        /// </summary>
        public string ServiceId { get; set; }
    }
}
