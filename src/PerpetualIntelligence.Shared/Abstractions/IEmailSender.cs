/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to send an email.
    /// </summary>
    public interface IEmailSender
    {
        /// <summary>
        /// Sends an email asynchronously.
        /// </summary>
        /// <param name="from">The sender.</param>
        /// <param name="to">The recipients.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="message">The message.</param>
        /// <param name="bcc">The bcc recipients.</param>
        /// <returns><see cref="Task"/> instance that represents an asynchronous send operation.</returns>
        Task SendAsync(string from, string[] to, string subject, string message, string[]? bcc);

        /// <summary>
        /// Sends an email from a configured sender asynchronously.
        /// </summary>
        /// <param name="to">The recipients.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="message">The message.</param>
        /// <param name="bcc">The bcc recipients.</param>
        /// <returns><see cref="Task"/> instance that represents an asynchronous send operation.</returns>
        Task SendAsync(string[] to, string subject, string message, string[]? bcc);
    }
}
