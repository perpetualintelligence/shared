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
   public class UserCodesTest
    {
        [TestMethod]
        public void UserCodeTypesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(UserCodes), 2);

            Assert.AreEqual("urn:pi:protocols:oidc:ucode:anum", UserCodes.AlphaNumeric); 
            Assert.AreEqual("urn:pi:protocols:oidc:ucode:num", UserCodes.Numeric);
        }
    }
}
