﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using FluentAssertions;
using Xunit;

namespace PerpetualIntelligence.Protocols.Authorization
{
    public class HeaderKeysTests
    {
        [Fact]
        public void HeaderKeys_Should_Be_Correct()
        {
            HeaderKeys.AppId.Should().Be("x-oneimlx-app-id");
            HeaderKeys.AppType.Should().Be("x-oneimlx-app-type");
            HeaderKeys.LoginSubject.Should().Be("x-oneimlx-login-sub");
            HeaderKeys.LoginObjectId.Should().Be("x-oneimlx-login-oid");
            HeaderKeys.LoginTenantId.Should().Be("x-oneimlx-login-tid");
        }
    }
}