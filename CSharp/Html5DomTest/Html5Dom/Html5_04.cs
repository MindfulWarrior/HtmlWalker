using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlTest.Html5Dom
{
    [TestClass]
    public class Html5_04 : Html5DomCloneTest
    {

        public Html5_04() : base("w3schools/04") { }

        [TestMethod]
        public void THtml5_04_00() { DoTest(0); }

        [TestMethod]
        public void THtml5_04_01() { DoTest(1); }

        [TestMethod]
        public void THtml5_04_02() { DoTest(2); }

        [TestMethod]
        public void THtml5_04_03() { DoTest(3); }

        [TestMethod]
        public void THtml5_04_04() { DoTest(4); }

        [TestMethod]
        public void THtml5_04_05() { DoTest(5); }

        [TestMethod]
        public void THtml5_04_06() { DoTest(6); }

    }

}
