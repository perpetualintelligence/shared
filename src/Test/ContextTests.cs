/*
    Copyright (c) 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Test
{
    /// <summary>
    /// Represents a test class that provides <see cref="TestContext"/>.
    /// </summary>
    public abstract class ContextTests
    {
        /// <summary>
        /// The test context. This property is set automatically by the test engine.
        /// </summary>
        public TestContext TestContext { get; set; } = null!;
    }
}
