// Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace PerpetualIntelligence.Shared.Services
{
    [TestClass]
    public class UrlSafeBase64EncoderTests
    {
        [TestMethod]
        public void EncodeDecodeTest()
        {
            string iptStr = "asd+kasd*&((*(9assdaASDASDhttps://perpetualintelligence.azurewebsites.net/234asdasd+===%772347823&*^(&*^*(^(*&^(*&^*^*&";
            byte[] iptBytes = Encoding.UTF8.GetBytes(iptStr);


            string encoded = UrlSafeBase64Encoder.Encode(iptBytes);
            byte[] decoded = UrlSafeBase64Encoder.Decode(encoded);
            string decodedStr = Encoding.UTF8.GetString(decoded);

            Assert.AreEqual(iptStr, decodedStr);
        }


        [TestMethod]
        public void UTF8EncodeDecodeTest()
        {
            string iptStr = "asd+kasd*&((*(9assdaASDASDhttps://perpetualintelligence.azurewebsites.net/234asdasd+===%772347823&*^(&*^*(^(*&^(*&^*^*&";

            string encoded = UrlSafeBase64Encoder.Utf8Encode(iptStr);
            string decoded = UrlSafeBase64Encoder.Utf8Decode(encoded);

            Assert.AreEqual(iptStr, decoded);
        }
    }
}
