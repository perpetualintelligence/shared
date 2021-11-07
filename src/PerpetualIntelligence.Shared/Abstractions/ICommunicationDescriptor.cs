/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// Represents an abstraction to provide communication services.
    /// </summary>
    public interface ICommunicationDescriptor
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
