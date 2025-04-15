/*
    Copyright © 2019-2025 Perpetual Intelligence L.L.C. All rights reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System.Collections.Generic;

namespace OneImlx.Shared.Licensing
{
    /// <summary>
    /// The unified product catalog.
    /// </summary>
    public sealed class ProductCatalog
    {
        /// <summary>
        /// Determines whether the specified plan is valid for the specified product.
        /// </summary>
        /// <param name="product">The product URN.</param>
        /// <param name="plan">The license plan URN.</param>
        /// <returns><c>true</c> if the plan is valid for the product; otherwise, <c>false</c>.</returns>
        public static bool IsValidPlan(string product, string plan)
        {
            return ProductPlans.TryGetValue(product, out var plans) && plans.Contains(plan);
        }

        /// <summary>
        /// The URN for the <c>OneImlx.Terminal</c> framework product.
        /// </summary>
        public const string TerminalFramework = "urn:oneimlx:terminal";

        /// <summary>
        /// The corporate plan for <see cref="TerminalFramework"/>.
        /// </summary>
        public const string TerminalPlanCorporate = "urn:oneimlx:terminal:plan:corporate";

        /// <summary>
        /// The custom plan for <see cref="TerminalFramework"/>.
        /// </summary>
        public const string TerminalPlanCustom = "urn:oneimlx:terminal:plan:custom";

        /// <summary>
        /// The demo plan for <see cref="TerminalFramework"/>.
        /// </summary>
        public const string TerminalPlanDemo = "urn:oneimlx:terminal:plan:demo";

        /// <summary>
        /// The enterprise plan for <see cref="TerminalFramework"/>.
        /// </summary>
        public const string TerminalPlanEnterprise = "urn:oneimlx:terminal:plan:enterprise";

        /// <summary>
        /// The micro plan for <see cref="TerminalFramework"/>.
        /// </summary>
        public const string TerminalPlanMicro = "urn:oneimlx:terminal:plan:micro";

        /// <summary>
        /// The SMB plan for <see cref="TerminalFramework"/>.
        /// </summary>
        public const string TerminalPlanSmb = "urn:oneimlx:terminal:plan:smb";

        /// <summary>
        /// The solo plan for <see cref="TerminalFramework"/>.
        /// </summary>
        public const string TerminalPlanSolo = "urn:oneimlx:terminal:plan:solo";

        /// <summary>
        /// A mapping of products to their available license plans.
        /// </summary>
        public static readonly Dictionary<string, List<string>> ProductPlans = new()
        {
            {
                TerminalFramework, new List<string>
                {
                    TerminalPlanDemo,
                    TerminalPlanSolo,
                    TerminalPlanMicro,
                    TerminalPlanSmb,
                    TerminalPlanEnterprise,
                    TerminalPlanCorporate,
                    TerminalPlanCustom
                }
            }
        };

        /// <summary>
        /// A mapping of product URNs to their human-readable names.
        /// </summary>
        public static readonly Dictionary<string, string> Products = new()
        {
            { TerminalFramework, "Cross-Platform Terminal Framework (OneImlx.Terminal)" }
        };
    }
}
