/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of a typical client-server API endpoint accessor.
    /// </summary>
    public interface IEndpointAccessor
    {
        /// <summary>
        /// The default scopes.
        /// </summary>
        string[] DefaultScopes { get; }

        /// <summary>
        /// The <c>response_type</c>.
        /// </summary>
        string ResponseType { get; }

        /// <summary>
        /// The <c>redirect_uri</c>.
        /// </summary>
        string RedirectUri { get; }

        /// <summary>
        /// The <c>post_logout_redirect_uri</c>.
        /// </summary>
        string PostLogoutRedirectUri { get; }

        /// <summary>
        /// The <c>client_id</c>.
        /// </summary>
        string ClientId { get; }

        /// <summary>
        /// The authorization endpoint.
        /// </summary>
        string AuthorizeEndpoint { get; }

        /// <summary>
        /// The <c>client_uri</c>.
        /// </summary>
        string ClientUri { get; }

        /// <summary>
        /// The profile endpoint.
        /// </summary>
        string ProfileEndpoint { get; }

        /// <summary>
        /// The registration endpoint.
        /// </summary>
        string RegisterEndpoint { get; }

        /// <summary>
        /// The endpoint authority.
        /// </summary>
        string Authority { get; }

        /// <summary>
        /// The token endpoint.
        /// </summary>
        string TokenEndpoint { get; }     
    }
}
