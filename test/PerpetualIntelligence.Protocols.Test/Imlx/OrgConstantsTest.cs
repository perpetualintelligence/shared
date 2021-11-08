/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Imlx
{
    [TestClass]
    public class OrgConstantsTest
    {
        [TestMethod]
        public void ConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(OrgConstants), 10);

            Assert.AreEqual("https://en.gravatar.com/userimage/152742631/5c2800c8660bdabbfdcc1bf9497964d4.png", OrgConstants.LogoUrl);
            Assert.AreEqual("Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.", OrgConstants.Copyright);
            Assert.AreEqual("donotreply@perpetualintelligence.com", OrgConstants.DoNotReplyEmail);
            Assert.AreEqual("Perpetual Intelligence L.L.C.", OrgConstants.FullName);
            Assert.AreEqual("Perpetual Intelligence", OrgConstants.ShortName);
            Assert.AreEqual("urn:pi:protocols:imlx", OrgConstants.Imlx);
            Assert.AreEqual("PerpetualIntelligence.Imlx", OrgConstants.ImlxOrg);
            Assert.AreEqual("urn:pi:protocols:oidc", OrgConstants.Oidc);
            Assert.AreEqual("https://perpetualintelligence.com/legal/privacy", OrgConstants.PrivacyUrl);
            Assert.AreEqual("https://perpetualintelligence.com/legal/terms", OrgConstants.TermsUrl);
        }
    }
}
