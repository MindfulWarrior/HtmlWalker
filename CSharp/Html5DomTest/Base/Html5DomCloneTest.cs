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

        public Html5DomCloneTest(string subFolder) : base("html", subFolder) { }

        protected override WalkerPlatform Platform => Html5DomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, Options options = null)
        {
            try
            {
                if (options?.Formatted ?? false)
                    testInput.CopyTo(expected.FullName);
                else
                {
                    // TODO: Change expected files to keep entities
                    var document = new HtmlDocument();
                    var opts = options?.DocumentOptions as Html5DomPlatform.Options;
                    if (opts != null)
                    {
                        if (opts.DefaultStreamEncoding != null)
                            document.OptionDefaultStreamEncoding = opts.DefaultStreamEncoding;
                    }

                    document.Load(testInput.FullName);
                    document.Save(expected.FullName, document.Encoding);
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