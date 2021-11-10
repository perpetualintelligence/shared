/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// The Perpetual Intelligence command line arguments. Argument names must start with 'oneimlxarg' and contain characters
    /// a-z, A-Z, and letters 0-9. No special characters are allowed.
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
