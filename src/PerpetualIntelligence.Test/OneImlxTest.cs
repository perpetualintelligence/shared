/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
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
