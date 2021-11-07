/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to describe the standard communication.
    /// </summary>
    public interface ICommunicationDescriptor
    {
        /// <summary>
        /// The email sender.
        /// </summary>
        IEmailSender EmailSender { get; }

        /// <summary>
        /// The text message sender.
        /// </summary>
        ITextMessageSender TextMessageSender { get; }
    }
}