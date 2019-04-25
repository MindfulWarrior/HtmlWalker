using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlTest.Html5Dom
{
    [TestClass]

    public class Html5_05 : Html5DomCloneTest
    {

        public Html5_05() : base("w3schools/05") { }

        [TestMethod]
        public void THtml5_05_00() { DoTest(0); }

        [TestMethod]
        public void THtml5_05_01() { DoTest(1); }

        [TestMethod]
        public void THtml5_05_02() { DoTest(2); }

        [TestMethod]
        public void THtml5_05_03() { DoTest(3); }

        [TestMethod]
        public void THtml5_05_04() { DoTest(4); }

        [TestMethod]
        public void THtml5_05_05() { DoTest(5); }

    }

}
