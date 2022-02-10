/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to send standard communication via email or text message.
    /// </summary>
    public interface ICommunicationSender
    {
        /// <summary>
        /// The email sender.
        /// </summary>
        /// <value>An instance of <see cref="IEmailSender"/>.</value>
        IEmailSender EmailSender { get; }

        /// <summary>
        /// The text message sender.
        /// </summary>
        /// <value>An instance of <see cref="ITextMessageSender"/>.</value>
        ITextMessageSender TextMessageSender { get; }
    }
}
