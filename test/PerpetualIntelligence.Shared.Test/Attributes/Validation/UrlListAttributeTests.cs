/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    [TestClass]
    public class UrlListAttributeTests
    {
        [TestMethod]
        public void IsValidShouldReturnValidResult()
        {
            UrlListAttribute urlListAttribute = new UrlListAttribute();

            // null is valid
            Assert.IsTrue(urlListAttribute.IsValid(null));
            Assert.IsTrue(urlListAttribute.IsValid(new string[] { "http://testurl", "https://testurl2", "ftp://testurl3" }));

            Assert.IsFalse(urlListAttribute.IsValid(new string[] { null, "https://testurl2", "ftp://testurl3" }));
            Assert.IsFalse(urlListAttribute.IsValid(new string[] { "invalid_url", "https://testurl2", "ftp://testurl3" }));
        }
    }
}
