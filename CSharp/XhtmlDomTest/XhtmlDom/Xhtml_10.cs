using Microsoft.VisualStudio.TestTools.UnitTesting;

using HtmlTest.Base;

namespace HtmlTest.XhtmlDom
{
    [TestClass]
    public class Xhtml_10 : XhtmlDomCloneTest
    {
        public Xhtml_10() : base("w3schools/10") { }

        [TestMethod]
        public void TXhtml_10_00() { DoTest(0); }

        [TestMethod]
        public void TXhtml_10_01() { DoTest(1); }

        [TestMethod]
        public void TXhtml_10_02() { DoTest(2); }

        [TestMethod]
        public void TXhtml_10_03() { DoTest(3); }

        [TestMethod]
        public void TXhtml_10_04() { DoTest(4); }

        [TestMethod]
        public void TXhtml_10_05() { DoTest(5); }
    }
}