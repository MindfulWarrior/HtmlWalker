using Microsoft.VisualStudio.TestTools.UnitTesting;

using HtmlTest.Base;

namespace HtmlTest.XhtmlDom
{
    [TestClass]
    public class Xhtml_07 : XhtmlDomCloneTest
    {
        public Xhtml_07() : base("w3schools/07") { }

        [TestMethod]
        public void TXhtml_07_00() { DoTest(0); }

        [TestMethod]
        public void TXhtml_07_01() { DoTest(1); }

        [TestMethod]
        public void TXhtml_07_02() { DoTest(2); }

        [TestMethod]
        public void TXhtml_07_03() { DoTest(3); }

        [TestMethod]
        public void TXhtml_07_04() { DoTest(4); }

        [TestMethod]
        public void TXhtml_07_05() { DoTest(5); }

        [TestMethod]
        public void TXhtml_07_06() { DoTest(6); }
    }
}