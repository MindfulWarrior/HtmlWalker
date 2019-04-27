using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlTest.XhtmlDom
{
    [TestClass]
    public class Xhtml_09 : XhtmlDomCloneTest
    {
        public Xhtml_09() : base("w3schools/09") { }

        [TestMethod]
        public void TXhtml_09_0() { DoTest(0); }

        [TestMethod]
        public void TXhtml_09_01() { DoTest(1); }

        [TestMethod]
        public void TXhtml_09_02() { DoTest(2); }

        [TestMethod]
        public void TXhtml_09_03() { DoTest(3); }
    }
}