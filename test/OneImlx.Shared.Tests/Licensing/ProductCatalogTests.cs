/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using OneImlx.Test.FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace OneImlx.Shared.Licensing
{
    public class ProductCatalogTests
    {
        [Fact]
        public void Constants_Returns_ExpectedUrns()
        {
            typeof(ProductCatalog).Should().HaveConstantCount(8);

            // Products
            ProductCatalog.TerminalFramework.Should().Be("urn:oneimlx:terminal");

            // Plans
            ProductCatalog.TerminalPlanDemo.Should().Be("urn:oneimlx:terminal:plan:demo");
            ProductCatalog.TerminalPlanSolo.Should().Be("urn:oneimlx:terminal:plan:solo");
            ProductCatalog.TerminalPlanMicro.Should().Be("urn:oneimlx:terminal:plan:micro");
            ProductCatalog.TerminalPlanSmb.Should().Be("urn:oneimlx:terminal:plan:smb");
            ProductCatalog.TerminalPlanEnterprise.Should().Be("urn:oneimlx:terminal:plan:enterprise");
            ProductCatalog.TerminalPlanCorporate.Should().Be("urn:oneimlx:terminal:plan:corporate");
            ProductCatalog.TerminalPlanCustom.Should().Be("urn:oneimlx:terminal:plan:custom");
        }

        [Fact]
        public void IsValidPlan_Returns_False_ForInvalidPlan()
        {
            var result = ProductCatalog.IsValidPlan(ProductCatalog.TerminalFramework, "invalid-plan");
            result.Should().BeFalse();
        }

        [Fact]
        public void IsValidPlan_Returns_False_ForInvalidProduct()
        {
            var result = ProductCatalog.IsValidPlan("invalid-product", ProductCatalog.TerminalPlanSolo);
            result.Should().BeFalse();
        }

        [Fact]
        public void IsValidPlan_Returns_True_ForValidPlans()
        {
            ProductCatalog.IsValidPlan(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanDemo).Should().BeTrue();
            ProductCatalog.IsValidPlan(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanSolo).Should().BeTrue();
            ProductCatalog.IsValidPlan(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanMicro).Should().BeTrue();
            ProductCatalog.IsValidPlan(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanSmb).Should().BeTrue();
            ProductCatalog.IsValidPlan(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanEnterprise).Should().BeTrue();
            ProductCatalog.IsValidPlan(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanCorporate).Should().BeTrue();
            ProductCatalog.IsValidPlan(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanCustom).Should().BeTrue();
        }

        [Fact]
        public void ProductPlans_Returns_TerminalFrameworkPlans()
        {
            ProductCatalog.ProductPlans.Should().ContainKey(ProductCatalog.TerminalFramework);

            var plans = ProductCatalog.ProductPlans[ProductCatalog.TerminalFramework];
            plans.Should().BeEquivalentTo(new List<string>
            {
                ProductCatalog.TerminalPlanDemo,
                ProductCatalog.TerminalPlanSolo,
                ProductCatalog.TerminalPlanMicro,
                ProductCatalog.TerminalPlanSmb,
                ProductCatalog.TerminalPlanEnterprise,
                ProductCatalog.TerminalPlanCorporate,
                ProductCatalog.TerminalPlanCustom
            });

            plans.Count.Should().Be(7);
        }

        [Fact]
        public void Products_Returns_Correct()
        {
            ProductCatalog.Products.Count.Should().Be(1);

            ProductCatalog.Products.Should().ContainKey(ProductCatalog.TerminalFramework);
            ProductCatalog.Products[ProductCatalog.TerminalFramework].Should().Be("Cross-Platform Terminal Framework (OneImlx.Terminal)");
        }
    }
}
