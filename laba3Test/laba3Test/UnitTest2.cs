using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Laba3;

namespace laba3Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestDOM1()
        {
            string s = " asDa";
            string expected = " asDa";
            Assert.AreEqual(expected, DOM.UpperCaseFirst(s));
        }
        [TestMethod]
        public void TestDOM2()
        {
            string s = "asDa";
            string expected = "AsDa";
            Assert.AreEqual(expected, DOM.UpperCaseFirst(s));
        }
        [TestMethod]
        public void TestDOM3()
        {
            string s = null;
            string expected = "";
            Assert.AreEqual(expected, DOM.UpperCaseFirst(s));
        }

    }
}
