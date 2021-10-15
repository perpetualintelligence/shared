// Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
   public class ErrorsTest
    {
        [TestMethod]
        public void ErrorConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(Errors), 35);
                        
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
            Assert.AreEqual("redirect_required", Errors.RedirectRequired);
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
            Assert.AreEqual("missing_token", Errors.MissingToken);
            Assert.AreEqual("unsupported_token_type", Errors.UnsupportedTokenType);
        }
    }
}
