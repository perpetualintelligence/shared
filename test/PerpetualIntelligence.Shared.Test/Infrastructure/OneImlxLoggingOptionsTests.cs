/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class OneImlxLoggingOptionsTests
    {
        [TestMethod]
        public void DefaultValuesShoudBeCorrect()
        {
            LoggingOptions options = new LoggingOptions();
            Assert.IsNull(options.RevealErrorArguments);
            Assert.AreEqual("****", options.ObscureErrorArgumentString);
        }
    }
}
