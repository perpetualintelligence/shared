/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System.Linq;

namespace PerpetualIntelligence.Protocols.Imlx
{
    [TestClass]
    public class UserRolesTests
    {
        [TestMethod]
        public void GetExternalRoleDescriptionsTest()
        {
            Assert.IsTrue(UserRoles.GetExternalRoleDescriptions().ContainsKey("Owner") && UserRoles.GetExternalRoleDescriptions().ContainsValue("Business or company account owner."));

            Assert.IsTrue(UserRoles.GetExternalRoleDescriptions().ContainsKey("Administrator") && UserRoles.GetExternalRoleDescriptions().ContainsValue("Best for business or company administrators."));

            Assert.IsTrue(UserRoles.GetExternalRoleDescriptions().ContainsKey("Expert") && UserRoles.GetExternalRoleDescriptions().ContainsValue("Best for product experts, product managers, product owners and UI/UX Design experts."));

            Assert.IsTrue(UserRoles.GetExternalRoleDescriptions().ContainsKey("Developer") && UserRoles.GetExternalRoleDescriptions().ContainsValue("Best for developers or people primarily using REST APIs and pi.api(); console."));

            Assert.IsTrue(UserRoles.GetExternalRoleDescriptions().ContainsKey("Contributor") && UserRoles.GetExternalRoleDescriptions().ContainsValue("Best for employees or external service providers who will author or modify service data."));

            Assert.IsTrue(UserRoles.GetExternalRoleDescriptions().ContainsKey("Analyst") && UserRoles.GetExternalRoleDescriptions().ContainsValue("Best for people or external agencies who analyze your service usage and service data."));

            Assert.IsTrue(UserRoles.GetExternalRoleDescriptions().ContainsKey("Support") && UserRoles.GetExternalRoleDescriptions().ContainsValue("Best for employees who regularly provide support or dispute resolution."));

            Assert.IsTrue(UserRoles.GetExternalRoleDescriptions().ContainsKey("ReadOnly") && UserRoles.GetExternalRoleDescriptions().ContainsValue("Best for people who need to view service data, but don't need to make any updates"));
        }

        [TestMethod]
        public void GetExternalRolePermissionDescriptionTest()
        {
            Assert.AreEqual("All permissions for owned business account, user accounts, subscriptions, subscribed services and payment settings.", UserRoles.GetExternalRolePermissionDescription("Owner"));

            Assert.AreEqual("All permissions for user accounts, subscriptions, subscribed services and payment settings.", UserRoles.GetExternalRolePermissionDescription("Administrator"));

            Assert.AreEqual("All permissions for subscribed services including usage and settings. Cannot access API Keys.", UserRoles.GetExternalRolePermissionDescription("Expert"));

            Assert.AreEqual("All permissions for subscribed services, API Keys and REST API. Cannot access usage, settings.", UserRoles.GetExternalRolePermissionDescription("Developer"));

            Assert.AreEqual("Author, view and edit permissions for subscribed services. Cannot delete. Cannot access API Keys, usage and settings.", UserRoles.GetExternalRolePermissionDescription("Contributor"));

            Assert.AreEqual("View, export permissions for subscribed services including usage and settings. Cannot create, edit, delete. Cannot access support, API Keys.", UserRoles.GetExternalRolePermissionDescription("Analyst"));

            Assert.AreEqual("View only permissions for subscribed services including usage and settings. Cannot create, edit, delete. Cannot access API Keys.", UserRoles.GetExternalRolePermissionDescription("Support"));

            Assert.AreEqual("View only permissions for subscribed services. Cannot create, edit, delete. Cannot access support, API Keys, usage and settings.", UserRoles.GetExternalRolePermissionDescription("ReadOnly"));

            Assert.AreEqual("Undefined role..", UserRoles.GetExternalRolePermissionDescription("TestRole"));
        }

        [TestMethod]
        public void GetExternalRolesTest()
        {
            string[] externalRoles = UserRoles.GetExternalRoles().ToArray();
            Assert.AreEqual(8, externalRoles.Count());

            Assert.AreEqual("Owner", externalRoles[0].ToString());

            Assert.AreEqual("Administrator", externalRoles[1].ToString());

            Assert.AreEqual("Expert", externalRoles[2].ToString());

            Assert.AreEqual("Developer", externalRoles[3].ToString());

            Assert.AreEqual("Contributor", externalRoles[4].ToString());

            Assert.AreEqual("Analyst", externalRoles[5].ToString());

            Assert.AreEqual("Support", externalRoles[6].ToString());

            Assert.AreEqual("ReadOnly", externalRoles[7].ToString());
        }

        [TestMethod]
        public void GetInternalRolesTest()
        {
            string[] internalRoles = UserRoles.GetInternalRoles().ToArray();
            Assert.AreEqual(10, internalRoles.Count());

            Assert.AreEqual("piUser", internalRoles[0].ToString());

            Assert.AreEqual("piEmployee", internalRoles[1].ToString());

            Assert.AreEqual("piDeveloper", internalRoles[2].ToString());

            Assert.AreEqual("piTester", internalRoles[3].ToString());

            Assert.AreEqual("piEngineer", internalRoles[4].ToString());

            Assert.AreEqual("piSupport", internalRoles[5].ToString());

            Assert.AreEqual("piBusinessAdmin", internalRoles[6].ToString());

            Assert.AreEqual("piOrgAdmin", internalRoles[7].ToString());

            Assert.AreEqual("piSupportAdmin", internalRoles[8].ToString());

            Assert.AreEqual("piPaymentAdmin", internalRoles[9].ToString());
        }

        [TestMethod]
        public void InternalUserRolesConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(UserRoles), 19);

            Assert.AreEqual("Administrator", UserRoles.Administrator);

            Assert.AreEqual("Analyst", UserRoles.Analyst);

            Assert.AreEqual("Contributor", UserRoles.Contributor);

            Assert.AreEqual("Developer", UserRoles.Developer);

            Assert.AreEqual("Expert", UserRoles.Expert);

            Assert.AreEqual("Owner", UserRoles.Owner);

            Assert.AreEqual("piBusinessAdmin", UserRoles.piBusinessAdminRole);

            Assert.AreEqual("piDeveloper", UserRoles.piDeveloperRole);

            Assert.AreEqual("piEmployee", UserRoles.piEmployeeRole);

            Assert.AreEqual("piEngineer", UserRoles.piEngineerRole);

            Assert.AreEqual("piOrgAdmin", UserRoles.piOrgAdminRole);

            Assert.AreEqual("piPaymentAdmin", UserRoles.piPaymentAdminRole);

            Assert.AreEqual("piSupportAdmin", UserRoles.piSupportAdminRole);

            Assert.AreEqual("piSupport", UserRoles.piSupportRole);

            Assert.AreEqual("piTester", UserRoles.piTesterRole);

            Assert.AreEqual("piUser", UserRoles.piUserRole);

            Assert.AreEqual(',', UserRoles.RbacSeperator);

            Assert.AreEqual("ReadOnly", UserRoles.ReadOnly);

            Assert.AreEqual("Support", UserRoles.Support);
        }

        [TestMethod]
        public void IsValidExternalTest()
        {
            Assert.IsFalse(UserRoles.IsValidExternal(""));

            Assert.IsFalse(UserRoles.IsValidExternal("TestExternal"));

            Assert.IsTrue(UserRoles.IsValidExternal("Owner"));
        }

        [TestMethod]
        public void IsValidInternalTest()
        {
            Assert.IsFalse(UserRoles.IsValidInternal(""));

            Assert.IsFalse(UserRoles.IsValidInternal("TestInternal"));

            Assert.IsTrue(UserRoles.IsValidInternal("piEngineer"));
        }
    }
}
