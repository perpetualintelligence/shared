/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using PerpetualIntelligence.Protocols.Abstractions.Concurrency;
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
