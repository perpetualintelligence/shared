/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// Custom data types for rendering razor components.
    /// </summary>
    [Refactor("I think this does not belong to Attributes namespace.")]
    public sealed class CustomDataTypes
    {
        /// <summary>
        /// </summary>
        public const string Bool = nameof(Bool);

        /// <summary>
        /// </summary>
        public const string Double = nameof(Double);

        /// <summary>
        /// </summary>
        public const string Enumeration = nameof(Enumeration);

        /// <summary>
        /// </summary>
        public const string Int = nameof(Int);

        /// <summary>
        /// </summary>
        public const string MultiSelect = nameof(MultiSelect);

        /// <summary>
        /// </summary>
        public const string SingleSelect = nameof(SingleSelect);

        /// <summary>
        /// </summary>
        public const string StringList = nameof(StringList);

        /// <summary>
        /// </summary>
        public const string StringDictionary = nameof(StringDictionary);

        /// <summary>
        /// </summary>
        public const string SubObject = nameof(SubObject);

        /// <summary>
        /// </summary>
        public const string SubObjectList = nameof(SubObjectList);
    }
}