/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class LoggingOptionsTests
    {
        [TestMethod]
        public void DefaultValuesShouldBeCorrect()
        {
            LoggingOptions options = new ();
            Assert.IsTrue(options.ObsureErrorArguments);
            Assert.AreEqual("****", options.ObscureErrorArgumentString);
        }
    }
}
