/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class OrgConstantsTest
    {
        [TestMethod]
        public void ConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(OrgConstants), 10);

            Assert.AreEqual("https://github.com/perpetualintelligence/terms/blob/main/CODE_OF_CONDUCT.md", OrgConstants.CodeOfConduct);
            Assert.AreEqual("Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved", OrgConstants.Copyright);
            Assert.AreEqual("donotreply@perpetualintelligence.com", OrgConstants.DoNotReplyEmail);
            Assert.AreEqual("Perpetual Intelligence L.L.C.", OrgConstants.FullName);
            Assert.AreEqual("https://github.com/perpetualintelligence", OrgConstants.GitHub);
            Assert.AreEqual("https://github.com/perpetualintelligence/terms/blob/main/issues-policy.md", OrgConstants.IssuesPolicy);
            Assert.AreEqual("https://github.com/perpetualintelligence/terms/blob/main/logo/icon.png", OrgConstants.LogoUrl);
            Assert.AreEqual("https://perpetualintelligence.com/legal/privacy", OrgConstants.PrivacyUrl);
            Assert.AreEqual("Perpetual Intelligence", OrgConstants.ShortName);
            Assert.AreEqual("https://perpetualintelligence.com/legal/terms", OrgConstants.TermsUrl);
        }
    }
}
