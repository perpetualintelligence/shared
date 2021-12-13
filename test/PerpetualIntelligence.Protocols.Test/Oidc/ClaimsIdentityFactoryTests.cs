// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Linq;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
   public class ClaimsIdentityFactoryTests
    {
        [TestMethod]
        public void ClaimsIdentityFactoryAttributeTest()
        {
            Type type = typeof(ClaimsIdentityFactory);
            Assert.AreEqual(3, type.CustomAttributes.Count());

            TestHelper.AssertToDocumentationAttribute(type, "Claims from certificate.", false);
        }

        [TestMethod]
        public void FromAnonymityTest()
        {
            Assert.AreEqual("System.Security.Claims.ClaimsIdentity", ClaimsIdentityFactory.FromAnonymity().ToString());
        }

        [TestMethod]
        public void FromCertificateTest()
        {
        }

        [TestMethod]
        public void FromClaimsTest()
        {
        }
    }
}
