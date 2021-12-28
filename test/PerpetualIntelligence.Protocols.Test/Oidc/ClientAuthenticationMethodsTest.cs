/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class ClientAuthenticationMethodsTest
    {
        [TestMethod]
        public void TokenEndpointAuthMethodsConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(ClientAuthenticationMethods), 6);

            Assert.AreEqual("client_secret_basic", ClientAuthenticationMethods.Basic);
            Assert.AreEqual("client_secret_post", ClientAuthenticationMethods.PostBody);
            Assert.AreEqual("private_key_jwt", ClientAuthenticationMethods.PrivateKeyJwt);
            Assert.AreEqual("client_secret_jwt", ClientAuthenticationMethods.SecretKeyJwt);
            Assert.AreEqual("self_signed_tls_client_auth", ClientAuthenticationMethods.SelfSignedTlsClientAuth);
            Assert.AreEqual("tls_client_auth", ClientAuthenticationMethods.TlsClientAuth);
        }
    }
}
