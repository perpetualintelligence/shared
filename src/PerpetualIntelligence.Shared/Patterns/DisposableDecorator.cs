/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
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
