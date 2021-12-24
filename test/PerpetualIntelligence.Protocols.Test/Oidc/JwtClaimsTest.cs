/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved https://perpetualintelligence.com https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class JwtClaimsTest
    {
        [TestMethod]
        public void JwtClaimTypesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(JwtClaims), 54);

            Assert.AreEqual("active", JwtClaims.Active);
            Assert.AreEqual("at_hash", JwtClaims.AccessTokenHash);
            Assert.AreEqual("act", JwtClaims.Actor);
            Assert.AreEqual("address", JwtClaims.Address);
            Assert.AreEqual("urn:oneimlx:oidc:jwtclaims:app", JwtClaims.Application);
            Assert.AreEqual("aud", JwtClaims.Audience);
            Assert.AreEqual("acr", JwtClaims.AuthenticationContextClassReference);
            Assert.AreEqual("amr", JwtClaims.AuthenticationMethod);
            Assert.AreEqual("auth_time", JwtClaims.AuthenticationTime);
            Assert.AreEqual("c_hash", JwtClaims.AuthorizationCodeHash);
            Assert.AreEqual("azp", JwtClaims.AuthorizedParty);
            Assert.AreEqual("birthdate", JwtClaims.BirthDate);
            Assert.AreEqual("client_id", JwtClaims.ClientId);
            Assert.AreEqual("cnf", JwtClaims.Confirmation);
            Assert.AreEqual("email", JwtClaims.Email);
            Assert.AreEqual("email_verified", JwtClaims.EmailVerified);
            Assert.AreEqual("events", JwtClaims.Events);
            Assert.AreEqual("exp", JwtClaims.Expiration);
            Assert.AreEqual("family_name", JwtClaims.FamilyName);
            Assert.AreEqual("gender", JwtClaims.Gender);
            Assert.AreEqual("given_name", JwtClaims.GivenName);
            Assert.AreEqual("id", JwtClaims.Id);
            Assert.AreEqual("idp", JwtClaims.IdentityProvider);
            Assert.AreEqual("iat", JwtClaims.IssuedAt);
            Assert.AreEqual("iss", JwtClaims.Issuer);
            Assert.AreEqual("jti", JwtClaims.JwtId);
            Assert.AreEqual("locale", JwtClaims.Locale);
            Assert.AreEqual("may_act", JwtClaims.MayAct);
            Assert.AreEqual("middle_name", JwtClaims.MiddleName);
            Assert.AreEqual("name", JwtClaims.Name);
            Assert.AreEqual("nickname", JwtClaims.NickName);
            Assert.AreEqual("nonce", JwtClaims.Nonce);
            Assert.AreEqual("nbf", JwtClaims.NotBefore);
            Assert.AreEqual("urn:oneimlx:oidc:jwtclaims:perm", JwtClaims.Permission);
            Assert.AreEqual("phone_number", JwtClaims.PhoneNumber);
            Assert.AreEqual("phone_number_verified", JwtClaims.PhoneNumberVerified);
            Assert.AreEqual("picture", JwtClaims.Picture);
            Assert.AreEqual("preferred_username", JwtClaims.PreferredUserName);
            Assert.AreEqual("profile", JwtClaims.Profile);
            Assert.AreEqual("reference_token_id", JwtClaims.ReferenceTokenId);
            Assert.AreEqual("role", JwtClaims.Role);
            Assert.AreEqual("scope", JwtClaims.Scope);
            Assert.AreEqual("sid", JwtClaims.SessionId);
            Assert.AreEqual("s_hash", JwtClaims.StateHash);
            Assert.AreEqual("sub", JwtClaims.Subject);
            Assert.AreEqual("urn:oneimlx:oidc:jwtclaims:tenant", JwtClaims.Tenant);
            Assert.AreEqual("urn:oneimlx:oidc:jwtclaims:tl1", JwtClaims.TenantLevel1);
            Assert.AreEqual("urn:oneimlx:oidc:jwtclaims:tl2", JwtClaims.TenantLevel2);
            Assert.AreEqual("urn:oneimlx:oidc:jwtclaims:tl3", JwtClaims.TenantLevel3);
            Assert.AreEqual("urn:oneimlx:oidc:jwtclaims:tl4", JwtClaims.TenantLevel4);
            Assert.AreEqual("urn:oneimlx:oidc:jwtclaims:tl5", JwtClaims.TenantLevel5);
            Assert.AreEqual("updated_at", JwtClaims.UpdatedAt);
            Assert.AreEqual("website", JwtClaims.WebSite);
            Assert.AreEqual("zoneinfo", JwtClaims.ZoneInfo);
        }
    }
}
