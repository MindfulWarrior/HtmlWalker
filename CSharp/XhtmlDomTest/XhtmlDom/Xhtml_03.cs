using Microsoft.VisualStudio.TestTools.UnitTesting;

using HtmlTest.Base;

namespace HtmlTest.XhtmlDom
{
    [TestClass]
    public class Xhtml_03 : XhtmlDomCloneTest
    {
        public Xhtml_03() : base("w3schools/03") { }

        [TestMethod]
        public void TXhtml_03_00() { DoTest(0); }

        [TestMethod]
        public void TXhtml_03_01() { DoTest(1); }

        [TestMethod]
        public void TXhtml_03_02() { DoTest(2); }

        [TestMethod]
        public void TXhtml_03_03() { DoTest(3); }

        [TestMethod]
        public void TXhtml_03_04() { DoTest(4); }

        [TestMethod]
        public void TXhtml_03_05() { DoTest(5); }

        [TestMethod]
        public void TXhtml_03_06() { DoTest(6); }

        [TestMethod]
        public void TXhtml_03_07() { DoTest(7); }

        [TestMethod]
        public void TXhtml_03_08() { DoTest(8); }

        [TestMethod]
        public void TXhtml_03_09() { DoTest(9); }

        [TestMethod]
        public void TXhtml_03_10() { DoTest(10); }
    }
}