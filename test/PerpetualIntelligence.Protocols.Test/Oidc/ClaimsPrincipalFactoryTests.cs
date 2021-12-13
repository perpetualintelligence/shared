// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
   public class ClaimsPrincipalFactoryTests
    {
        [TestMethod]
        public void ClaimsPrincipalFactoryAttributeTest()
        {
            Type type = typeof(ClaimsPrincipalFactory);
            Assert.AreEqual(3, type.CustomAttributes.Count());

            TestHelper.AssertToDocumentationAttribute(type, "Claims from certificate.", false);
        }

        [TestMethod]
        public void CreateFromCertificateTest()
        {
           // Assert.AreEqual("System.Security.Claims.ClaimsIdentity", ClaimsPrincipalFactory.CreateFromCertificate().ToString());
        }


        [TestMethod]
        public void FromAnonymityTest()
        {
            Assert.AreEqual("System.Security.Claims.ClaimsPrincipal", ClaimsPrincipalFactory.FromAnonymity().ToString());
        }

        [TestMethod]
        public void FromClaimsTest()
        {
            Assert.AreEqual("System.Security.Claims.ClaimsPrincipal", ClaimsPrincipalFactory.FromClaims("Test").ToString());
        }
    }
}
