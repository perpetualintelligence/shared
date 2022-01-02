/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
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
            UrlListAttribute urlListAttribute = new();

            // null is valid
            Assert.IsTrue(urlListAttribute.IsValid(null));
            Assert.IsTrue(urlListAttribute.IsValid(new string[] { "http://testurl", "https://testurl2", "ftp://testurl3" }));

            Assert.IsFalse(urlListAttribute.IsValid(new string?[] { null, "https://testurl2", "ftp://testurl3" }));
            Assert.IsFalse(urlListAttribute.IsValid(new string[] { "invalid_url", "https://testurl2", "ftp://testurl3" }));
        }
    }
}
