/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

namespace PerpetualIntelligence.Shared.Patterns
{
    /// <summary>
    /// The disposable <see cref="DisposableDecorator{TObject}"/> service for dependency injection.
    /// </summary>
    /// <typeparam name="TService">The service type.</typeparam>
    /// <typeparam name="TImpl">The service implementation type.</typeparam>
    public class DisposableDecoratorService<TService, TImpl> : DisposableDecorator<TService> where TImpl : class, TService
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="implementation">The service implementation.</param>
        public DisposableDecoratorService(TImpl implementation) : base(implementation)
        {
        }
    }
}
