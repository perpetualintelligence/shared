/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Net.Mime;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to describes an image.
    /// </summary>
    public interface IImageDescriptor
    {
        /// <summary>
        /// The <see cref="byte"/> representation of an actual image contents or the image locater (URL).
        /// </summary>
        /// <value>The byte array.</value>
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image media types. <see cref="MediaTypeNames"/> for supported values.
        /// </summary>
        /// <value>The media type.</value>
        public string? ImageMediaType { get; set; }

        /// <summary>
        /// The image provider type.
        /// </summary>
        /// <value>The image provider.</value>
        public string? ImageProvider { get; set; }
    }
}
