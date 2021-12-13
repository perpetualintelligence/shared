/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
        public byte[]? Image { get; set; }

        /// <summary>
        /// The image media types. <see cref="MediaTypeNames"/> for supported values.
        /// </summary>
        public string? ImageMediaType { get; set; }

        /// <summary>
        /// The image provider type.
        /// </summary>
        public string? ImageProvider { get; set; }
    }
}
