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
    public class DiscoveryTest
    {
        [TestMethod]
        public void DiscoveryConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Discovery), 49);

            Assert.AreEqual("acr_values_supported", Discovery.AcrValuesSupported);
            Assert.AreEqual("authorization_endpoint", Discovery.AuthorizationEndpoint);
            Assert.AreEqual("authorization_response_iss_parameter_supported", Discovery.AuthorizationResponseIssParameterSupported);
            Assert.AreEqual("backchannel_logout_session_supported", Discovery.BackChannelLogoutSessionSupported);
            Assert.AreEqual("backchannel_logout_supported", Discovery.BackChannelLogoutSupported);
            Assert.AreEqual("check_session_iframe", Discovery.CheckSessionIframe);
            Assert.AreEqual("claims_locales_supported", Discovery.ClaimsLocalesSupported);
            Assert.AreEqual("claims_parameter_supported", Discovery.ClaimsParameterSupported);
            Assert.AreEqual("claims_supported", Discovery.ClaimsSupported);
            Assert.AreEqual("claim_types_supported", Discovery.ClaimTypesSupported);
            Assert.AreEqual("code_challenge_methods_supported", Discovery.CodeChallengeMethodsSupported);
            Assert.AreEqual("device_authorization_endpoint", Discovery.DeviceAuthorizationEndpoint);
            Assert.AreEqual(".well-known/openid-configuration", Discovery.DiscoveryEndpoint);
            Assert.AreEqual("display_values_supported", Discovery.DisplayValuesSupported);
            Assert.AreEqual("end_session_endpoint", Discovery.EndSessionEndpoint);
            Assert.AreEqual("frontchannel_logout_session_supported", Discovery.FrontChannelLogoutSessionSupported);
            Assert.AreEqual("frontchannel_logout_supported", Discovery.FrontChannelLogoutSupported);
            Assert.AreEqual("grant_types_supported", Discovery.GrantTypesSupported);
            Assert.AreEqual("id_token_encryption_alg_values_supported", Discovery.IdTokenEncryptionAlgorithmsSupported);
            Assert.AreEqual("id_token_encryption_enc_values_supported", Discovery.IdTokenEncryptionEncValuesSupported);
            Assert.AreEqual("id_token_signing_alg_values_supported", Discovery.IdTokenSigningAlgorithmsSupported);
            Assert.AreEqual("introspection_endpoint", Discovery.IntrospectionEndpoint);
            Assert.AreEqual("issuer", Discovery.Issuer);
            Assert.AreEqual("jwks_uri", Discovery.JwksUri);
            Assert.AreEqual("mtls_endpoint_aliases", Discovery.MtlsEndpointAliases);
            Assert.AreEqual("op_policy_uri", Discovery.OpPolicyUri);
            Assert.AreEqual("op_tos_uri", Discovery.OpTosUri);
            Assert.AreEqual("registration_endpoint", Discovery.RegistrationEndpoint);
            Assert.AreEqual("request_object_encryption_alg_values_supported", Discovery.RequestObjectEncryptionAlgorithmsSupported);
            Assert.AreEqual("request_object_encryption_enc_values_supported", Discovery.RequestObjectEncryptionEncValuesSupported);
            Assert.AreEqual("request_object_signing_alg_values_supported", Discovery.RequestObjectSigningAlgorithmsSupported);
            Assert.AreEqual("request_parameter_supported", Discovery.RequestParameterSupported);
            Assert.AreEqual("request_uri_parameter_supported", Discovery.RequestUriParameterSupported);
            Assert.AreEqual("require_request_uri_registration", Discovery.RequireRequestUriRegistration);
            Assert.AreEqual("response_modes_supported", Discovery.ResponseModesSupported);
            Assert.AreEqual("response_types_supported", Discovery.ResponseTypesSupported);
            Assert.AreEqual("revocation_endpoint", Discovery.RevocationEndpoint);
            Assert.AreEqual("scopes_supported", Discovery.ScopesSupported);
            Assert.AreEqual("service_documentation", Discovery.ServiceDocumentation);
            Assert.AreEqual("subject_types_supported", Discovery.SubjectTypesSupported);
            Assert.AreEqual("tls_client_certificate_bound_access_tokens", Discovery.TlsClientCertificateBoundAccessTokens);
            Assert.AreEqual("token_endpoint", Discovery.TokenEndpoint);
            Assert.AreEqual("token_endpoint_auth_methods_supported", Discovery.TokenEndpointAuthenticationMethodsSupported);
            Assert.AreEqual("token_endpoint_auth_signing_alg_values_supported", Discovery.TokenEndpointAuthSigningAlgorithmsSupported);
            Assert.AreEqual("ui_locales_supported", Discovery.UILocalesSupported);
            Assert.AreEqual("userinfo_encryption_alg_values_supported", Discovery.UserInfoEncryptionAlgorithmsSupported);
            Assert.AreEqual("userinfo_encryption_enc_values_supported", Discovery.UserInfoEncryptionEncValuesSupported);
            Assert.AreEqual("userinfo_endpoint", Discovery.UserInfoEndpoint);
            Assert.AreEqual("userinfo_signing_alg_values_supported", Discovery.UserInfoSigningAlgorithmsSupported);
        }
    }
}
