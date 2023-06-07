/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes.Api
{
    /// <summary>
    /// Defines an api endpoint.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class EndpointAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="id">The endpoint identifier.</param>
        /// <param name="authority">The endpoint authority.</param>
        public EndpointAttribute(string id, string authority)
        {
            Id = id;
            Authority = authority;
        }

        /// <summary>
        /// The endpoint authority.
        /// </summary>
        public string Authority { get; }

        /// <summary>
        /// The endpoint identifier.
        /// </summary>
        public string Id { get; set; }
    }
}
