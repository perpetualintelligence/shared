/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Protocols.Oidc;
using PerpetualIntelligence.Protocols.OneImlx;
using PerpetualIntelligence.Test;
using PerpetualIntelligence.Test.Services;
using System.Collections.Generic;

namespace PerpetualIntelligence.Protocols.Defaults.Versioning
{
    [TestClass]
    public class DefaultUrlVersionEndpointAccessorTests : OneImlxLogTest
    {
        public DefaultUrlVersionEndpointAccessorTests() : base(TestLogger.Create<DefaultUrlVersionEndpointAccessorTests>())
        {
        }

        [TestMethod]
        public void AuthorityShouldReturnValid()
        {
            DefaultUrlVersionEndpointAccessor localAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("test_server_local_endpoint", localAccessor.Authority);

            _configuration[RuntimeOptions.EndpointsHost] = ApiConstants.ProductionEndpoint;
            DefaultUrlVersionEndpointAccessor prodAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("test_server_prod_endpoint", prodAccessor.Authority);
        }

        [TestMethod]
        public void AuthorizeEndpointShouldReturnValid()
        {
            DefaultUrlVersionEndpointAccessor localAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("v1/oidc/authorization/authenticate", localAccessor.AuthorizeEndpoint);
        }

        [TestMethod]
        public void ClientIdShouldReturnValid()
        {
            DefaultUrlVersionEndpointAccessor localAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("Neutral.Q3Wv09Dfk06cGMKONRzXXw.perpetualintelligencetest", localAccessor.ClientId);
        }

        [TestMethod]
        public void ClientUriShouldReturnValid()
        {
            DefaultUrlVersionEndpointAccessor localAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("test_client_local_endpoint", localAccessor.ClientUri);

            _configuration[RuntimeOptions.EndpointsHost] = ApiConstants.ProductionEndpoint;
            DefaultUrlVersionEndpointAccessor prodAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("test_client_prod_endpoint", prodAccessor.ClientUri);
        }

        [TestMethod]
        public void DefaultScopesShouldReturnValid()
        {
            DefaultUrlVersionEndpointAccessor accessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
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
            DefaultUrlVersionEndpointAccessor localAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("authentication/logout-callback", localAccessor.PostLogoutRedirectUri);
        }

        [TestMethod]
        public void ProfileEndpointShouldReturnValid()
        {
            DefaultUrlVersionEndpointAccessor localAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("v1/oidc/authorization/profile", localAccessor.ProfileEndpoint);
        }

        [TestMethod]
        public void RedirectUriShouldReturnValid()
        {
            DefaultUrlVersionEndpointAccessor localAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("authentication/login-callback", localAccessor.RedirectUri);
        }

        [TestMethod]
        public void RegisterEndpointShouldReturnValid()
        {
            DefaultUrlVersionEndpointAccessor localAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("v1/oidc/authorization/register", localAccessor.RegisterEndpoint);
        }

        [TestMethod]
        public void ResponseTypeShouldReturnValid()
        {
            DefaultUrlVersionEndpointAccessor localAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
            Assert.AreEqual("code", localAccessor.ResponseType);
        }

        [TestMethod]
        public void TokenEndpointShouldReturnValid()
        {
            DefaultUrlVersionEndpointAccessor localAccessor = new DefaultUrlVersionEndpointAccessor(_configuration, new DefaultUrlV1VersionAccessor());
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
