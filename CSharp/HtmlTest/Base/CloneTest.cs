using Microsoft.XmlDiffPatch;
using System.IO;
using System.Xml;
using XhtmlXsd;

namespace HtmlTest.Base
{
    public abstract class CloneTest : BaseTest
    {
        protected readonly string Ext;

        public CloneTest() : this("html") { }

        public CloneTest(string ext) : base() => Ext = ext;

        protected CloneTest(string ext, string subFolder) : base(subFolder) => Ext = ext;

        protected override void CompareToExpected(
            FileInfo testOutput, FileInfo testExpected, bool ignoreWhitespace = true
        ) {
            bool pass = false;

            if (Platform.IsXml)
            {
                using XmlTextReader
                    output = new XmlTextReader(testOutput.Open(FileMode.Open, FileAccess.Read, FileShare.Read))
                        { XmlResolver = XhtmlEntityResolver.Instance },
                    expected = new XmlTextReader(testExpected.Open(FileMode.Open, FileAccess.Read, FileShare.Read))
                        { XmlResolver = XhtmlEntityResolver.Instance };

                XmlDiff xmldiff = new XmlDiff(
                    XmlDiffOptions.IgnoreNamespaces |
                    XmlDiffOptions.IgnorePrefixes |
                    XmlDiffOptions.IgnoreDtd |
                    XmlDiffOptions.IgnoreXmlDecl
                );

                pass = xmldiff.Compare(expected, output);
            }

            if (!pass)
                base.CompareToExpected(testOutput, testExpected);
        }

        public void DoTest(FileInfo testInput, FileInfo testOutput, FileInfo testExpected, TestOptions options)
        {
            TestWalker walker;
            if (!Platform.IsXml && options.Formatted && options.DocumentOptions.ProvideEol)
                walker = new FormattedCloneTestWalker(Platform, options.DocumentOptions);
            else
                walker = new CloneTestWalker(Platform, options.DocumentOptions);

            var document = Platform.NewDocument(testInput.FullName, options.DocumentOptions);
            walker.Visit(document.DocumentTag);

            if (testOutput.Exists)
                testOutput.Delete();

            walker.Output.Save(testOutput.FullName, document.Encoding);

            CompareToExpected(testOutput, testExpected);
        }

        public void DoTest(string inFile, string outFile, string expectedFile, TestOptions options)
        {
            var testInput = GetTestInput(inFile);
            var testOutput = GetTestOutput(outFile);
            var testExpected = GetTestExpected(expectedFile, testInput, options);
            DoTest(testInput, testOutput, testExpected, options);
        }
        protected void DoTest(TestOptions options)
            => DoTest("test." + Ext, "clone." + Ext, "expected." + Ext, options);

        protected void DoTest(string t, TestOptions options)
            => DoTest("test." + t + "." + Ext, "clone." + t + "." + Ext, "expected." + t + "." + Ext, options);

        protected void DoTest(int t, TestOptions options)
        {
            options.DocumentOptions.ProvideEol = false;
            DoTest(t.ToString(), options);
            options.DocumentOptions.ProvideEol = true;
            DoTest(t.ToString(), options);
        }

        protected void DoTest(int t) => DoTest(t, new TestOptions(Platform));
    }
}
