/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The delegate that returns a result for the specified context.
    /// </summary>
    public delegate Task<TResult> ResultDelegate<TContext, TResult>(TContext context) where TContext : class where TResult : Result;
}
