/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
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
            OneImlxLoggingOptions options = new OneImlxLoggingOptions();
            Assert.IsNull(options.RevealErrorArguments);
            Assert.AreEqual("****", options.ObscureErrorArgumentString);
        }
    }
}
