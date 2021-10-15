// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
   public class ParametersTest
    {
        [TestMethod]
        public void ParameterConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(Parameters), 61);

            Assert.AreEqual("access_token", Parameters.AccessToken);
            Assert.AreEqual("acr_values", Parameters.AcrValues);
            Assert.AreEqual("actor_token", Parameters.ActorToken);
            Assert.AreEqual("actor_token_type", Parameters.ActorTokenType);
            Assert.AreEqual("alg", Parameters.Algorithm);
            Assert.AreEqual("assertion", Parameters.Assertion);
            Assert.AreEqual("audience", Parameters.Audience);
            Assert.AreEqual("client_assertion", Parameters.ClientAssertion);
            Assert.AreEqual("client_assertion_type", Parameters.ClientAssertionType);
            Assert.AreEqual("client_id", Parameters.ClientId);
            Assert.AreEqual("client_secret", Parameters.ClientSecret);
            Assert.AreEqual("code", Parameters.Code);
            Assert.AreEqual("code_challenge", Parameters.CodeChallenge);
            Assert.AreEqual("code_challenge_method", Parameters.CodeChallengeMethod);
            Assert.AreEqual("code_verifier", Parameters.CodeVerifier);
            Assert.AreEqual("device_code", Parameters.DeviceCode);
            Assert.AreEqual("display", Parameters.Display);
            Assert.AreEqual("error", Parameters.Error);
            Assert.AreEqual("error_description", Parameters.ErrorDescription);
            Assert.AreEqual("error_uri", Parameters.ErrorUri);
            Assert.AreEqual("expires_in", Parameters.ExpiresIn);
            Assert.AreEqual("grant_type", Parameters.GrantType);
            Assert.AreEqual("id_token", Parameters.IdToken);
            Assert.AreEqual("id_token_hint", Parameters.IdTokenHint);
            Assert.AreEqual("issued_token_type", Parameters.IssuedTokenType);
            Assert.AreEqual("iss", Parameters.Issuer);
            Assert.AreEqual("key", Parameters.Key);
            Assert.AreEqual("login_hint", Parameters.LoginHint);
            Assert.AreEqual("max_age", Parameters.MaxAge);
            Assert.AreEqual("nonce", Parameters.Nonce);
            Assert.AreEqual("password", Parameters.Password);
            Assert.AreEqual("post_logout_redirect_uri", Parameters.PostLogoutRedirectUri);
            Assert.AreEqual("prompt", Parameters.Prompt);
            Assert.AreEqual("redirect_uri", Parameters.RedirectUri);
            Assert.AreEqual("refresh_token", Parameters.RefreshToken);
            Assert.AreEqual("request", Parameters.Request);
            Assert.AreEqual("request_id", Parameters.RequestId);
            Assert.AreEqual("requested_token_type", Parameters.RequestedTokenType);
            Assert.AreEqual("request_uri", Parameters.RequestUri);
            Assert.AreEqual("resource", Parameters.Resource);
            Assert.AreEqual("response_mode", Parameters.ResponseMode);
            Assert.AreEqual("response_type", Parameters.ResponseType);
            Assert.AreEqual("scope", Parameters.Scope);
            Assert.AreEqual("sid", Parameters.Sid);
            Assert.AreEqual("state", Parameters.State);
            Assert.AreEqual("session_state", Parameters.SessionState);

            // token exchange
            Assert.AreEqual("subject_token", Parameters.SubjectToken);
            Assert.AreEqual("subject_token_type", Parameters.SubjectTokenType);
            Assert.AreEqual("token_type", Parameters.TokenType);
            Assert.AreEqual("ui_locales", Parameters.UiLocales);
            Assert.AreEqual("username", Parameters.UserName);
            Assert.AreEqual("token", Parameters.Token);
            Assert.AreEqual("token_type_hint", Parameters.TokenTypeHint);

            // device
            Assert.AreEqual("device_code", Parameters.DeviceCode);
            Assert.AreEqual("user_code", Parameters.UserCode);
            Assert.AreEqual("verification_uri", Parameters.VerificationUri);
            Assert.AreEqual("verification_uri_complete", Parameters.VerificationUriComplete);
            Assert.AreEqual("interval", Parameters.Interval);

            // dynamic registration
            Assert.AreEqual("registration_access_token", Parameters.RegistrationAccessToken);
            Assert.AreEqual("registration_client_uri", Parameters.RegistrationClientUri);
            Assert.AreEqual("client_id_issued_at", Parameters.ClientIdIssuedAt);
            Assert.AreEqual("client_secret_expires_at", Parameters.ClientSecretExpiresAt);
        }
    }
}
