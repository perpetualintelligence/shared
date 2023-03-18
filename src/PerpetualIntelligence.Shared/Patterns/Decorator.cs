/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
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
