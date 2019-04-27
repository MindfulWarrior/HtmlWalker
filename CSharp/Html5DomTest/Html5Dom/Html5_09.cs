using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlTest.Html5Dom
{

    [TestClass]
    public class Html5_09 : Html5DomCloneTest
    {

        public Html5_09() : base("w3schools/09") { }

        [TestMethod]
        public void THtml5_09_0() { DoTest(0); }

        [TestMethod]
        public void THtml5_09_01() { DoTest(1, new Options(Platform) { Formatted = false }); }

        [TestMethod]
        public void THtml5_09_02() { DoTest(2); }

        [TestMethod]
        public void THtml5_09_03() { DoTest(3); }

    }

}