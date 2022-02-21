/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Protocols.Defaults.Versioning;
using PerpetualIntelligence.Protocols.Oidc;
using PerpetualIntelligence.Protocols.OneImlx;
using PerpetualIntelligence.Test;
using PerpetualIntelligence.Test.Services;
using System.Collections.Generic;

namespace PerpetualIntelligence.Protocols.Defaults.Oidc
{
    [TestClass]
    public class DefaultUrlVersionEndpointAccessorTests : InitializerTests
    {
        public DefaultUrlVersionEndpointAccessorTests() : base(TestLogger.Create<DefaultUrlVersionEndpointAccessorTests>())
        {
        }

        [TestMethod]
        public void AuthorityShouldReturnValid()
        {
            DefaultVersionedOPAccessor localAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("test_server_local_endpoint", localAccessor.Authority);

            _configuration[RuntimeOptions.EndpointsHost] = ApiConstants.ProductionEndpoint;
            DefaultVersionedOPAccessor prodAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("test_server_prod_endpoint", prodAccessor.Authority);
        }

        [TestMethod]
        public void AuthorizeEndpointShouldReturnValid()
        {
            DefaultVersionedOPAccessor localAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("v1/oidc/authorization/authenticate", localAccessor.AuthorizeEndpoint);
        }

        [TestMethod]
        public void ClientIdShouldReturnValid()
        {
            DefaultVersionedOPAccessor localAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("Neutral.Q3Wv09Dfk06cGMKONRzXXw.perpetualintelligencetest", localAccessor.ClientId);
        }

        [TestMethod]
        public void ClientUriShouldReturnValid()
        {
            DefaultVersionedOPAccessor localAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("test_client_local_endpoint", localAccessor.ClientUri);

            _configuration[RuntimeOptions.EndpointsHost] = ApiConstants.ProductionEndpoint;
            DefaultVersionedOPAccessor prodAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("test_client_prod_endpoint", prodAccessor.ClientUri);
        }

        [TestMethod]
        public void DefaultScopesShouldReturnValid()
        {
            DefaultVersionedOPAccessor accessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            CollectionAssert.AreEquivalent(new string[] {
                    Scopes.OpenId,
                    Scopes.Profile,
                    Scopes.Email,
                    Scopes.Tenant,
                    Scopes.Role,
                    Scopes.Permission,
                    Scopes.Application
                }, accessor.DefaultScopes);
        }

        [TestMethod]
        public void PostLogoutRedirectUriShouldReturnValid()
        {
            DefaultVersionedOPAccessor localAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("authentication/logout-callback", localAccessor.PostLogoutRedirectUri);
        }

        [TestMethod]
        public void ProfileEndpointShouldReturnValid()
        {
            DefaultVersionedOPAccessor localAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("v1/oidc/authorization/profile", localAccessor.ProfileEndpoint);
        }

        [TestMethod]
        public void RedirectUriShouldReturnValid()
        {
            DefaultVersionedOPAccessor localAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("authentication/login-callback", localAccessor.RedirectUri);
        }

        [TestMethod]
        public void RegisterEndpointShouldReturnValid()
        {
            DefaultVersionedOPAccessor localAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("v1/oidc/authorization/register", localAccessor.RegisterEndpoint);
        }

        [TestMethod]
        public void ResponseTypeShouldReturnValid()
        {
            DefaultVersionedOPAccessor localAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("code", localAccessor.ResponseType);
        }

        [TestMethod]
        public void TokenEndpointShouldReturnValid()
        {
            DefaultVersionedOPAccessor localAccessor = new DefaultVersionedOPAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("v1/oidc/authorization/token", localAccessor.TokenEndpoint);
        }

        protected override void OnTestInitialize()
        {
            var myConfiguration = new Dictionary<string, string>
            {
                {RuntimeOptions.EndpointsHost, ApiConstants.LocalhostEndpoint},
                {RuntimeOptions.ApiServerLocalhostEndpoint, "test_server_local_endpoint"},
                {RuntimeOptions.ApiServerProductionEndpoint, "test_server_prod_endpoint"},
                {RuntimeOptions.ClientAppLocalhostEndpoint, "test_client_local_endpoint"},
                {RuntimeOptions.ClientAppProductionEndpoint, "test_client_prod_endpoint"},
            };

            _configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(myConfiguration)
                .Build();
        }

        private IConfiguration _configuration = null!;
    }
}
