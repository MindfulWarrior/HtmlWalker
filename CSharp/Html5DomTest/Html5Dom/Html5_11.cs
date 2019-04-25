using Microsoft.VisualStudio.TestTools.UnitTesting;

using HtmlTest.Base;

namespace HtmlTest.Html5Dom
{

    [TestClass]
    public class Html5_11 : Html5DomCloneTest
    {
        public Html5_11() : base("w3schools/11") { }

        [TestMethod]
        public void THtml5_11_0() { DoTest(0); }

        [TestMethod]
        public void THtml5_11_01() { DoTest(1); }

        [TestMethod]
        public void THtml5_11_02() { DoTest(2); }

        [TestMethod]
        public void THtml5_11_03() { DoTest(3); }

        [TestMethod]
        public void THtml5_11_04() { DoTest(4); }

        [TestMethod]
        public void THtml5_11_05() { DoTest(5); }

        [TestMethod]
        public void THtml5_11_06() { DoTest(6); }

        [TestMethod]
        public void THtml5_11_07() { DoTest(7); }

        [TestMethod]
        public void THtml5_11_08() { DoTest(8, new Options(Platform) { Formatted = false }); }

        [TestMethod]
        public void THtml5_11_09() { DoTest(9); }

        [TestMethod]
        public void THtml5_11_10() { DoTest(10); }

        [TestMethod]
        public void THtml5_11_11() { DoTest(11); }

        [TestMethod]
        public void THtml5_11_12() { DoTest(12); }

        [TestMethod]
        public void THtml5_11_13() { DoTest(13); }

        [TestMethod]
        public void THtml5_11_14() { DoTest(14); }

        [TestMethod]
        public void THtml5_11_15() { DoTest(15); }

        [TestMethod]
        public void THtml5_11_16() { DoTest(16); }
    }

}