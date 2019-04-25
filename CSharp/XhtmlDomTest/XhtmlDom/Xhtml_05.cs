using Microsoft.VisualStudio.TestTools.UnitTesting;

using HtmlTest.Base;

namespace HtmlTest.XhtmlDom
{
    [TestClass]
    public class Xhtml_05 : XhtmlDomCloneTest
    {
        public Xhtml_05() : base("w3schools/05") { }

        [TestMethod]
        public void TXhtml_05_00() { DoTest(0); }

        [TestMethod]
        public void TXhtml_05_01() { DoTest(1); }

        [TestMethod]
        public void TXhtml_05_02() { DoTest(2); }

        [TestMethod]
        public void TXhtml_05_03() { DoTest(3); }

        [TestMethod]
        public void TXhtml_05_04() { DoTest(4); }

        [TestMethod]
        public void TXhtml_05_05() { DoTest(5); }
    }
}