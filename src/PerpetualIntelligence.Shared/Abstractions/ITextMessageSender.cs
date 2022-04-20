/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
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
