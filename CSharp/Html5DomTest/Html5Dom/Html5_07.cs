using Microsoft.VisualStudio.TestTools.UnitTesting;

using HtmlTest.Base;

namespace HtmlTest.Html5Dom
{

    [TestClass]
    public class Html5_07 : Html5DomCloneTest
    {

        public Html5_07() : base("w3schools/07") { }

        [TestMethod]
        public void THtml5_07_00() { DoTest(0); }

        [TestMethod]
        public void THtml5_07_01() { DoTest(1); }

        [TestMethod]
        public void THtml5_07_02() { DoTest(2); }

        [TestMethod]
        public void THtml5_07_03() { DoTest(3); }

        [TestMethod]
        public void THtml5_07_04() { DoTest(4); }

        [TestMethod]
        public void THtml5_07_05() { DoTest(5); }

        [TestMethod]
        public void THtml5_07_06() { DoTest(6); }

    }

}