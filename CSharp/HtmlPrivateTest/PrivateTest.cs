using Html5DomWalker;
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

        protected static Encoding Encoding1252 = CodePagesEncodingProvider.Instance.GetEncoding(1252);

        public PrivateTest() : base(SUB_FOLDER) { }

        private readonly Html5DomCloneTest cloneTest = new Html5DomCloneTest(SUB_FOLDER);

        protected override WalkerPlatform Platform => Html5DomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, Options options = null)
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
        public void TPrivate(FileInfo testInput, string name)
        {
            // TODO: Handle other encodings
            var options = new Options(Platform) { AutoCreate = false, Formatted = false };
            options.DocumentOptions.Encoding = Encoding1252;
            ((Html5DomPlatform.Options)options.DocumentOptions).DefaultStreamEncoding = Encoding1252;

            // Clone Test
            var cloneExpected = cloneTest.GetTestExpected("expected." + name + ".clone.html", testInput, options);
            var cloneOutput = cloneTest.GetTestOutput("output." + name + ".clone.html");

            cloneTest.DoTest(testInput, cloneOutput, cloneExpected, options);
        }
    }
}
