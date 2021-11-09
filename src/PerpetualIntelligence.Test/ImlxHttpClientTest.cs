/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;

namespace PerpetualIntelligence.Test
{
    /// <summary>
    /// Represents a test class that provides the HTTP client and logs the test.
    /// </summary>
    public abstract class ImlxHttpClientTest : OneImlxTest
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="logger"></param>
        public ImlxHttpClientTest(ILogger logger)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
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

            if (HttpClient != null)
            {
                HttpClient.Dispose();
            }

            Logger.LogInformation("-------- End Http Test={0} --------", $"{TestContext.FullyQualifiedTestClassName}.{TestContext.TestName}");
        }

        /// <summary>
        /// The test initialize method that logs and calls <see cref="OnTestInitialize"/>.
        /// </summary>
        [TestInitialize]
        public void ImlxLogTestInitialize()
        {
            Logger.LogInformation("-------- Start Http Test={0} --------", $"{TestContext.FullyQualifiedTestClassName}.{TestContext.TestName}");

            HttpClient = GetTestServer().CreateClient();

            OnTestInitialize();
        }

        /// <summary>
        /// The HTTP client..
        /// </summary>
        protected HttpClient HttpClient { get; set; } = null!; // Set in TestInitialize

        /// <summary>
        /// Gets the test server.
        /// </summary>
        /// <returns></returns>
        protected abstract TestServer GetTestServer();

        /// <summary>
        /// On test cleanup callback.
        /// </summary>
        protected virtual void OnTestCleanup()
        { }

        /// <summary>
        /// On test initialize callback.
        /// </summary>
        protected virtual void OnTestInitialize()
        { }
    }
}
