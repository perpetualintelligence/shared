/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using PerpetualIntelligence.Protocols.Abstractions.Concurrency;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Concurrency
{
    /// <summary>
    /// The default <see cref="IThreadLock{T}"/> using <see cref="SemaphoreSlim"/>.
    /// </summary>
    /// <typeparam name="T">The type requesting the thread lock.</typeparam>
    public class SemaphoreSlimThreadLock<T> : IThreadLock<T>
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