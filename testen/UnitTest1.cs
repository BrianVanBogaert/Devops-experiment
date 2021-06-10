using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace testen
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "OK";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                var result = "OK";
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
