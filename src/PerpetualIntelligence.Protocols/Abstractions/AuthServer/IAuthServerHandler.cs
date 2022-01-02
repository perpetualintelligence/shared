/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Protocols.Abstractions.AuthServer
{
    /// <summary>
    /// An abstraction of a generic <c>OAuth</c> and <c>OpenID Connect</c> request handler.
    /// </summary>
    /// <typeparam name="TContext">The handler context.</typeparam>
    /// <typeparam name="TResult">The handler result.</typeparam>
    /// <remarks>An authorization server typically provides both authorization and authentication capabilities.</remarks>
    public interface IAuthServerHandler<TContext, TResult> : IHandler<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Determines whether the handler issues a callback.
        /// </summary>
        /// <value><c>true</c> is the handler issues a callback, otherwise <c>fasle</c>.</value>
        bool? Callback { get; }

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
