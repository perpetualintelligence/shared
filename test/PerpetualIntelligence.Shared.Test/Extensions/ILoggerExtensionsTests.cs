/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Infrastructure;
using PerpetualIntelligence.Test;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Shared.Extensions
{
    [TestClass]
    public class ILoggerExtensionsTests : OneImlxLogTest
    {
        public ILoggerExtensionsTests() : base(TestLogger.Create<ILoggerExtensionsTests>())
        {
        }

        [TestMethod]
        public void FormatAndLogDefaultShouldNotEnableArguments()
        {
            LoggingOptions loggingOptions = new();

            string? message = Logger.FormatAndLog(Microsoft.Extensions.Logging.LogLevel.Warning, loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }

        [TestMethod]
        public void FormatAndLogShouldEnableArguments()
        {
            LoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = true
            };

            string? message = Logger.FormatAndLog(Microsoft.Extensions.Logging.LogLevel.Error, loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=test_client_id scope=test_scope test=test_value", message);
        }

        [TestMethod]
        public void FormatAndLogShouldNotEnableArguments()
        {
            LoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = false
            };

            string? message = Logger.FormatAndLog(Microsoft.Extensions.Logging.LogLevel.Debug, loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }
    }
}
