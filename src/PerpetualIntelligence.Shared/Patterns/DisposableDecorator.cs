/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System;

namespace PerpetualIntelligence.Shared.Patterns
{
    /// <summary>
    /// A disposable <see cref="Decorator{TObject}"/>.
    /// </summary>
    /// <typeparam name="TObject">The inner object type. It can be <see cref="IDisposable"/>.</typeparam>
    public class DisposableDecorator<TObject> : Decorator<TObject>, IDisposable
    {
        /// <summary>
        /// Initialize a new instance of decorator.
        /// </summary>
        /// <param name="object">The inner object.</param>
        public DisposableDecorator(TObject @object) : base(@object)
        {
        }

        /// <inheritdoc/>
        public virtual void Dispose()
        {
            (Object as IDisposable)?.Dispose();
        }
    }
}
