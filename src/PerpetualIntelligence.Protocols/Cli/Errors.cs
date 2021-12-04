/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Cli
{
    /// <summary>
    /// The errors for the <c>cli</c> protocol.
    /// </summary>
    public static class Errors
    {
        /// <summary>
        /// The arguments are invalid.
        /// </summary>
        public const string InvalidArgument = "invalid_argument";

        /// <summary>
        /// The command is invalid.
        /// </summary>
        public const string InvalidCommand = "invalid_command";

        /// <summary>
        /// The request is invalid.
        /// </summary>
        public const string InvalidRequest = "invalid_request";

        /// <summary>
        /// The server error.
        /// </summary>
        public const string ServerError = "server_error";

        /// <summary>
        /// The argument is not supported.
        /// </summary>
        public const string UnsupportedArgument = "unsupported_argument";
    }
}
