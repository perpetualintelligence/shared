/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Security.Claims;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Authorization
{
    /// <summary>
    /// An abstractions of application identifiers.
    /// </summary>
    public interface IAppIdentifiers
    {
        /// <summary>
        /// Sets the <see cref="IAppIdentifiers"/> service from the <see cref="ClaimsPrincipal"/>. For client apps this
        /// can be used for singleton state container. For server apps this can be a no-ops as the service
        /// implementation will be transient or scoped.
        /// </summary>
        /// <param name="claimsPrincipal"></param>
        /// <returns></returns>
        public Task DefaultAsync(ClaimsPrincipal claimsPrincipal);

        /// <summary>
        /// Gets the client app id.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetAppIdAsync();

        /// <summary>
        /// Gets the client app type.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetAppTypeAsync();

        /// <summary>
        /// Gets the login tenant id.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetConsumerObjectIdAsync();

        /// <summary>
        /// Gets the login tenant id.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetConsumerTenantIdAsync();

        /// <summary>
        /// Gets the login object id.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetLoginObjectIdAsync();

        /// <summary>
        /// Gets the login subject.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetLoginSubjectAsync();

        /// <summary>
        /// Gets the login tenant id.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetLoginTenantIdAsync();

        /// <summary>
        /// Gets the provider tenant id.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetProviderTenantIdAsync();

        /// <summary>
        /// Gets the publisher tenant id.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetPublisherTenantIdAsync();

        /// <summary>
        /// Initializes the <see cref="IAppIdentifiers"/> service from the <see cref="ClaimsPrincipal"/>. For client
        /// apps this can be used for singleton state container. For server apps this can be a no-ops as the service
        /// implementation will be transient or scoped.
        /// </summary>
        /// <param name="claimsPrincipal">The claims principal.</param>
        /// <returns></returns>
        public Task InitializeAsync(ClaimsPrincipal claimsPrincipal);

        /// <summary>
        /// Determines whether the <see cref="IAppIdentifiers"/> is initialized.
        /// </summary>
        /// <returns></returns>
        public Task<bool> IsInitializedAsync(ClaimsPrincipal claimsPrincipal);

        /// <summary>
        /// Populates the <see cref="ClaimsPrincipal"/> with claims from <see cref="IAppIdentifiers"/> service.
        /// </summary>
        /// <returns></returns>
        public Task PopulateAsync(ClaimsPrincipal claimsPrincipal);

        /// <summary>
        /// Resets the <see cref="IAppIdentifiers"/> service for the next login.
        /// </summary>
        /// <returns></returns>
        public Task ResetAsync();
    }
}
