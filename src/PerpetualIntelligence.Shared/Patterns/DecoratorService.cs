/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Patterns
{
    /// <summary>
    /// <see cref="Decorator{TObject}"/> service for dependency injection.
    /// </summary>
    /// <typeparam name="TService">The service type.</typeparam>
    /// <typeparam name="TImpl">The service implementation type.</typeparam>
    public class DecoratorService<TService, TImpl> : Decorator<TService> where TImpl : class, TService
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="implementation">The service implementation.</param>
        public DecoratorService(TImpl implementation) : base(implementation)
        {
        }
    }
}
