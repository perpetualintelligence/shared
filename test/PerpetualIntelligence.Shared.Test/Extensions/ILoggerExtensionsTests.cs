/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
            OneImlxLoggingOptions loggingOptions = new();

            string? message = Logger.FormatAndLog(Microsoft.Extensions.Logging.LogLevel.Warning, loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }

        [TestMethod]
        public void FormatAndLogShouldEnableArguments()
        {
            OneImlxLoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = true
            };

            string? message = Logger.FormatAndLog(Microsoft.Extensions.Logging.LogLevel.Error, loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=test_client_id scope=test_scope test=test_value", message);
        }

        [TestMethod]
        public void FormatAndLogShouldNotEnableArguments()
        {
            OneImlxLoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = false
            };

            string? message = Logger.FormatAndLog(Microsoft.Extensions.Logging.LogLevel.Debug, loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }

        [TestMethod]
        public void FormatDefaultShouldNotEnableArguments()
        {
            OneImlxLoggingOptions loggingOptions = new();
            string message = Logger.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }

        [TestMethod]
        public void FormatShouldEnableArguments()
        {
            OneImlxLoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = true
            };
            string message = Logger.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=test_client_id scope=test_scope test=test_value", message);
        }

        [TestMethod]
        public void FormatShouldNotEnableArguments()
        {
            OneImlxLoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = false
            };

            string message = Logger.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }
    }
}
