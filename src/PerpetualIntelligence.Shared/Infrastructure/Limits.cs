/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// Defines the limits for all the Perpetual Intelligence services.
    /// </summary>
    [ToUnitTest]
    [ToDocumentation]
    [Architecture("Automate the limits by adding DisplayAttribute and Group name and that use that to display limits in documentation. Or generate an json that can be used to generate documentation.")]
    [Refactor("I think we should just remove limits and use .NET core options framework to define limits. But then the data validations will not work on models.")]
    public static class Limits
    {
        /// <summary>
        /// Defines the maximum redirect URIs of a client.
        /// </summary>
        public const int MaxClientRedirectUris = 5;

        /// <summary>
        /// Defines the maximum secrets of a client.
        /// </summary>
        public const int MaxClientSecrets = 5;

        /// <summary>
        /// Defines the maximum trusted origins of a client.
        /// </summary>
        public const int MaxClientTrustedEmail = 3;

        /// <summary>
        /// Defines the maximum trusted origins of a client.
        /// </summary>
        public const int MaxClientTrustedOrigin = 3;

        /// <summary>
        /// </summary>
        public const int MaxCustomClaims = 16;

        /// <summary>
        /// </summary>
        public const int MaxDataPerToken = 10;

        /// <summary>
        /// </summary>
        public const int MaxDescriptionLength = 256;

        /// <summary>
        /// </summary>
        public const int MaxFileNameLength = 64;

        /// <summary>
        /// </summary>
        public const int MaxIdLength = 36;

        /// <summary>
        /// </summary>
        public const int MaxImageBytesSize = 64000;

        /// <summary>
        /// </summary>
        public const int MaxLongIdLength = 64;

        /// <summary>
        /// </summary>
        public const int MaxMessageLength = 512;

        /// <summary>
        /// </summary>
        public const int MaxMetadataKeyLength = 64;

        /// <summary>
        /// </summary>
        public const int MaxMetadataPairs = 25;

        /// <summary>
        /// </summary>
        public const int MaxMetadataValueLength = 128;

        /// <summary>
        /// </summary>
        public const int MaxNameLength = 64;

        /// <summary>
        /// </summary>
        public const int MaxPagePerProject = 25;

        /// <summary>
        /// </summary>
        public const int MaxParagraphSourceTextLength = 3072;

        /// <summary>
        /// Defines the maximum tag length.
        /// </summary>
        public const int MaxTagLength = 16;

        /// <summary>
        /// Defines the maximum tags.
        /// </summary>
        public const int MaxTags = 6;

        /// <summary>
        /// </summary>
        public const int MaxTranslationUnitPerPage = 1500;

        /// <summary>
        /// </summary>
        public const int MaxTranslationUnitPropertyNameLength = 128;

        /// <summary>
        /// </summary>
        public const int MaxTranslationUnitPropertyValueLength = 256;

        /// <summary>
        /// </summary>
        public const int MaxTranslationUnitSourceTextLenght = 256;

        /// <summary>
        /// </summary>
        public const int MinDescriptionLength = 2;

        /// <summary>
        /// </summary>
        public const int MinFileNameLength = 2;

        /// <summary>
        /// </summary>
        public const int MinIdLength = 1;

        /// <summary>
        /// </summary>
        public const int MinMessageLength = 8;

        /// <summary>
        /// </summary>
        public const int MinNameLength = 2;

        /// <summary>
        /// </summary>
        public const int MinParagraphSourceTextLength = 8;

        /// <summary>
        /// Defines the minimum tag length.
        /// </summary>
        public const int MinTagLength = 2;

        /// <summary>
        /// </summary>
        public const int MinTranslationUnitSourceTextLenght = 1;
    }
}