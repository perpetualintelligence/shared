/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes.Api
{
    /// <summary>
    /// Defines an endpoint service.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ServiceAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="serviceId"></param>
        public ServiceAttribute(string serviceId)
        {
            this.ServiceId = serviceId;
        }

        /// <summary>
        /// Service identifier.
        /// </summary>
        public string ServiceId { get; set; }
    }
}
