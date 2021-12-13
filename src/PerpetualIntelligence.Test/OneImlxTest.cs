/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Test
{
    /// <summary>
    /// Represents a test class that provides the test context.
    /// </summary>
    public abstract class OneImlxTest
    {
        /// <summary>
        /// The test context. This property is set automatically by the test engine.
        /// </summary>
        public TestContext TestContext { get; set; } = null!;
    }
}
