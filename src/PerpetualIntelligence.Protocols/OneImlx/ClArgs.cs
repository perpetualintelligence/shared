/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// The Perpetual Intelligence command line arguments. Argument names must start with 'oneimlxarg' and contain
    /// characters a-z, A-Z, and letters 0-9. No special characters are allowed.
    /// </summary>
    /// <remarks>
    /// NOTE: This class is part of the Perpetual Intelligence infrastructure. Please do not use it directly in your
    /// application code.
    /// </remarks>
    [InternalInfrastructure]
    public static class ClArgs
    {
        /// <summary>
        /// Command line argument to use controller as a service.
        /// </summary>
        public const string ControllerAsService = "oneimlxargcontrollerasservice";

        /// <summary>
        /// Command line argument to enable logger.
        /// </summary>
        public const string EnableLogger = "oneimlxargenablelogger";
    }
}
