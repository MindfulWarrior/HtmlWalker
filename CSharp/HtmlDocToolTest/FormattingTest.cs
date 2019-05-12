using Html5DomWalker;
using HtmlTest.Base;
using HtmlWalker.Platform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace HtmlDocToolTest
{
    [TestClass]
    public class FormattingTest : BaseTest
    {
        public FormattingTest() : base("Formatting") { }
        public FormattingTest(string subFolder) : base(subFolder) { }

        protected TestOptions CreateTestOptions()
        {
            var options = new TestOptions(Platform);
            options.DocumentOptions.ProvideEol = true;
            ((Html5DomPlatform.Options)options.DocumentOptions).WriteEmptyNodes = true;
            return options;
        }

        protected override WalkerPlatform Platform => Html5DomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, TestOptions options)
            => CreateFormattedClone(testInput.FullName, expected.FullName, options);

        protected void CreateFormattedClone(string pathInput, string pathOutput, TestOptions options)
        {
            var input = Platform.NewDocument(pathInput, options.DocumentOptions);
            var walker = new FormattedCloneTestWalker(Platform, options.DocumentOptions);
            walker.Visit(input.DocumentTag);
            walker.Output.Save(pathOutput, input.Encoding);
        }

        public void DoTest(FileInfo testInput, FileInfo testOutput, FileInfo expected, TestOptions options)
        {
            CreateFormattedClone(testInput.FullName, testOutput.FullName, options);
            CompareToExpected(testOutput, expected, false);
        }


        protected void DoTest(string test)
        {
            var options = CreateTestOptions();
            var testInput = GetTestInput("test." + test + ".html");
            var expected = GetTestExpected("saved." + test + ".html", testInput, options);
            var testOutput = GetTestOutput("output." + test + ".html");
            DoTest(testInput, testOutput, expected, options);
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
