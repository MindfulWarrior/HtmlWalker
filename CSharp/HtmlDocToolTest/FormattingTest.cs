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
            var walker = new FormattedCloneTestWalker(Platform);
            walker.Visit(input.DocumentTag);
            walker.Output.Save(pathOutput);
        }

        protected void DoTest(string test)
        {
            var testInput = GetTestInput("test." + test + ".html");
            var expected = GetTestExpected("saved." + test + ".html", testInput, new Options(Platform) { AutoCreate = false});
            var testOutput = GetTestOutput("output." + test + ".html");
            CreateFormattedClone(testInput.FullName, testOutput.FullName);
            CompareToExpected(testOutput, expected, false);
        }

        [TestMethod]
        public void TFormat_01() => DoTest("01");

        [TestMethod]
        public void TFormat_02() => DoTest("02");

        [TestMethod]
        public void TFormat_03() => DoTest("03");

        [TestMethod]
        public void TFormat_04() => DoTest("04");
    }
}
