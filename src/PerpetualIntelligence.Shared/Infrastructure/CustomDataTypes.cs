/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The custom data types to support <see cref="System.ComponentModel.DataAnnotations.DataType.Custom"/>.
    /// </summary>
    public sealed class CustomDataTypes
    {
        /// <summary>
        /// The <see cref="bool"/> custom data type.
        /// </summary>
        public const string Bool = "urn:oneimlx:cdt:bool";

        /// <summary>
        /// The <see cref="double"/> custom data type.
        /// </summary>
        public const string Double = "urn:oneimlx:cdt:double";

        /// <summary>
        /// The <see cref="Enum"/> custom data type.
        /// </summary>
        public const string Enumeration = "urn:oneimlx:cdt:enum";

        /// <summary>
        /// The <see cref="float"/> custom data type.
        /// </summary>
        public const string Float = "urn:oneimlx:cdt:float";

        /// <summary>
        /// The <see cref="int"/> custom data type.
        /// </summary>
        public const string Int = "urn:oneimlx:cdt:int";

        /// <summary>
        /// The <see cref="long"/> custom data type.
        /// </summary>
        public const string Long = "urn:oneimlx:cdt:long";

        /// <summary>
        /// The multi-selection custom data type.
        /// </summary>
        public const string MultiSelect = "urn:oneimlx:cdt:mselect";

        /// <summary>
        /// The <see cref="short"/> custom data type.
        /// </summary>
        public const string Short = "urn:oneimlx:cdt:short";

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
