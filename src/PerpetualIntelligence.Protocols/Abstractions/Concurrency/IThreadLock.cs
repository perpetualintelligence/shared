/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions.Concurrency
{
    /// <summary>
    /// An abstraction to lock or release the concurrent thread execution.
    /// </summary>
    /// <typeparam name="T">The type requesting thread lock.</typeparam>
    public interface IThreadLock<T>
    {
        /// <summary>
        /// Asynchronously lock the current thread for the specified time interval.
        /// </summary>
        /// <param name="timeout">The timeout in millisecond.</param>
        /// <returns><c>true</c> if the lock is acquired, <c>false</c> otherwise.</returns>
        Task<bool> LockAsync(int timeout);

        /// <summary>
        /// Asynchronously release the locked thread.
        /// </summary>
        /// <returns><see cref="Task"/> instance.</returns>
        Task ReleaseAsync();
    }
}
