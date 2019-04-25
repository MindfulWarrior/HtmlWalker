using Html5DomWalker;
using HtmlAgilityPack;
using HtmlTest.Base;
using HtmlWalker.Platform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HtmlTest.Html5Dom
{
    public class Html5DomCloneTest : CloneTest
    {
        public Html5DomCloneTest() : base("html", "Base") { }

        protected Html5DomCloneTest(string subFolder) : base("html", subFolder) { }

        protected override WalkerPlatform Platform => Html5DomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, Options options = null)
        {
            try
            {
                if (options == null)
                    options = new Options(Platform);

                if (options.Formatted)
                    testInput.CopyTo(expected.FullName);
                {
                    // TODO: Change expected files to keep entities
                    var document = new HtmlDocument();
                    document.Load(testInput.FullName);
                    document.Save(expected.FullName);
                }
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }
    }

}