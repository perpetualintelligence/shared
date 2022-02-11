/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Abstractions.AuthServer
{
    /// <summary>
    /// An abstraction of a generic <c>OAuth</c> and <c>OpenID Connect</c> request handler.
    /// </summary>
    /// <typeparam name="TContext">The handler context.</typeparam>
    /// <typeparam name="TResult">The handler result.</typeparam>
    /// <remarks>An authorization server typically provides both authorization and authentication capabilities.</remarks>
    public interface IAuthHandler<TContext, TResult> : IHandler<TContext, TResult> where TContext : class where TResult : class
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

        /// <summary>
        /// Determines whether the handler issues a redirect callback.
        /// </summary>
        /// <value><c>true</c> is the handler issues a redirect callback, otherwise <c>fasle</c>.</value>
        bool? Redirect { get; }
    }
}
