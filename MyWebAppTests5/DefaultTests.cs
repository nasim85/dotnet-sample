using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyWebApp.Tests
{
    [TestClass()]
    public class DefaultTests
    {
        [TestMethod()]
        public void addnumberTest()
        {
            Default df = new Default();
            int c = df.addnumber(2, 3);
            Assert.AreEqual(5, c);
        }

        [TestMethod()]
        public void dividenumberTest()
        {
            Default df = new Default();
            int c = df.dividenumber(3, 2);
            Assert.AreEqual(1, c);
        }
    }
}