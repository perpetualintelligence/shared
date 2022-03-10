/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to return the tables's name.
    /// </summary>
    public interface ITableNameAccessor
    {
        /// <summary>
        /// Returns the tables's name.
        /// </summary>
        /// <returns>The name.</returns>
        string GetTableName();
    }
}
