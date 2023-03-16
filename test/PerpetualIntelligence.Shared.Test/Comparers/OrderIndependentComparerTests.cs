/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Comparers;
using PerpetualIntelligence.Test;
using PerpetualIntelligence.Test.Services;
using System.Collections.Generic;

namespace PerpetualIntelligence.Shared.Defaults.Oidc
{
    [TestClass]
    public class OrderIndependentComparerTests : InitializerTests
    {
        public OrderIndependentComparerTests() : base(TestLogger.Create<OrderIndependentComparerTests>())
        {
        }

        [TestId("OxikBcRxgky7hcYFOmxcCA")]
        public void BothNullShouldEqual()
        {
            string? x = null;
            string? y = null;
            OrderIndependentComparer comparer = new();
            Assert.IsTrue(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("KLRJQfLD8UWEjELq1glgkA")]
        public void CodeCodeSameValuesShouldEqual()
        {
            string x = "code";
            string y = "code";
            OrderIndependentComparer comparer = new();
            Assert.IsTrue(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("NywwAtPtA0uihYMPQ4rnQ")]
        public void CodeIdTokenEitherWayShouldEqual()
        {
            string x = "code id_token";
            string y = "id_token code";
            OrderIndependentComparer comparer = new();
            Assert.IsTrue(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("qG7M6sjMl0SV23vlyMbTQQ")]
        public void CodeIdTokenTokenEitherWayShouldEqual()
        {
            string x = "code id_token token";
            string y = "token id_token code";
            OrderIndependentComparer comparer = new();
            Assert.IsTrue(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("YFgGm4pEadKTIEBINFUg")]
        public void CodeIdTokenTokenMixedWayShouldEqual()
        {
            string x = "code id_token token";
            string y = "id_token code token";
            OrderIndependentComparer comparer = new();
            Assert.IsTrue(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("YKdM0wlSoUCR7bcWdC3aQ")]
        public void CodeIdTokenTokenNoCodeShouldNotEqual()
        {
            string x = "code id_token token";
            string y = "id_token token";
            OrderIndependentComparer comparer = new();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("PyKZOZ2Z1keCWfxDUPjQvQ")]
        public void CodeIdTokenTokenNoCodeTokenShouldNotEqual()
        {
            string x = "code id_token token";
            string y = "id_token";
            OrderIndependentComparer comparer = new();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("tQlSz0HCI0OO4gYOjhq8Bg")]
        public void CodeIdTokenTokenSameLengthDifferentWordsShouldNotEqual()
        {
            string x = "code id_token token";
            string y = "code longwordtoken7";
            OrderIndependentComparer comparer = new();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("OJwm5xDc4UOqsEclYC2oA")]
        public void CodeTokenBothWaysShouldEqual()
        {
            string x = "code token";
            string y = "token code";
            OrderIndependentComparer comparer = new();
            Assert.IsTrue(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("2n4MAx5upkuyaVykb96fxQ")]
        public void DifferentWordsSameLengthTokenCodeShouldNotEqual()
        {
            string x = "seven four";
            string y = "token code";
            OrderIndependentComparer comparer = new();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("3gRzF68MU2rLXHXTryiFQ")]
        public void FirstNullOtherEmptyShouldNotEqual()
        {
            string? x = null;
            string y = string.Empty;
            OrderIndependentComparer comparer = new();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("A946911E-4D6A-47D9-9403-A47072001DD0")]
        public void GetHashValueShouldReturnCorrectly()
        {
            OrderIndependentComparer comparer = new();
            Assert.AreEqual(0, comparer.GetHashCode(null));

            Assert.AreEqual("test_value".GetHashCode(), comparer.GetHashCode("test_value"));

            int hcode1 = comparer.GetHashCode("token code id_token");
            int hcode2 = comparer.GetHashCode("token code id_token");

            Assert.AreNotEqual(hcode1, hcode2);
        }

        [TestMethod]
        [TestId("vaIR5p58oEiR6C6ok9RWyg")]
        public void IdTokenCodeIdTokenCodeSameValuesShouldEqual()
        {
            string x = "id_token code";
            string y = "id_token code";
            OrderIndependentComparer comparer = new();
            Assert.IsTrue(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("eptB5qoxiUmQsm95ButfA")]
        public void IdTokenCodeTokenCodeDifferentValueShouldNotEqual()
        {
            string x = "id_token code";
            string y = "token code";
            OrderIndependentComparer comparer = new();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("m3MStwK8oUO3zMp1Zx57w")]
        public void IdTokenTokenBothWaysShouldEqual()
        {
            string x = "id_token token";
            string y = "token id_token";
            OrderIndependentComparer comparer = new();
            Assert.IsTrue(comparer.Equals(x, y));
        }

        [TestMethod]
        [TestId("0F734824-0B65-46A6-BEBE-B4CF233FC56F")]
        public void ListWithResponseTypesShouldReturnCorrectly()
        {
            List<string> responseTypes = new()
            {
                "code",
                "code",
                "id_token",
                "token",
                "code"
            };
            Assert.AreEqual(5, responseTypes.Count);

            CollectionAssert.Contains(responseTypes, "code");
            CollectionAssert.Contains(responseTypes, "id_token");
            CollectionAssert.Contains(responseTypes, "token");
            CollectionAssert.DoesNotContain(responseTypes, "test_custom");
        }

        [TestMethod]
        [TestId("2Du3vXjyMEuARcfXXuzQ7Q")]
        public void SecondNullOtherEmptyShouldNotEqual()
        {
            string x = string.Empty;
            string? y = null;
            OrderIndependentComparer comparer = new();
            Assert.IsFalse(comparer.Equals(x, y));
        }
    }
}
