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
    public class ClientAuthenticationMethodsTest
    {
        [TestMethod]
        public void TokenEndpointAuthMethodsConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(ClientAuthenticationMethods), 7);

            Assert.AreEqual("client_secret_basic", ClientAuthenticationMethods.Basic);
            Assert.AreEqual("none", ClientAuthenticationMethods.None);
            Assert.AreEqual("client_secret_post", ClientAuthenticationMethods.PostBody);
            Assert.AreEqual("private_key_jwt", ClientAuthenticationMethods.PrivateKeyJwt);
            Assert.AreEqual("client_secret_jwt", ClientAuthenticationMethods.SecretKeyJwt);
            Assert.AreEqual("self_signed_tls_client_auth", ClientAuthenticationMethods.SelfSignedTlsClientAuth);
            Assert.AreEqual("tls_client_auth", ClientAuthenticationMethods.TlsClientAuth);
        }
    }
}
