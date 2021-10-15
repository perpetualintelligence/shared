// Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
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
   public class ClientMetadataTest
    {
        [TestMethod]
        public void ClientMetadataConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(ClientMetadata), 30);

            Assert.AreEqual("application_type", ClientMetadata.ApplicationType);
            Assert.AreEqual("client_name", ClientMetadata.ClientName);
            Assert.AreEqual("client_uri", ClientMetadata.ClientUri);
            Assert.AreEqual("contacts", ClientMetadata.Contacts);
            Assert.AreEqual("default_acr_values", ClientMetadata.DefaultAcrValues);
            Assert.AreEqual("default_max_age", ClientMetadata.DefaultMaxAge);
            Assert.AreEqual("grant_types", ClientMetadata.GrantTypes);
            Assert.AreEqual("id_token_encrypted_response_alg", ClientMetadata.IdentityTokenEncryptedResponseAlgorithm);
            Assert.AreEqual("id_token_encrypted_response_enc", ClientMetadata.IdentityTokenEncryptedResponseEncryption);
            Assert.AreEqual("id_token_signed_response_alg", ClientMetadata.IdentityTokenSignedResponseAlgorithm);
            Assert.AreEqual("initiate_login_uri", ClientMetadata.InitiateLoginUris);
            Assert.AreEqual("jwks", ClientMetadata.Jwks);
            Assert.AreEqual("jwks_uri", ClientMetadata.JwksUri);
            Assert.AreEqual("logo_uri", ClientMetadata.LogoUri);
            Assert.AreEqual("policy_uri", ClientMetadata.PolicyUri);
            Assert.AreEqual("redirect_uris", ClientMetadata.RedirectUris);
            Assert.AreEqual("request_object_encryption_alg", ClientMetadata.RequestObjectEncryptionAlgorithm);
            Assert.AreEqual("request_object_encryption_enc", ClientMetadata.RequestObjectEncryptionEncryption);
            Assert.AreEqual("request_object_signing_alg", ClientMetadata.RequestObjectSigningAlgorithm);
            Assert.AreEqual("request_uris", ClientMetadata.RequestUris);
            Assert.AreEqual("require_auth_time", ClientMetadata.RequireAuthenticationTime);
            Assert.AreEqual("response_types", ClientMetadata.ResponseTypes);
            Assert.AreEqual("sector_identifier_uri", ClientMetadata.SectorIdentifierUri);
            Assert.AreEqual("subject_type", ClientMetadata.SubjectType);
            Assert.AreEqual("token_endpoint_auth_method", ClientMetadata.TokenEndpointAuthenticationMethod);
            Assert.AreEqual("token_endpoint_auth_signing_alg", ClientMetadata.TokenEndpointAuthenticationSigningAlgorithm);
            Assert.AreEqual("tos_uri", ClientMetadata.TosUri);
            Assert.AreEqual("userinfo_encrypted_response_alg", ClientMetadata.UserInfoEncryptedResponseAlgorithm);
            Assert.AreEqual("userinfo_encrypted_response_enc", ClientMetadata.UserinfoEncryptedResponseEncryption);
            Assert.AreEqual("userinfo_signed_response_alg", ClientMetadata.UserinfoSignedResponseAlgorithm);
        }
    }
}
