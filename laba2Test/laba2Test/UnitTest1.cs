using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba2;

namespace laba2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ParserTest1()
        {
            string s = "32/3";
            Parser pars = new Parser();
            int a = pars.result(s);
            Assert.AreEqual(a, 10);
        }
        [TestMethod]
        public void ParserTest2()
        {
            string s = "14*2";
            Parser pars = new Parser();
            int a = pars.result(s);
            Assert.AreEqual(a, 28);
        }

        [TestMethod]
        public void ParserTest3()
        {
            string s = "mmax(2,5,4)";
            Parser pars = new Parser();
            int a = pars.result(s);
            Assert.AreEqual(a, 5);
        }

        [TestMethod]  
        [ExpectedException(typeof(InvalidOperationException))]
        public void checkBracesTest()
        {
            string s = "12/4*2+8)";
            Parser pars = new Parser();
            int a = pars.result(s);
        }
    }
}
