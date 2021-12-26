/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

namespace PerpetualIntelligence.Protocols.Abstractions.AuthServer
{
    /// <summary>
    /// An abstraction of a generic <c>OAuth</c> and <c>OpenID Connect</c> authorization server request handler.
    /// </summary>
    /// <remarks>An authorization server typically provides both authorization and authentication capabilities.</remarks>
    public interface IAuthServerHandler<TContext, TResult> : IHandler<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Determines whether the handler is disabled.
        /// </summary>
        /// <value><c>true</c> is the handler is disabled, otherwise <c>fasle</c>.</value>
        bool? Disabled { get; }

        /// <summary>
        /// Identifies an endpoint for this handler.
        /// </summary>
        /// <value>The endpoint identifier.</value>
        string EndpointId { get; }
    }
}
