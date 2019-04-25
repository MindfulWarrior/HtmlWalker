using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlTest.Html5Dom
{
    [TestClass]
    public class Html5_01 : Html5DomCloneTest
    {

        public Html5_01() : base("w3schools/01") { }

        [TestMethod]
        public void THtml5_01_00() { DoTest(0); }

        [TestMethod]
        public void THtml5_01_01() { DoTest(1); }

        [TestMethod]
        public void THtml5_01_02() { DoTest(2); }

        [TestMethod]
        public void THtml5_01_03() { DoTest(3); }

        [TestMethod]
        public void THtml5_01_04() { DoTest(4); }

        [TestMethod]
        public void THtml5_01_05() { DoTest(5); }

        [TestMethod]
        public void THtml5_01_06() { DoTest(6); }

        [TestMethod]
        public void THtml5_01_07() { DoTest(7); }

        [TestMethod]
        public void THtml5_01_08() { DoTest(8); }

        [TestMethod]
        public void THtml5_01_09() { DoTest(9, new Options(Platform) { Formatted = false }); }

    }

}