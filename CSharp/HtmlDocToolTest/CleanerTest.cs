using System.Collections.Generic;
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

        public CleanerTest(string subFolder) : base(subFolder) { }

        protected override WalkerPlatform Platform => Html5DomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, TestOptions options)
            => RunProgram(testInput, expected, options);

        private void RunProgram(FileInfo testInput, FileInfo testOutput, TestOptions options)
        {
            var args = new List<string>() { testInput.FullName, testOutput.FullName };
            if (options.DocumentOptions.Encoding != null)
            {
                args.Add("--input-encoding");
                args.Add(options.DocumentOptions.Encoding.CodePage.ToString());
            }
            Program.Main(args.ToArray());
        }

        public void DoTest(FileInfo testInput, FileInfo testOutput, FileInfo expected, TestOptions options)
        {
            RunProgram(testInput, testOutput, options);
            CompareToExpected(testOutput, expected, false);
        }

        protected void DoTest(string test)
        {
            var options = new TestOptions(Platform) { AutoCreate = false };
            var testInput = GetTestInput("test." + test + ".html");
            var expected = GetTestExpected("saved." + test + ".html", testInput, options);
            var testOutput = GetTestOutput("output." + test + ".html");
            DoTest(testInput, testOutput, expected, options);
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
