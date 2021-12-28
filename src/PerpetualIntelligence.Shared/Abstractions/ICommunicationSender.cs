/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
