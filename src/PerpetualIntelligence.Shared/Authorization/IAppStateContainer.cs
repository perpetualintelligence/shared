/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Security.Claims;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Authorization
{
    /// <summary>
    /// An abstractions of application state container.
    /// </summary>
    public interface IAppStateContainer
    {
        /// <summary>
        /// Sets the <see cref="IAppStateContainer"/> service from the <see cref="ClaimsPrincipal"/>. For client apps
        /// this can be used for singleton state container. For server apps this can be a no-ops as the service
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
        /// Gets the broker tenant id.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetBrokerTenantIdAsync();

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
        /// Gets the force resolve flag.
        /// </summary>
        /// <returns></returns>
        public Task<bool> GetForceResolveAsync();

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
        /// Gets the marketplace.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetMarketplaceAsync();

        /// <summary>
        /// Gets the marketplace resolved flag.
        /// </summary>
        /// <returns></returns>
        public Task<bool> GetMarketplaceResolvedAsync();

        /// <summary>
        /// Gets the publisher tenant id.
        /// </summary>
        /// <returns></returns>
        public Task<string> GetPublisherTenantIdAsync();

        /// <summary>
        /// Initializes the <see cref="IAppStateContainer"/> service from the <see cref="ClaimsPrincipal"/>.
        /// </summary>
        /// <param name="claimsPrincipal">The claims principal.</param>
        /// <returns></returns>
        public Task InitializeAsync(ClaimsPrincipal claimsPrincipal);

        /// <summary>
        /// Determines whether the <see cref="IAppStateContainer"/> is initialized.
        /// </summary>
        /// <returns></returns>
        public Task<bool> IsInitializedAsync();

        /// <summary>
        /// Populates the <see cref="ClaimsPrincipal"/> from the <see cref="IAppStateContainer"/>.
        /// </summary>
        /// <param name="claimsPrincipal">The claims principal.</param>
        /// <returns></returns>
        public Task PopulateAsync(ClaimsPrincipal claimsPrincipal);

        /// <summary>
        /// Resets the <see cref="IAppStateContainer"/> service for the next login.
        /// </summary>
        /// <returns></returns>
        public Task ResetAsync();
    }
}