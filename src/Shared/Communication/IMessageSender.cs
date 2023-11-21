/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Communication
{
    /// <summary>
    /// An abstraction of an message sender.
    /// </summary>
    public interface IMessageSender
    {
        /// <summary>
        /// Sends an email asynchronously
        /// </summary>
        /// <param name="emailModel">The email model.</param>
        /// <returns></returns>
        Task SendEmailAsync(EmailModel emailModel);

        /// <summary>
        /// Sends an text message asynchronously
        /// </summary>
        /// <param name="smModel">The text message model.</param>
        /// <returns></returns>
        Task SendSmsAsync(SmsModel smModel);
    }
}