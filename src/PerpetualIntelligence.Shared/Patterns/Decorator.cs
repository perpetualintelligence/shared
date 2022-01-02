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
    /// Decorator is a structural pattern that allows adding new behaviors to objects dynamically by placing them inside
    /// special wrapper objects. Using decorators you can wrap objects countless number of times since both target
    /// objects and decorators follow the same interface.
    /// </summary>
    /// <typeparam name="TObject">The inner object type.</typeparam>
    /// <seealso href="https://en.wikipedia.org/wiki/Decorator_pattern"/>
    public class Decorator<TObject>
    {
        /// <summary>
        /// Initializes a new instance of decorator.
        /// </summary>
        /// <param name="object">The inner object.</param>
        public Decorator(TObject @object)
        {
            Object = @object;
        }

        /// <summary>
        /// The inner object.
        /// </summary>
        public TObject Object { get; set; }
    }
}
