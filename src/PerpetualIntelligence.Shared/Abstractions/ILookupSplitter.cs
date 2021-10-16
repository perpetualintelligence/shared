﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Infrastructure;
using System.Collections.Generic;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to split and join the subject's <see cref="Identity"/> or subject's information.
    /// </summary>
    public interface ILookupSplitter
    {
        /// <summary>
        /// Joins the specified <see cref="Identity"/> and returns a string representation.
        /// </summary>
        /// <param name="identity">The identity to join.</param>
        /// <returns>Joined string representation.</returns>
        string JoinIdentity(Identity identity);

        /// <summary>
        /// Joins the specified <see cref="ModeIdentity"/> and returns a string representation.
        /// </summary>
        /// <param name="identity">The mode identity to join.</param>
        /// <returns>Joined string representation.</returns>
        string JoinModeIdentity(ModeIdentity identity);

        /// <summary>
        /// Joins the specified collection and returns a string representation.
        /// </summary>
        /// <param name="values">The string collection to join.</param>
        /// <returns>Joined string representation.</returns>
        string JoinString(IEnumerable<string> values);

        /// <summary>
        /// Split the string representation and returns <see cref="Identity"/>.
        /// </summary>
        /// <param name="value">The joined string representation.</param>
        /// <param name="splitId">
        /// Determines whether to split the compound identifier and store the <c>id</c> portion in
        /// <see cref="Identity.Id"/> or keep the joined string representation as an <c>id</c> portion.
        /// </param>
        /// <returns><see cref="Identity"/>.</returns>
        Identity SplitIdentity(string value, bool splitId);

        /// <summary>
        /// Splits the string representation and returns <see cref="ModeIdentity"/>.
        /// </summary>
        /// <param name="value">The joined string representation.</param>
        /// <returns><see cref="ModeIdentity"/>.</returns>
        ModeIdentity SplitModeIdentity(string value);

        /// <summary>
        /// Splits the string representation and returns a string collection.
        /// </summary>
        /// <param name="value">Merged string representation.</param>
        /// <returns>The string collection.</returns>
        IEnumerable<string> SplitString(string value);
    }
}