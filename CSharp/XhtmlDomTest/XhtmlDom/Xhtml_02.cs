using Microsoft.VisualStudio.TestTools.UnitTesting;

using HtmlTest.Base;

namespace HtmlTest.XhtmlDom
{
    [TestClass]
    public class Xhtml_02 : XhtmlDomCloneTest
    {
        public Xhtml_02() : base("w3schools/02") { }

        [TestMethod]
        public void TXhtml_02_00() { DoTest(0); }

        [TestMethod]
        public void TXhtml_02_01() { DoTest(1); }

        [TestMethod]
        public void TXhtml_02_02() { DoTest(2); }

        [TestMethod]
        public void TXhtml_02_03() { DoTest(3); }

        [TestMethod]
        public void TXhtml_02_04() { DoTest(4); }

        [TestMethod]
        public void TXhtml_02_05() { DoTest(5); }

        [TestMethod]
        public void TXhtml_02_06() { DoTest(6); }

        [TestMethod]
        public void TXhtml_02_07() { DoTest(7); }
    }
}