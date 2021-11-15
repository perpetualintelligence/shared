using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class LoginHintTypeTest
    {
        [TestMethod]
        public void LoginHintTypeEnumTest()
        {
            Assert.AreEqual(1, ((int)LoginHintType.Email));
            Assert.AreEqual(2, ((int)LoginHintType.Phone));          
            Assert.AreEqual(4, ((int)LoginHintType.Username));
            Assert.AreEqual(8, ((int)LoginHintType.UserId));
        }
    }
}
