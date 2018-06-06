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
        [TestMethod]
        public void TestMethod3()
        {
            string text = "Hello Jenkins!";

            Assert.AreEqual("Hello Jenkins!", text);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string text = "Hello Git!";

            Assert.AreEqual("Hello Git!", text);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string text = "Hello GitHub!";

            Assert.AreEqual("Hello GitHub!", text);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string text = "Hello GitHub!";

            Assert.AreEqual("Hello GitHub!", text);
        }

    }
}
