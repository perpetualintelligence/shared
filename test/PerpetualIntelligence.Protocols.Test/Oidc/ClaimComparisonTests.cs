/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class ClaimComparisonTests
    {
        [TestMethod]
        public void DefaultOptionsShouldResultInFourClaims()
        {
            HashSet<Claim> hashSet = new(_claims, new ClaimComparer());
            Assert.AreEqual(8, hashSet.Count);

            // 1
            Claim item = hashSet.First();
            Assert.AreEqual("claim_type1", item.Type);
            Assert.AreEqual("value", item.Value);
            Assert.AreEqual("issuer1", item.Issuer);

            // 2
            item = hashSet.Skip(1).First();
            Assert.AreEqual("claim_type1", item.Type);
            Assert.AreEqual("Value", item.Value);
            Assert.AreEqual("issuer1", item.Issuer);

            // 3
            item = hashSet.Skip(2).First();
            Assert.AreEqual("Claim_type1", item.Type);
            Assert.AreEqual("value", item.Value);
            Assert.AreEqual("issuer1", item.Issuer);

            // 4
            item = hashSet.Skip(3).First();
            Assert.AreEqual("Claim_type1", item.Type);
            Assert.AreEqual("Value", item.Value);
            Assert.AreEqual("issuer1", item.Issuer);

            // 5
            item = hashSet.Skip(4).First();
            Assert.AreEqual("claim_type1", item.Type);
            Assert.AreEqual("value", item.Value);
            Assert.AreEqual("issuer2", item.Issuer);

            // 6
            item = hashSet.Skip(5).First();
            Assert.AreEqual("claim_type1", item.Type);
            Assert.AreEqual("Value", item.Value);
            Assert.AreEqual("issuer2", item.Issuer);

            // 7
            item = hashSet.Skip(6).First();
            Assert.AreEqual("Claim_type1", item.Type);
            Assert.AreEqual("value", item.Value);
            Assert.AreEqual("issuer2", item.Issuer);

            // 8
            item = hashSet.Skip(7).First();
            Assert.AreEqual("Claim_type1", item.Type);
            Assert.AreEqual("Value", item.Value);
            Assert.AreEqual("issuer2", item.Issuer);
        }

        private readonly List<Claim> _claims = new List<Claim>
        {
            new Claim("claim_type1", "value", System.Security.Claims.ClaimValueTypes.String, "issuer1"),  // 1
            new Claim("claim_type1", "value", System.Security.Claims.ClaimValueTypes.String, "issuer1"),  // duplicate
            new Claim("claim_type1", "Value", System.Security.Claims.ClaimValueTypes.String, "issuer1"),  // 2

            new Claim("Claim_type1", "value", System.Security.Claims.ClaimValueTypes.String, "issuer1"),  // 3
            new Claim("Claim_type1", "value", System.Security.Claims.ClaimValueTypes.String, "issuer1"),  // duplicate
            new Claim("Claim_type1", "Value", System.Security.Claims.ClaimValueTypes.String, "issuer1"),  // 4

            new Claim("claim_type1", "value", System.Security.Claims.ClaimValueTypes.String, "issuer2"),  // 5
            new Claim("claim_type1", "value", System.Security.Claims.ClaimValueTypes.String, "issuer2"),  // duplicate
            new Claim("claim_type1", "Value", System.Security.Claims.ClaimValueTypes.String, "issuer2"),  // 6

            new Claim("Claim_type1", "value", System.Security.Claims.ClaimValueTypes.String, "issuer2"),  // 7
            new Claim("Claim_type1", "value", System.Security.Claims.ClaimValueTypes.String, "issuer2"),  // duplicate
            new Claim("Claim_type1", "Value", System.Security.Claims.ClaimValueTypes.String, "issuer2")   // 8
        };
    }
}
