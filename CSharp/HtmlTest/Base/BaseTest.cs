using HtmlWalker.Platform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HtmlTest.Base
{
    [TestClass]
    public abstract class BaseTest
    {
        protected class Options
        {
            public readonly WalkerPlatform.IOptions DocumentOptions;

            public bool Formatted = true;

            public Options(WalkerPlatform platform)
            {
                DocumentOptions = platform.NewDocumentOptions();
            }
        }

        public void PrintStackTrace(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }

        private readonly DirectoryInfo input;
        private readonly DirectoryInfo output;

        protected string TestFolder => "../../../../Test";
        protected string OutFolder => "../../../../Test";

        protected abstract WalkerPlatform Platform { get; }

        protected abstract void CreateExpected(FileInfo expected, FileInfo testInput, Options options = null);

        public BaseTest()
        {
            this.input = new DirectoryInfo(TestFolder);
            this.output = new DirectoryInfo(OutFolder);
        }

        protected BaseTest(string subFolder)
        {
            if (null == subFolder)
            {
                this.input = new DirectoryInfo(TestFolder);
                this.output = new DirectoryInfo(OutFolder);
            }
            else
            {
                this.input = new DirectoryInfo(TestFolder + Path.DirectorySeparatorChar + subFolder);
                this.output = new DirectoryInfo(OutFolder + Path.DirectorySeparatorChar + subFolder);
            }
        }

        [TestMethod]
        public virtual void TConfirmTestFolder()
        {
            try
            {
                Assert.IsTrue(this.input.Exists, this.input.FullName + " does not exist");
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public virtual void TConfirmOutFolder()
        {
            try
            {
                Assert.IsTrue(this.output.Exists, this.output.FullName + " does not exist");
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        protected virtual string GetTestPath(string filename)
        {
            string path = null;

            try
            {
                path = this.input.FullName + Path.DirectorySeparatorChar + filename;
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }

            return path;
        }

        protected virtual string GetOutPath(string filename)
        {
            string path = null;

            try
            {
                path = this.output.FullName + Path.DirectorySeparatorChar + filename;
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }

            return path;
        }

        protected FileInfo GetTestInput(string filename)
        {
            return new FileInfo(GetTestPath(filename));
        }

        protected FileInfo GetTestOutput(string filename)
        {
            return new FileInfo(GetOutPath(filename));
        }

        protected FileInfo GetTestExpected(string filename, FileInfo testInput, bool autoCreate = true)
        {
            var outPath = GetOutPath(filename);
            var expected = new FileInfo(outPath);
            if (!expected.Exists)
            {
                CreateExpected(expected, testInput);
                Assert.IsTrue(File.Exists(GetOutPath(filename)), filename + " did not exists and could not be created.");
                if (!autoCreate)
                    Assert.Inconclusive(filename + " had to be created. Rerun test.");
            }
            return expected;
        }

        private string ReadNextLine(TextReader reader, bool ignoreWhitespace)
        {
            string line = reader.ReadLine();
            if (ignoreWhitespace)
            {
                while (null != line && line.Trim().Length == 0)
                    line = reader.ReadLine();
            }
            return line;
        }

        protected bool CompareLines(string expected, string output, bool ignoreWhitespace = true)
        {
            bool match = true;

            string eLine = expected;
            string oLine = output;

            if (ignoreWhitespace)
            {
                eLine = eLine.Trim();
                oLine = oLine.Trim();
            }

            int ePos = 0;
            int oPos = 0;

            while (match && ePos < eLine.Length && oPos < oLine.Length)
            {
                if (ignoreWhitespace)
                {
                    while (Char.IsWhiteSpace(eLine[ePos]) && ePos < eLine.Length)
                        ePos++;

                    while (Char.IsWhiteSpace(oLine[oPos]) && oPos < oLine.Length)
                        oPos++;
                }

                match = eLine[ePos] == oLine[oPos];

                ePos++;
                oPos++;
            }

            if (match)
                match = ePos == eLine.Length && oPos == oLine.Length;

            return match;
        }

        protected void CompareToExpected(
            FileInfo testOutput, FileInfo testInput, string expectedFile, bool ignoreWhitespace = true
        ) {
            FileInfo testExpected = GetTestExpected(expectedFile, testInput);
            CompareToExpected(testOutput, testExpected, ignoreWhitespace);
        }

        protected virtual void CompareToExpected(
            FileInfo testOutput, FileInfo testExpected, bool ignoreWhitespace = true
        ) {
            string failure = null;
            try
            {
                using TextReader output = new StreamReader(testOutput.Open(FileMode.Open, FileAccess.Read, FileShare.Read));
                using (TextReader expected = new StreamReader(testExpected.Open(FileMode.Open, FileAccess.Read, FileShare.Read)))
                {
                    string outputLine = output.ReadLine();
                    if (testOutput.Extension == ".html" || testOutput.Extension == ".htm")
                    {
                        // First line is declarations
                        while (!outputLine.Contains("<html"))
                            outputLine = output.ReadLine();
                        outputLine = outputLine.Substring(outputLine.IndexOf("<html"));
                    }

                    string expectedLine = expected.ReadLine();
                    if (testExpected.Extension == ".html" || testExpected.Extension == ".htm")
                    {
                        // First line is declarations
                        while (!expectedLine.Contains("<html"))
                            expectedLine = expected.ReadLine();
                        expectedLine = expectedLine.Substring(outputLine.IndexOf("<html"));
                    }

                    if (null != outputLine && null != expectedLine)
                    {
                        while (null != outputLine && null != expectedLine && null == failure)
                        {
                            if (!CompareLines(expectedLine, outputLine, ignoreWhitespace))
                                failure = "Expected - [" + expectedLine + "] vs Out - [" + outputLine + "]";
                            outputLine = ReadNextLine(output, ignoreWhitespace);
                            expectedLine = ReadNextLine(expected, ignoreWhitespace);
                        }
                    }
                    else
                    {
                        failure = "Nothing to test";
                    }

                    if ((null != outputLine || null != expectedLine) && null == failure)
                        failure = "One file is larger";
                }
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                failure = e.Message;
            }

            if (null != failure)
                Assert.Fail(Platform.Name + " : " + failure);
        }

        protected void CompareToExpected(FileInfo testOutput, string expected)
        {
            string output = "";
            using (var reader = new StreamReader(testOutput.OpenRead()))
            {
                while (!reader.EndOfStream)
                    output += reader.ReadLine();
            }

            if (expected != output)
                Assert.Fail("Expected - [" + expected + "] vs Out - [" + output + "]");
        }
    }
}
