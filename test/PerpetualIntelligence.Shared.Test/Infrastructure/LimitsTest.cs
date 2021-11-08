using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Shared.Infrastructure;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    [TestClass]
    public class LimitsTest
    {
        [TestMethod]
        public void LimitsConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(Limits), 32);

            Assert.AreEqual(5, Limits.MaxClientRedirectUris);

            Assert.AreEqual(5, Limits.MaxClientSecrets);

            Assert.AreEqual(3, Limits.MaxClientTrustedEmail);

            Assert.AreEqual(3, Limits.MaxClientTrustedOrigin);

            Assert.AreEqual(16, Limits.MaxCustomClaims);

            Assert.AreEqual(10, Limits.MaxDataPerToken);

            Assert.AreEqual(256, Limits.MaxDescriptionLength);

            Assert.AreEqual(64, Limits.MaxFileNameLength);

            Assert.AreEqual(36, Limits.MaxIdLength);

            Assert.AreEqual(64000, Limits.MaxImageBytesSize);

            Assert.AreEqual(64, Limits.MaxLongIdLength);

            Assert.AreEqual(512, Limits.MaxMessageLength);

            Assert.AreEqual(64, Limits.MaxMetadataKeyLength);

            Assert.AreEqual(25, Limits.MaxMetadataPairs);

            Assert.AreEqual(128, Limits.MaxMetadataValueLength);

            Assert.AreEqual(64, Limits.MaxNameLength);

            Assert.AreEqual(25, Limits.MaxPagePerProject);

            Assert.AreEqual(3072, Limits.MaxParagraphSourceTextLength);

            Assert.AreEqual(16, Limits.MaxTagLength);

            Assert.AreEqual(6, Limits.MaxTags);

            Assert.AreEqual(1500, Limits.MaxTranslationUnitPerPage);

            Assert.AreEqual(128, Limits.MaxTranslationUnitPropertyNameLength);

            Assert.AreEqual(256, Limits.MaxTranslationUnitPropertyValueLength);

            Assert.AreEqual(256, Limits.MaxTranslationUnitSourceTextLenght);

            Assert.AreEqual(2, Limits.MinDescriptionLength);

            Assert.AreEqual(2, Limits.MinFileNameLength);

            Assert.AreEqual(1, Limits.MinIdLength);

            Assert.AreEqual(8, Limits.MinMessageLength);

            Assert.AreEqual(2, Limits.MinNameLength);

            Assert.AreEqual(8, Limits.MinParagraphSourceTextLength);

            Assert.AreEqual(2, Limits.MinTagLength);

            Assert.AreEqual(1, Limits.MinTranslationUnitSourceTextLenght);
        }
    }
}
