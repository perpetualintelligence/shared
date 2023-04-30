/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using System.Text;
using Xunit;

namespace PerpetualIntelligence.Shared.Services
{
    public class UrlSafeBase64EncoderTests
    {
        [Fact]
        public void EncodeDecodeTest()
        {
            string iptStr = "asd+kasd*&((*(9assdaASDASDhttps://perpetualintelligence.azurewebsites.net/234asdasd+===%772347823&*^(&*^*(^(*&^(*&^*^*&";
            byte[] iptBytes = Encoding.UTF8.GetBytes(iptStr);

            string encoded = UrlSafeBase64Encoder.Encode(iptBytes);
            byte[] decoded = UrlSafeBase64Encoder.Decode(encoded);
            string decodedStr = Encoding.UTF8.GetString(decoded);

            decodedStr.Should().Be(iptStr);
        }

        [Fact]
        public void EncodeDecodeUnicodeTest()
        {
            string iptStr = "पुरुष आणि स्त्री, मुलगा आणि मुलगी.";
            byte[] iptBytes = Encoding.UTF8.GetBytes(iptStr);

            string encoded = UrlSafeBase64Encoder.Encode(iptBytes);
            byte[] decoded = UrlSafeBase64Encoder.Decode(encoded);
            string decodedStr = Encoding.UTF8.GetString(decoded);

            decodedStr.Should().Be(iptStr);
        }

        [Fact]
        public void UTF8EncodeDecodeTest()
        {
            string iptStr = "asd+kasd*&((*(9assdaASDASDhttps://perpetualintelligence.azurewebsites.net/234asdasd+===%772347823&*^(&*^*(^(*&^(*&^*^*&";

            string encoded = UrlSafeBase64Encoder.Utf8Encode(iptStr);
            string decoded = UrlSafeBase64Encoder.Utf8Decode(encoded);

            decoded.Should().Be(iptStr);
        }

        [Fact]
        public void UTF8EncodeDecodeUnicodeTest()
        {
            string iptStr = "पुरुष आणि स्त्री, मुलगा आणि मुलगी.";

            string encoded = UrlSafeBase64Encoder.Utf8Encode(iptStr);
            string decoded = UrlSafeBase64Encoder.Utf8Decode(encoded);

            decoded.Should().Be(iptStr);
        }
    }
}