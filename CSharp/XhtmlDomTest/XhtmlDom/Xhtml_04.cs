using Microsoft.VisualStudio.TestTools.UnitTesting;

using HtmlTest.Base;

namespace HtmlTest.XhtmlDom
{
    [TestClass]
    public class Xhtml_04 : XhtmlDomCloneTest
    {
        public Xhtml_04() : base("w3schools/04") { }

        [TestMethod]
        public void TXhtml_04_00() { DoTest(0); }

        [TestMethod]
        public void TXhtml_04_01() { DoTest(1); }

        [TestMethod]
        public void TXhtml_04_02() { DoTest(2); }

        [TestMethod]
        public void TXhtml_04_03() { DoTest(3); }

        [TestMethod]
        public void TXhtml_04_04() { DoTest(4); }

        [TestMethod]
        public void TXhtml_04_05() { DoTest(5); }

        [TestMethod]
        public void TXhtml_04_06() { DoTest(6); }
    }
}