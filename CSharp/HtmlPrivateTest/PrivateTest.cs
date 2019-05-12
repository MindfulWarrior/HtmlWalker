using Html5DomWalker;
using HtmlDocToolTest;
using HtmlTest.Base;
using HtmlTest.Html5Dom;
using HtmlWalker.Platform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HtmlPrivateTest
{
    [TestClass]
    public class PrivateTest : BaseTest
    {
        protected const string SUB_FOLDER = "Private";

        protected static DirectoryInfo PrivateDirectory
            = new DirectoryInfo(TestFolder + Path.DirectorySeparatorChar + SUB_FOLDER);

        public PrivateTest() : base(SUB_FOLDER) { }

        private readonly Html5DomCloneTest cloneTest = new Html5DomCloneTest(SUB_FOLDER);
        private readonly FormattingTest formattingTest = new FormattingTest(SUB_FOLDER);
        private readonly CleanerTest cleanerTest = new CleanerTest(SUB_FOLDER);

        private TestOptions privateOptions = null;

        protected TestOptions PrivateOptions
        {
            get
            {
                if (privateOptions == null)
                {
                    // TODO: Handle other encodings
                    privateOptions = new TestOptions(Platform) { AutoCreate = false };
                    privateOptions.DocumentOptions.Encoding = CodePagesEncodingProvider.Instance.GetEncoding(1252);
                    privateOptions.DocumentOptions.ProvideEol = true;
                    ((Html5DomPlatform.Options)privateOptions.DocumentOptions).WriteEmptyNodes = true;
                }
                return privateOptions;
            }
        }

        protected override WalkerPlatform Platform => Html5DomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, TestOptions options)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<object[]> AllInFolder()
        {
            foreach (var testInput in PrivateDirectory.GetFiles("test.*.html"))
            {
                var parts = testInput.Name.Split(".");
                var name = string.Empty;
                for (int n = 1; n < parts.Length - 1; n++)
                {
                    var part = parts[n];
                    if (!string.IsNullOrEmpty(name))
                        name += ".";
                    name += part;
                }
                if (!string.IsNullOrEmpty(name))
                    yield return new object[] { testInput, name };
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(AllInFolder), DynamicDataSourceType.Method)]
        public void TCloneAll(FileInfo testInput, string name)
        {
            var options = PrivateOptions;

            var cloneExpected = cloneTest.GetTestExpected("expected." + name + ".clone.html", testInput, options);
            var cloneOutput = cloneTest.GetTestOutput("output." + name + ".clone.html");

            cloneTest.DoTest(testInput, cloneOutput, cloneExpected, options);
        }

        [DataTestMethod]
        [DynamicData(nameof(AllInFolder), DynamicDataSourceType.Method)]
        public void TFormatAll(FileInfo testInput, string name)
        {
            var options = PrivateOptions;

            var formattedExpected = formattingTest.GetTestExpected("expected." + name + ".formatted.html", testInput, options);
            var formattedOutput = formattingTest.GetTestOutput("output." + name + ".formatted.html");

            formattingTest.DoTest(testInput, formattedOutput, formattedExpected, options);
        }

        [DataTestMethod]
        [DynamicData(nameof(AllInFolder), DynamicDataSourceType.Method)]
        public void TCleanAll(FileInfo testInput, string name)
        {
            var options = PrivateOptions;

            var cleanerExpected = cleanerTest.GetTestExpected("expected." + name + ".cleaner.html", testInput, options);
            var cleanerOutput = cleanerTest.GetTestOutput("output." + name + ".cleaner.html");

            cleanerTest.DoTest(testInput, cleanerOutput, cleanerExpected, options);
        }
    }
}
