using System.IO;
using Html5DomWalker;
using HtmlDocCleaner;
using HtmlTest.Base;
using HtmlWalker.Platform;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HtmlDocToolTest
{
    [TestClass]
    public class CleanerTest : BaseTest
    {
        public CleanerTest() : base("Cleaner") { }

        protected override WalkerPlatform Platform => Html5DomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, Options options = null)
            => Program.Main(new string[] { testInput.FullName, expected.FullName });

        protected void doTest(string test)
        {
            var testInput = GetTestInput("test." + test + ".html");
            var expected = GetTestExpected("saved." + test + ".html", testInput, false);
            var testOutput = GetTestOutput("output." + test + ".html");
            Program.Main(new string[] { testInput.FullName, testOutput.FullName });
            CompareToExpected(testOutput, expected, false);
        }

        [TestMethod]
        public void Comment_01() => doTest("comment.01");

        [TestMethod]
        public void Head_01() => doTest("head.01");

        [TestMethod]
        public void Div_01() => doTest("div.01");

        [TestMethod]
        public void Attribute_01() => doTest("attribute.01");

        [TestMethod]
        public void Word_01() => doTest("word.01");
    }
}
