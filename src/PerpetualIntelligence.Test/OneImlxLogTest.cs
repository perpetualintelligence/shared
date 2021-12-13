/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Test
{
    /// <summary>
    /// Represents a test class that provides the test context and logger.
    /// </summary>
    public abstract class OneImlxLogTest : OneImlxTest
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="logger"></param>
        public OneImlxLogTest(ILogger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// The logger.
        /// </summary>
        public ILogger Logger { get; }

        /// <summary>
        /// The test cleanup method that logs and calls <see cref="OnTestCleanup"/>.
        /// </summary>
        [TestCleanup]
        public void ImlxLogTestCleanup()
        {
            OnTestCleanup();
            Logger.LogInformation("-------- End Test={0} --------", $"{TestContext.FullyQualifiedTestClassName}.{TestContext.TestName}");
        }

        /// <summary>
        /// The test initialize method that logs and calls <see cref="OnTestInitialize"/>.
        /// </summary>
        [TestInitialize]
        public void ImlxLogTestInitialize()
        {
            Logger.LogInformation("-------- Start Test={0} --------", $"{TestContext.FullyQualifiedTestClassName}.{TestContext.TestName}");
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
