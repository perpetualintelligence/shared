/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The custom data types.
    /// </summary>
    public sealed class CustomDataTypes
    {
        /// <summary>
        /// The <see cref="Enum"/> custom data type.
        /// </summary>
        public const string Enumeration = "urn:oneimlx:cdt:enum";

        /// <summary>
        /// The multi-selection custom data type.
        /// </summary>
        public const string MultiSelect = "urn:oneimlx:cdt:mselect";

        /// <summary>
        /// The single-selection custom data type.
        /// </summary>
        public const string SingleSelect = "urn:oneimlx:cdt:sselect";

        /// <summary>
        /// The string key-value pairs custom data type.
        /// </summary>
        public const string StringDictionary = "urn:oneimlx:cdt:sdict";

        /// <summary>
        /// The string list or collection custom data type.
        /// </summary>
        public const string StringList = "urn:oneimlx:cdt:slist";

        /// <summary>
        /// The sub-object custom data type.
        /// </summary>
        public const string SubObject = "urn:oneimlx:cdt:so";

        /// <summary>
        /// The sub-object list or collection custom data type.
        /// </summary>
        public const string SubObjectList = "urn:oneimlx:cdt:solist";
    }
}