/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Services
{
    [TestClass]
    public class IOHelperTests
    {
        [TestMethod]
        public void ExceptionTest()
        {
            Assert.ThrowsException<ArgumentException>(() => IOHelper.GetParent(""));
        }

        [TestMethod]
        public void GetParentTest()
        {
            Assert.AreEqual(@"C:\Users\pisuser2\AppData\Local\Programs", IOHelper.GetParent(@"C:\Users\pisuser2\AppData\Local\Programs\Opera"));

            Assert.AreEqual(@"C:\Users\pisuser2\AppData", IOHelper.GetParent(@"C:\Users\pisuser2\AppData\Local\Programs\Opera", 3));

            Assert.AreEqual(@"C:\Users", IOHelper.GetParent(@"C:\Users\pisuser2\AppData\Local\Programs\Opera", 5));
        }
    }
}
