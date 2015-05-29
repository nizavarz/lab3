using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using lab3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateMenu()
        {
            Menu m = new Menu();
            Assert.IsNotNull(m);
        }
    }
}
