/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Infrastructure;

namespace PerpetualIntelligence.Shared.Services
{
    [TestClass]
    public class FormatterTests
    {
        [TestMethod]
        public void FormatDefaultShouldNotEnableArguments()
        {
            LoggingOptions loggingOptions = new();
            string message = Formatter.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }

        [TestMethod]
        public void FormatShouldEnableArguments()
        {
            LoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = true
            };
            string message = Formatter.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=test_client_id scope=test_scope test=test_value", message);
        }

        [TestMethod]
        public void FormatShouldNotEnableArguments()
        {
            LoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = false
            };

            string message = Formatter.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }
    }
}
