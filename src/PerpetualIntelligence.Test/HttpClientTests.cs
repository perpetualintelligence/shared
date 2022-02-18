/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;

namespace PerpetualIntelligence.Test
{
    /// <summary>
    /// Represents a <see cref="ContextTests"/> that provides the <see cref="HttpClient"/>.
    /// </summary>
    public abstract class HttpClientTests : ContextTests
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="logger"></param>
        public HttpClientTests(ILogger logger)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// The logger.
        /// </summary>
        public ILogger? Logger { get; }

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

            Logger?.LogInformation("-------- End HTTP Test={0} --------", $"{TestContext.FullyQualifiedTestClassName}.{TestContext.TestName}");
        }

        /// <summary>
        /// The test initialize method that logs and calls <see cref="OnTestInitialize"/>.
        /// </summary>
        [TestInitialize]
        public void ImlxLogTestInitialize()
        {
            Logger?.LogInformation("-------- Start HTTP Test={0} --------", $"{TestContext.FullyQualifiedTestClassName}.{TestContext.TestName}");

            // Make sure we init first
            OnTestInitialize();

            HttpClient = GetTestServer().CreateClient();
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        protected HttpClientTests()
        {
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
