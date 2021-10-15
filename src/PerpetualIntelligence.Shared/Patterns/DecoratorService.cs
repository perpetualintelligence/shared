/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Patterns
{
    /// <summary>
    /// <see cref="Decorator{TObject}"/> service.
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
