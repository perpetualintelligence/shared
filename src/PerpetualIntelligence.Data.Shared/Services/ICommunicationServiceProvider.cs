/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Abstractions;

namespace PerpetualIntelligence.Data.Shared.Services
{
    /// <summary>
    /// Represents an abstraction to provide communication services.
    /// </summary>
    public interface ICommunicationServiceProvider
    {
        /// <summary>
        /// Default email service.
        /// </summary>
        IEmailSender DefaultEmailService { get; }

        /// <summary>
        /// Default text message service.
        /// </summary>
        ITextMessageSender DefaultTextMessageService { get; }
    }
}
