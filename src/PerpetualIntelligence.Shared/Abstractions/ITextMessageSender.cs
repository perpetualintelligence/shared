/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to send a text message.
    /// </summary>
    public interface ITextMessageSender
    {
        /// <summary>
        /// Sends a text message asynchronously
        /// </summary>
        /// <param name="message">The text message.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <returns><see cref="Task"/> instance that represents a send operation.</returns>
        Task SendAsync(string message, string phoneNumber);
    }
}
