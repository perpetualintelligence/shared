﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Exceptions;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class ModesTests
    {
        [TestMethod]
        public void All()
        {
            string[] all = Modes.All();
            Assert.AreEqual(4, all.Length);

            Assert.AreEqual(Modes.Neutral, all[0]);
            Assert.AreEqual(Modes.Test, all[1]);
            Assert.AreEqual(Modes.Stage, all[2]);
            Assert.AreEqual(Modes.Live, all[3]);
        }

        [TestMethod]
        public void IsTestOrLiveTest()
        {
            Assert.IsTrue(Modes.IsTestOrLive(Modes.Live));
            Assert.IsTrue(Modes.IsTestOrLive(Modes.Test));

            Assert.IsFalse(Modes.IsTestOrLive(""));
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Assert.IsFalse(Modes.IsTestOrLive(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            Assert.IsFalse(Modes.IsTestOrLive("any"));

            Assert.IsFalse(Modes.IsTestOrLive(Modes.Neutral));
            Assert.IsFalse(Modes.IsTestOrLive(Modes.Stage));
        }

        [TestMethod]
        public void IsValidTest()
        {
            Assert.IsTrue(Modes.IsValid(Modes.Live));
            Assert.IsTrue(Modes.IsValid(Modes.Test));
            Assert.IsTrue(Modes.IsValid(Modes.Neutral));
            Assert.IsTrue(Modes.IsValid(Modes.Stage));

            Assert.IsFalse(Modes.IsValid(""));
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Assert.IsFalse(Modes.IsValid(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            Assert.IsFalse(Modes.IsValid("any"));
        }

        [TestMethod]
        public void ModesTest()
        {
            Assert.AreEqual("urn:oneimlx:mode:live", Modes.Live);
            Assert.AreEqual("urn:oneimlx:mode:test", Modes.Test);
            Assert.AreEqual("urn:oneimlx:mode:neutral", Modes.Neutral);
            Assert.AreEqual("urn:oneimlx:mode:stage", Modes.Stage);
        }

        [TestMethod]
        public void ThrowIdInvalid()
        {
            Assert.ThrowsException<ErrorException>(() => Modes.ThrowIfInvalid("random"));
        }
    }
}
