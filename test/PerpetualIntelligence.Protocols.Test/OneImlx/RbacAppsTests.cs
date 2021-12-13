/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System.Linq;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class RbacAppsTests
    {
        [TestMethod]
        public void AllTest()
        {
            Assert.AreEqual(19, RbacApps.All.Count());
        }

        [TestMethod]
        public void ExternalFreeTest()
        {
            Assert.AreEqual(11, RbacApps.ExternalFree.Count());
        }

        [TestMethod]
        public void ExternalPaidTest()
        {
            Assert.AreEqual(6, RbacApps.ExternalPaid.Count());
        }

        [TestMethod]
        public void ExternalTest()
        {
            Assert.AreEqual(17, RbacApps.External.Count());
        }

        [TestMethod]
        public void InternalTest()
        {
            Assert.AreEqual(2, RbacApps.Internal.Count());
        }

        [TestMethod]
        public void IsSubsetTest()
        {
            Assert.IsTrue(RbacApps.IsSubset("bd,ap,tm,sw,ct,db", "ap,db"));
        }

        [TestMethod]
        public void JoinTest()
        {
            string[] apps = { "ap", "bd", "tm" };

            Assert.AreEqual("ap,bd,tm", RbacApps.Join(apps));
        }

        [TestMethod]
        public void OrgAdminTest()
        {
            Assert.AreEqual(7, RbacApps.OrgAdmin.Count());
        }

        // To be done later
        [TestMethod]
        public void PotentialInternalUserTest()
        {
        }

        [TestMethod]
        public void PotentialsExternalUserValidTest()
        {
            Assert.AreEqual("bd,ba,ap,ct,db,dv,id,li,ml,pm,st,su,sp,sw,tm,ug,ua", RbacApps.PotentialsExternalUser("Owner"));

            Assert.AreEqual("bd,ap,ct,db,dv,id,li,ml,pm,st,su,sp,sw,tm,ug,ua", RbacApps.PotentialsExternalUser("Administrator"));

            Assert.AreEqual("bd,ap,ct,db,dv,id,li,ml,sp,sw,ua", RbacApps.PotentialsExternalUser("Developer"));

            Assert.AreEqual("bd,ap,ct,db,id,li,ml,st,sp,sw,ug,ua", RbacApps.PotentialsExternalUser("Expert"));

            Assert.AreEqual("bd,ap,ct,db,id,li,ml,sp,sw,ua", RbacApps.PotentialsExternalUser("Contributor"));

            Assert.AreEqual("bd,ap,ct,db,id,li,ml,sw,ug,ua", RbacApps.PotentialsExternalUser("Analyst"));

            Assert.AreEqual("bd,ap,ct,db,id,li,ml,st,sp,sw,ug,ua", RbacApps.PotentialsExternalUser("Support"));

            Assert.AreEqual("bd,ap,ct,db,id,li,ml,sw,ua", RbacApps.PotentialsExternalUser("ReadOnly"));
        }

        [TestMethod]
        public void RbacAppConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(RbacApps), 20);

            Assert.AreEqual("ap", RbacApps.Apps);

            Assert.AreEqual("bd", RbacApps.Branding);

            Assert.AreEqual("ct", RbacApps.Customers);

            Assert.AreEqual("db", RbacApps.Dashboard);

            Assert.AreEqual("dv", RbacApps.Developer);

            Assert.AreEqual("id", RbacApps.Identity);

            Assert.AreEqual("li", RbacApps.Licensing);

            Assert.AreEqual("ml", RbacApps.Multilanguage);

            Assert.AreEqual("pm", RbacApps.Payment);

            Assert.AreEqual("ba", RbacApps.PiAccount);

            Assert.AreEqual("pisd", RbacApps.PiInternalStripeData);

            Assert.AreEqual("pivm", RbacApps.PiInternalVirtualMachines);

            Assert.AreEqual("st", RbacApps.Settings);

            Assert.AreEqual("su", RbacApps.Subscriptions);

            Assert.AreEqual("sp", RbacApps.Support);

            Assert.AreEqual("sw", RbacApps.Switch);

            Assert.AreEqual("tm", RbacApps.Team);

            Assert.AreEqual("ug", RbacApps.Usage);

            Assert.AreEqual("ua", RbacApps.UserAccount);

            Assert.AreEqual("vu", RbacApps.Vault);
        }

        [TestMethod]
        public void SubscribedExternalUserTest()
        {
            Assert.AreEqual("bd,ap,ct,db,id,li,ml,sw,ua", RbacApps.SubscribedExternalUser("ReadOnly", "bd,ba,ap,ct,db,dv,id,li,ml,pm,st,su,sp,sw,tm,ug,ua"));

            Assert.AreEqual("bd,ap,ct,db,id,li,ml,st,sp,sw,ug,ua", RbacApps.SubscribedExternalUser("Support", "bd,ba,ap,ct,db,dv,id,li,ml,pm,st,su,sp,sw,tm,ug,ua"));
        }

        // To be done later
        [TestMethod]
        public void SubscribedInternalUserTest()
        {
        }
    }
}
