using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlTest.Html5Dom
{

    [TestClass]
    public class Html5_10 : Html5DomCloneTest
    {
        public Html5_10() : base("w3schools/10") { }

        [TestMethod]
        public void THtml5_10_0() { DoTest(0); }

        [TestMethod]
        public void THtml5_10_01() { DoTest(1); }

        [TestMethod]
        public void THtml5_10_02() { DoTest(2); }

        [TestMethod]
        public void THtml5_10_03() { DoTest(3); }

        [TestMethod]
        public void THtml5_10_04() { DoTest(4); }

        [TestMethod]
        public void THtml5_10_05() { DoTest(5); }
    }

}
