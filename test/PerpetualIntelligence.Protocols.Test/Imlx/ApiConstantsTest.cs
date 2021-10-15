/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Imlx
{
    [TestClass]
    public class ApiConstantsTest
    {
        [TestMethod]
        public void ConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(ApiConstants), 11);

            Assert.AreEqual("imlx", ApiConstants.ImlxId);
            Assert.AreEqual("urn:pi:protocols:imlx:http:server", ApiConstants.ApiServerHttpClient);
            Assert.AreEqual("urn:pi:protocols:imlx:http:client", ApiConstants.ClientAppHttpClient);
            Assert.AreEqual("application/x-www-form-urlencoded", ApiConstants.ContentTypeForm);
            Assert.AreEqual("text/html; charset=UTF-8", ApiConstants.ContentTypeHtml);
            Assert.AreEqual("application/json", ApiConstants.ContentTypeJson);
            Assert.AreEqual("multipart/form-data", ApiConstants.ContentTypeMultipart);
            Assert.AreEqual("urn:pi:protocols:imlx:payment:live", ApiConstants.LivePayment);
            Assert.AreEqual("urn:pi:protocols:imlx:host:local", ApiConstants.LocalhostEndpoint);
            Assert.AreEqual("urn:pi:protocols:imlx:host:prod", ApiConstants.ProductionEndpoint);
            Assert.AreEqual("urn:pi:protocols:imlx:payment:test", ApiConstants.TestPayment);
        }
    }
}
