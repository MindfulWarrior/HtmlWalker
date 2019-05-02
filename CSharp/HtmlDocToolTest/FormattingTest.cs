using Html5DomWalker;
using HtmlTest.Base;
using HtmlWalker;
using HtmlWalker.Platform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HtmlDocToolTest
{
    [TestClass]
    public class FormattingTest : BaseTest
    {
        public FormattingTest() : base("Formatting") { }

        protected override WalkerPlatform Platform => Html5DomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, Options options = null)
            => CreateFormattedClone(testInput.FullName, expected.FullName);

        protected void CreateFormattedClone(string pathInput, string pathOutput)
        {
            var options = Platform.NewDocumentOptions() as Html5DomPlatform.Options;
            options.ProvideEol = true;
            options.WriteEmptyNodes = true;

            var input = Platform.NewDocument(pathInput, options);
            var output = Platform.NewDocument();
            var walker = new FormattedCloneWalker(output);
            walker.Visit(input.DocumentTag);
            output.Save(pathOutput);
        }

        protected void doTest(string test)
        {
            var testInput = GetTestInput("test." + test + ".html");
            var expected = GetTestExpected("saved." + test + ".html", testInput, false);
            var testOutput = GetTestOutput("output." + test + ".html");
            CreateFormattedClone(testInput.FullName, testOutput.FullName);
            CompareToExpected(testOutput, expected, false);
        }

        [TestMethod]
        public void TFormat_01() => doTest("01");

        [TestMethod]
        public void TFormat_02() => doTest("02");

        [TestMethod]
        public void TFormat_03() => doTest("03");

        [TestMethod]
        public void TFormat_04() => doTest("04");
    }
}
