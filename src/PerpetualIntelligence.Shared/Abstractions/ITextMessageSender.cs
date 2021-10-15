/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
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
