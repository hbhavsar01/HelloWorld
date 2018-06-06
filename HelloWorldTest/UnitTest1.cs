using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string text = "Hello World!";

            Assert.AreEqual("Hello World!", text);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string text = "Hello World";

            Assert.AreEqual("Hello World", text);
        }
    }
}
