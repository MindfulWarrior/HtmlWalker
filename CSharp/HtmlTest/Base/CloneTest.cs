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

        public CloneTest(string ext) : base()
        {
            Ext = ext;
        }

        protected CloneTest(string ext, string subFolder) : base(subFolder)
        {
            Ext = ext;
        }

        protected override void CompareToExpected(
            FileInfo testOutput, FileInfo testExpected, bool ignoreWhitespace = true
        ) {
            bool pass = false;

            if (Platform.IsXml)
            {
                using XmlTextReader output = new XmlTextReader(testOutput.Open(FileMode.Open, FileAccess.Read, FileShare.Read));
                using (XmlTextReader expected = new XmlTextReader(testExpected.Open(FileMode.Open, FileAccess.Read, FileShare.Read)))
                {
                    output.XmlResolver = XhtmlEntityResolver.Instance;
                    expected.XmlResolver = XhtmlEntityResolver.Instance;

                    XmlDiff xmldiff = new XmlDiff(
                        XmlDiffOptions.IgnoreNamespaces |
                        XmlDiffOptions.IgnorePrefixes |
                        XmlDiffOptions.IgnoreDtd |
                        XmlDiffOptions.IgnoreXmlDecl
                    );

                    pass = xmldiff.Compare(expected, output);
                }
            }

            if (!pass)
                base.CompareToExpected(testOutput, testExpected);
        }

        protected void DoTest(string inFile, string outFile, string expectedFile, Options options = null)
        {
            var testInput = GetTestInput(inFile);

            var walker = new TestWalker(Platform, (options?.Formatted ?? false) && options.DocumentOptions.ProvideEol);
            var document = Platform.NewDocument(testInput.FullName, options?.DocumentOptions);
            walker.Visit(document.DocumentTag);

            var testOutput = GetTestOutput(outFile);
            if (testOutput.Exists)
                testOutput.Delete();

            walker.Output.Save(testOutput.FullName);

            if (null != expectedFile)
                CompareToExpected(testOutput, testInput, expectedFile);
        }

        protected void DoTest(Options options = null)
        {
            DoTest("test." + Ext, "clone." + Ext, "expected." + Ext, options);
        }

        protected void DoTest(string t, Options options = null)
        {
            DoTest("test." + t + "." + Ext, "clone." + t + "." + Ext, "expected." + t + "." + Ext, options);
        }

        protected void DoTest(int t, Options options = null)
        {
            if (options == null)
                options = new Options(Platform);
            options.DocumentOptions.ProvideEol = false;
            DoTest(t.ToString(), options);
            options.DocumentOptions.ProvideEol = true;
            DoTest(t.ToString(), options);
        }
    }
}
