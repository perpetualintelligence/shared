/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Patterns
{
    /// <summary>
    /// Decorator is a structural pattern that allows adding new behaviors to objects dynamically by placing them inside
    /// special wrapper objects. Using decorators you can wrap objects countless number of times since both target
    /// objects and decorators follow the same interface.
    /// </summary>
    /// <typeparam name="TObject">The inner object type.</typeparam>
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
