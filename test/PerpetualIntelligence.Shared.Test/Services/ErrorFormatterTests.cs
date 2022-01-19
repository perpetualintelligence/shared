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
    public class ErrorFormatterTests
    {
        [TestMethod]
        public void FormatDefaultShouldNotEnableArguments()
        {
            OneImlxLoggingOptions loggingOptions = new();
            string message = ErrorFormatter.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }

        [TestMethod]
        public void FormatShouldEnableArguments()
        {
            OneImlxLoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = true
            };
            string message = ErrorFormatter.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=test_client_id scope=test_scope test=test_value", message);
        }

        [TestMethod]
        public void FormatShouldNotEnableArguments()
        {
            OneImlxLoggingOptions loggingOptions = new()
            {
                RevealErrorArguments = false
            };

            string message = ErrorFormatter.Format(loggingOptions, "Test message. client_id={0} scope={1} test={2}", "test_client_id", "test_scope", "test_value");
            Assert.AreEqual("Test message. client_id=**** scope=**** test=****", message);
        }
    }
}
