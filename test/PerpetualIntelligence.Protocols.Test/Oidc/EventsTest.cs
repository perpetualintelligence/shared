// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
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
    public class EventsTest
    {
        [TestMethod]
        public void EventsConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Events), 1);

            Assert.AreEqual("http://schemas.openid.net/event/backchannel-logout", Events.BackChannelLogout);
        }
    }
}
