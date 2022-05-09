/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols
{
    [TestClass]
    public class ConstantsTest
    {
        [TestMethod]
        public void ConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(Constants), 7);

            Assert.AreEqual("pi-cli", Constants.Cli);
            Assert.AreEqual("urn:oneimlx:cli", Constants.CliUrn);

            Assert.AreEqual("pi-lic", Constants.Lic);
            Assert.AreEqual("urn:oneimlx:lic", Constants.LicUrn);

            Assert.AreEqual("oneimlx", Constants.OneImlx);
            Assert.AreEqual("urn:oneimlx", Constants.OneImlxUrn);

            Assert.AreEqual("https://api.perpetualintelligence.com", Constants.Issuer);
        }
    }
}
