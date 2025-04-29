/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using FluentAssertions;
using OneImlx.Shared.Infrastructure;
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
        public void GetPlanDisplayName_InvalidPlan_ThrowsErrorException()
        {
            var act = () => ProductCatalog.GetPlanDisplayName(ProductCatalog.TerminalFramework, "invalid_plan");
            act.Should().Throw<ErrorException>()
               .WithErrorCode("invalid_request")
               .WithErrorDescription($"The plan is not supported. product={ProductCatalog.TerminalFramework} plan=invalid_plan");
        }

        [Fact]
        public void GetPlanDisplayName_InvalidProductForValidPlan_ThrowsErrorException()
        {
            var act = () => ProductCatalog.GetPlanDisplayName("invalid_product", ProductCatalog.TerminalPlanSolo);
            act.Should().Throw<ErrorException>()
               .WithErrorCode("invalid_request")
               .WithErrorDescription($"The plan is not supported. product=invalid_product plan={ProductCatalog.TerminalPlanSolo}");
        }

        [Theory]
        [InlineData(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanDemo, "Demo")]
        [InlineData(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanSolo, "Solo")]
        [InlineData(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanMicro, "Micro")]
        [InlineData(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanSmb, "SMB")]
        [InlineData(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanEnterprise, "Enterprise")]
        [InlineData(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanCorporate, "Corporate")]
        [InlineData(ProductCatalog.TerminalFramework, ProductCatalog.TerminalPlanCustom, "Custom")]
        public void GetPlanDisplayName_ValidPlan_ReturnsDisplayName(string product, string plan, string expectedDisplayName)
        {
            var result = ProductCatalog.GetPlanDisplayName(product, plan);
            result.Should().Be(expectedDisplayName);
        }

        [Fact]
        public void GetProductDisplayName_InvalidProduct_ThrowsErrorException()
        {
            var act = () => ProductCatalog.GetProductDisplayName("invalid_product");
            act.Should().Throw<ErrorException>()
               .WithErrorCode("invalid_request")
               .WithErrorDescription("The product is not supported. product=invalid_product");
        }

        [Theory]
        [InlineData(ProductCatalog.TerminalFramework, "OneImlx.Terminal")]
        public void GetProductDisplayName_ValidProduct_ReturnsDisplayName(string product, string expectedDisplayName)
        {
            var result = ProductCatalog.GetProductDisplayName(product);
            result.Should().Be(expectedDisplayName);
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
