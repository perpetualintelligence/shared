/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Defines an Api.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ApiAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="api"></param>
        /// <param name="domain"></param>
        public ApiAttribute(string api, string domain)
        {
            Api = api;
            Domain = domain;
        }

        /// <summary>
        /// The API identifier.
        /// </summary>
        public string Api { get; set; }

        /// <summary>
        /// The API domain.
        /// </summary>
        public string Domain { get; }
    }
}
