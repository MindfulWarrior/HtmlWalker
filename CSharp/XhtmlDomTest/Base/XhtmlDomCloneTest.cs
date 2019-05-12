using HtmlTest.Base;
using HtmlWalker.Platform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using XhtmlDomWalker;
using XhtmlXsd;

namespace HtmlTest.XhtmlDom
{
    public class XhtmlDomCloneTest : CloneTest
    {
        public XhtmlDomCloneTest() : base("xhtml") { }

        protected XhtmlDomCloneTest(string subfolder) : base("xhtml", subfolder) { }

        protected override WalkerPlatform Platform => XhtmlDomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, TestOptions options)
        {
            try
            {
                var document = XhtmlEntityResolver.CreateXmlDocument();
                document.Load(testInput.FullName);
                document.Save(expected.FullName);
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }
    }
}