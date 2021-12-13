/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class RbacPermsTests
    {
        [TestMethod]
        public void AllTest()
        {
            Assert.AreEqual(20, RbacPerms.All.Count());
        }

        [TestMethod]
        public void IsSubsetTest()
        {
            Assert.IsTrue(RbacPerms.IsSubset("ad,cl,cr,dt,sw,pb", "pb,sw"));
        }

        [TestMethod]
        public void JoinTest()
        {
            string[] perms = { "ad", "cl", "cr" };

            Assert.AreEqual("ad,cl,cr", RbacPerms.Join(perms));
        }

        // To be done later
        [TestMethod]
        public void PotentialInternalUserTest()
        {
        }

        [TestMethod]
        public void PotentialsExternalUserTest()
        {
            Assert.AreEqual("ad,cl,cr,dt,dw,ex,im,lt,lk,pt,pb,rd,rm,sw,ts,ul,ut,ud,up,vd", RbacPerms.PotentialsExternalUser("Owner"));

            Assert.AreEqual("ad,cl,cr,dt,dw,ex,im,lt,lk,pt,pb,rd,rm,sw,ts,ul,ut,ud,up,vd", RbacPerms.PotentialsExternalUser("Administrator"));

            Assert.AreEqual("ad,cl,cr,dt,dw,ex,im,lt,lk,pt,pb,rd,rm,sw,ts,ul,ut,ud,up,vd", RbacPerms.PotentialsExternalUser("Developer"));

            Assert.AreEqual("ad,cl,cr,dt,dw,ex,im,lt,lk,pt,pb,rd,rm,sw,ts,ul,ut,ud,up,vd", RbacPerms.PotentialsExternalUser("Expert"));

            Assert.AreEqual("ad,cr,im,lt,pt,pb,rd,sw,ts,ut,ud,up,vd", RbacPerms.PotentialsExternalUser("Contributor"));

            Assert.AreEqual("dw,ex,lt,pt,rd,sw,ts,ut,vd", RbacPerms.PotentialsExternalUser("Analyst"));

            Assert.AreEqual("ad,cr,lt,pt,rd,sw,ts,ut,vd", RbacPerms.PotentialsExternalUser("Support"));

            Assert.AreEqual("lt,pt,rd,sw,ut,vd", RbacPerms.PotentialsExternalUser("ReadOnly"));
        }

        [TestMethod]
        public void RbacPermsConstantsTest()
        {
            Assert.AreEqual("ad", RbacPerms.Add);

            Assert.AreEqual("cl", RbacPerms.Clear);

            Assert.AreEqual("cr", RbacPerms.Create);

            Assert.AreEqual("dt", RbacPerms.Delete);

            Assert.AreEqual("dw", RbacPerms.Download);

            Assert.AreEqual("ex", RbacPerms.Export);

            Assert.AreEqual("im", RbacPerms.Import);

            Assert.AreEqual("lt", RbacPerms.List);

            Assert.AreEqual("lk", RbacPerms.Lock);

            Assert.AreEqual("pt", RbacPerms.Protect);

            Assert.AreEqual("pb", RbacPerms.Publish);

            Assert.AreEqual("rd", RbacPerms.Read);

            Assert.AreEqual("rm", RbacPerms.Remove);

            Assert.AreEqual("sw", RbacPerms.Switch);

            Assert.AreEqual("ts", RbacPerms.Test);

            Assert.AreEqual("ul", RbacPerms.Unlock);

            Assert.AreEqual("ut", RbacPerms.Unprotect);

            Assert.AreEqual("ud", RbacPerms.Update);

            Assert.AreEqual("up", RbacPerms.Upload);

            Assert.AreEqual("vd", RbacPerms.Validate);
        }

        [TestMethod]
        public void SubscribedExternalUserTest()
        {
            Assert.AreEqual("dw,ex,lt,pt,rd,sw,ts,ut,vd", RbacPerms.SubscribedExternalUser("Analyst", "ad,cl,cr,dt,dw,ex,im,lt,lk,pt,pb,rd,rm,sw,ts,ul,ut,ud,up,vd"));

            Assert.AreEqual("ad,cr,lt,pt,rd,sw,ts,ut,vd", RbacPerms.SubscribedExternalUser("Support", "ad,cl,cr,dt,dw,ex,im,lt,lk,pt,pb,rd,rm,sw,ts,ul,ut,ud,up,vd"));
        }

        // To be done later
        [TestMethod]
        public void SubscribedInternalUserTest()
        {
        }
    }
}
