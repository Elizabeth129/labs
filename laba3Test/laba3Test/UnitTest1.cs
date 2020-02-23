using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba3;

namespace laba3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
         public void TestSax1()
        {
            List<string> list = new List<string> { "asda", "asdava", "sdasd", "sad", "dasa" };
            string pattern = null;
            Assert.AreEqual(false, SAX.Contains(list, pattern));
        }
        [TestMethod]
        public void TestSax2()
        {
            List<string> list = new List<string> { null, "asdava", "sdasd", "sad", "dasa" };
            string pattern = "sad";
            Assert.AreEqual(true, SAX.Contains(list, pattern));
        }
    }
}
