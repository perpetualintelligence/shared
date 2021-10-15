/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;

namespace PerpetualIntelligence.Protocols.Imlx
{
    /// <summary>
    /// The runtime options that are typically defined in the <c>appsettings.json</c>.
    /// </summary>
    /// <remarks>
    /// NOTE: This class is part of the Perpetual Intelligence infrastructure. Please do not use it directly in your
    /// application code.
    /// </remarks>
    [InternalInfrastructure]
    public sealed class RuntimeOptions
    {
        /// <summary>
        /// The Api server localhost endpoint.
        /// </summary>
        public const string ApiServerLocalhostEndpoint = "PerpetualIntelligence:Runtime:Endpoints:ApiServerLocalhostEndpoint";

        /// <summary>
        /// The Api server production endpoint.
        /// </summary>
        public const string ApiServerProductionEndpoint = "PerpetualIntelligence:Runtime:Endpoints:ApiServerProductionEndpoint";

        /// <summary>
        /// The option to check the entity properties.
        /// </summary>
        public const string CheckEntityProperties = "PerpetualIntelligence:Runtime:Data:CheckEntityProperties";

        /// <summary>
        /// The option to check whether the store exits and if it does not create it automatically. Note check for the
        /// store is a performance hit. Enable this option manually to ensure all stores exist and disable it in the
        /// production modes.
        /// </summary>
        public const string CheckStore = "PerpetualIntelligence:Runtime:Data:CheckStore";

        /// <summary>
        /// The client app localhost endpoint.
        /// </summary>
        public const string ClientAppLocalhostEndpoint = "PerpetualIntelligence:Runtime:Endpoints:ClientAppLocalhostEndpoint";

        /// <summary>
        /// The client app production endpoint.
        /// </summary>
        public const string ClientAppProductionEndpoint = "PerpetualIntelligence:Runtime:Endpoints:ClientAppProductionEndpoint";

        /// <summary>
        /// The default Uri path version.
        /// </summary>
        public const string DefaultUrlPathVersion = "PerpetualIntelligence:Runtime:Versioning:DefaultUrlPathVersion";

        /// <summary>
        /// The endpoint host.
        /// </summary>
        public const string EndpointsHost = "PerpetualIntelligence:Runtime:Endpoints:Host";

        /// <summary>
        /// The payment mode.
        /// </summary>
        public const string PaymentMode = "PerpetualIntelligence:Runtime:Payments:Mode";

        /// <summary>
        /// The configuration to enable the use of test data.
        /// </summary>
        public const string UseTestData = "PerpetualIntelligence:Runtime:Data:UseTestData";
    }
}
