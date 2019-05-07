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

        protected void DoTest(string test)
        {
            var testInput = GetTestInput("test." + test + ".html");
            var expected = GetTestExpected("saved." + test + ".html", testInput, new Options(Platform) { AutoCreate = false});
            var testOutput = GetTestOutput("output." + test + ".html");
            Program.Main(new string[] { testInput.FullName, testOutput.FullName });
            CompareToExpected(testOutput, expected, false);
        }

        [TestMethod]
        public void Comment_01() => DoTest("comment.01");

        [TestMethod]
        public void Head_01() => DoTest("head.01");

        [TestMethod]
        public void Div_01() => DoTest("div.01");

        [TestMethod]
        public void Attribute_01() => DoTest("attribute.01");

        [TestMethod]
        public void Word_01() => DoTest("word.01");
    }
}
