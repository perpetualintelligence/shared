/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class ErrorsTest
    {
        [TestMethod]
        public void AuthenticationErrorsTest()
        {
            Assert.AreEqual(9, Errors.AuthenticationErrors.Length);
            CollectionAssert.AreEqual(new string[] { Errors.InteractionRequired, Errors.LoginRequired, Errors.AccountSelectionRequired, Errors.ConsentRequired, Errors.InvalidRequestUri, Errors.InvalidRequestObject, Errors.RequestNotSupported, Errors.RequestUriNotSupported, Errors.RegistrationNotSupported }, Errors.AuthenticationErrors);
        }

        [TestMethod]
        public void AuthorizationErrorsTest()
        {
            Assert.AreEqual(6, Errors.AuthorizationErrors.Length);
            Assert.AreEqual(Errors.AccessDenied, Errors.AuthorizationErrors[0]);
            Assert.AreEqual(Errors.InteractionRequired, Errors.AuthorizationErrors[1]);
            Assert.AreEqual(Errors.LoginRequired, Errors.AuthorizationErrors[2]);
            Assert.AreEqual(Errors.AccountSelectionRequired, Errors.AuthorizationErrors[3]);
            Assert.AreEqual(Errors.ConsentRequired, Errors.AuthorizationErrors[4]);
            Assert.AreEqual(Errors.TemporarilyUnavailable, Errors.AuthorizationErrors[5]);
        }

        [TestMethod]
        public void ErrorConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Errors), 37);

            Assert.AreEqual("access_denied", Errors.AccessDenied);
            Assert.AreEqual("account_selection_required", Errors.AccountSelectionRequired);
            Assert.AreEqual("authorization_pending", Errors.AuthorizationPending);
            Assert.AreEqual("consent_required", Errors.ConsentRequired);
            Assert.AreEqual("expired_token", Errors.ExpiredToken);
            Assert.AreEqual("insufficient_scope", Errors.InsufficientScope);
            Assert.AreEqual("interaction_required", Errors.InteractionRequired);
            Assert.AreEqual("invalid_client", Errors.InvalidClient);
            Assert.AreEqual("invalid_endpoint", Errors.InvalidEndpoint);
            Assert.AreEqual("invalid_grant", Errors.InvalidGrant);
            Assert.AreEqual("invalid_request", Errors.InvalidRequest);
            Assert.AreEqual("invalid_request_object", Errors.InvalidRequestObject);
            Assert.AreEqual("invalid_request_uri", Errors.InvalidRequestUri);
            Assert.AreEqual("invalid_scope", Errors.InvalidScope);
            Assert.AreEqual("invalid_target", Errors.InvalidTarget);
            Assert.AreEqual("invalid_token", Errors.InvalidToken);
            Assert.AreEqual("invalid_origin", Errors.InvalidOrigin);
            Assert.AreEqual("login_required", Errors.LoginRequired);
            Assert.AreEqual("registration_not_supported", Errors.RegistrationNotSupported);
            Assert.AreEqual("request_not_supported", Errors.RequestNotSupported);
            Assert.AreEqual("request_uri_not_supported", Errors.RequestUriNotSupported);
            Assert.AreEqual("server_error", Errors.ServerError);
            Assert.AreEqual("slow_down", Errors.SlowDown);
            Assert.AreEqual("temporarily_unavailable", Errors.TemporarilyUnavailable);
            Assert.AreEqual("unexpected_error", Errors.UnexpectedError);
            Assert.AreEqual("unexpected_warning", Errors.UnexpectedWarning);
            Assert.AreEqual("unexpected_information", Errors.UnexpectedInformation);
            Assert.AreEqual("unauthorized_client", Errors.UnauthorizedClient);
            Assert.AreEqual("unauthorized_origin", Errors.UnauthorizedOrigin);
            Assert.AreEqual("unauthorized_subject", Errors.UnauthorizedSubject);
            Assert.AreEqual("unsupported_grant_type", Errors.UnsupportedGrantType);
            Assert.AreEqual("unsupported_response_type", Errors.UnsupportedResponseType);
            Assert.AreEqual("unsupported_response_mode", Errors.UnsupportedResponseMode);
            Assert.AreEqual("missing_token", Errors.MissingToken);
            Assert.AreEqual("unsupported_token_type", Errors.UnsupportedTokenType);
            Assert.AreEqual("policy_violation", Errors.PolicyViolation);
            Assert.AreEqual("transaction_failed", Errors.TransactionFailed);
        }

        [TestMethod]
        public void TokenErrorsTest()
        {
            Assert.AreEqual(7, Errors.TokenErrors.Length);
            Assert.AreEqual("invalid_request", Errors.TokenErrors[0]);
            Assert.AreEqual("invalid_client", Errors.TokenErrors[1]);
            Assert.AreEqual("invalid_grant", Errors.TokenErrors[2]);
            Assert.AreEqual("unauthorized_client", Errors.TokenErrors[3]);
            Assert.AreEqual("unsupported_grant_type", Errors.TokenErrors[4]);
            Assert.AreEqual("invalid_scope", Errors.TokenErrors[5]);
            Assert.AreEqual("invalid_target", Errors.TokenErrors[6]);
        }
    }
}
