/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The generic result that does not support handling explicit errors, instead they rely on exception handling to
    /// propagate any errors.
    /// </summary>
    /// <seealso cref="Result"/>
    public abstract class ResultNoError
    {
    }
}
