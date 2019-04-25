using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using HtmlWalker.Platform;
using System;

namespace HtmlTest.Base
{
    [TestClass]
    public class CloneTest_Base : CloneTest
    {
        public CloneTest_Base() : base("html", "Base") { }

        protected override WalkerPlatform Platform => throw new NotSupportedException();

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, Options options = null) { }

        [TestMethod]
        public void TEmptyLines()
        {
            if (!CompareLines("", ""))
                Assert.Fail("Empty lines don't match");
        }

        [TestMethod]
        public void TSkipWhitespace()
        {
            if (!CompareLines(" x xx", "xx x "))
                Assert.Fail("Whitespace used to compare");
        }

        [TestMethod]
        public void TDifferentLengths0()
        {
            if (CompareLines("xxx", "xxxx"))
                Assert.Fail("Lines of different lenght match");
        }

        [TestMethod]
        public void TDifferentLengths1()
        {
            if (CompareLines("x xx", "xxxx"))
                Assert.Fail("Whitespace used for length");
        }
    }
}
