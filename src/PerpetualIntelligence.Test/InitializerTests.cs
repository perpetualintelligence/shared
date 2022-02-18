/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Test
{
    /// <summary>
    /// Represents a <see cref="ContextTests"/> that provides the initialization and cleanup methods.
    /// </summary>
    public abstract class InitializerTests : ContextTests
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="logger"></param>
        public InitializerTests(ILogger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>

        public InitializerTests()
        {
        }

        /// <summary>
        /// The logger.
        /// </summary>
        public ILogger? Logger { get; }

        /// <summary>
        /// The test cleanup method that logs and calls <see cref="OnTestCleanup"/>.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            OnTestCleanup();
            Logger?.LogInformation("-------- End Test={0} --------", $"{TestContext.FullyQualifiedTestClassName}.{TestContext.TestName}");
        }

        /// <summary>
        /// The test initialize method that logs and calls <see cref="OnTestInitialize"/>.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            Logger?.LogInformation("-------- Start Test={0} --------", $"{TestContext.FullyQualifiedTestClassName}.{TestContext.TestName}");
            OnTestInitialize();
        }

        /// <summary>
        /// On test cleanup callback.
        /// </summary>
        protected virtual void OnTestCleanup()
        {
        }

        /// <summary>
        /// On test initialize callback.
        /// </summary>
        protected virtual void OnTestInitialize()
        {
        }
    }
}
