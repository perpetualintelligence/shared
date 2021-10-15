/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.AspNetCore.Http;
using PerpetualIntelligence.Shared.Attributes;
using System;

namespace PerpetualIntelligence.Protocols.Communication.Endpoints
{
    /// <summary>
    /// The abstraction of an endpoint.
    /// </summary>
    [MustDo("Re-factor this to use ASP.NET Core Endpoint", BlockRelease = true)]
    public interface IEndpoint
    {
        /// <summary>
        /// The endpoint identifier.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The endpoint display name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The endpoint path.
        /// </summary>
        public PathString Path { get; }

        /// <summary>
        /// The endpoint request handler type.
        /// </summary>
        public Type RequestHandler { get; }
    }
}
