/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Protocols.Concurrency;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Defaults.Concurrency
{
    /// <summary>
    /// The default <see cref="IThreadLock{T}"/> using <see cref="SemaphoreSlim"/>.
    /// </summary>
    /// <typeparam name="T">The type requesting the thread lock.</typeparam>
    public class DefaultSemaphoreSlimThreadLock<T> : IThreadLock<T>
    {
        /// <inheritdoc/>
        public Task<bool> LockAsync(int timeout)
        {
            if (timeout <= 0)
            {
                throw new ArgumentException("Timeout must be greater than zero.");
            }

            return _lock.WaitAsync(timeout);
        }

        /// <inheritdoc/>
        public Task ReleaseAsync()
        {
            _lock.Release();
            return Task.CompletedTask;
        }

        private static readonly SemaphoreSlim _lock = new(1);
    }
}
