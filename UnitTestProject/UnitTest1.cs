using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WpfTest;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Employee e = new Employee();
            Assert.AreEqual(e.Add(1, 2), 3);
        }
    }
}
