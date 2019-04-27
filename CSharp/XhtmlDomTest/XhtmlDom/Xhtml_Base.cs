using HtmlTest.Base;
using HtmlWalker.Platform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using XhtmlDomWalker;
using XhtmlXsd;

namespace HtmlTest.XhtmlDom.Base
{
    [TestClass]
    public class Xhtml_Base : CloneWalker_Base
    {
        public Xhtml_Base() : base("xhtml") { }

        protected override WalkerPlatform Platform => XhtmlDomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, Options options = null)
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

        [TestMethod]
        public override void TWalk()
        {
            base.TWalk();
        }

        [TestMethod]
        public override void TUnsupported()
        {
            base.TUnsupported();
        }

        [TestMethod]
        public override void TLoadHtml()
        {
            base.TLoadHtml();
        }

        [TestMethod]
        public override void TLoadPath()
        {
            base.TLoadPath();
        }

        [TestMethod]
        public override void TLoadHtmWalk()
        {
            base.TLoadHtmWalk();
        }

        [TestMethod]
        public override void TLoadPathWalk()
        {
            base.TLoadPathWalk();
        }

        [TestMethod]
        public override void TSavePath()
        {
            base.TSavePath();
        }

        [TestMethod]
        public override void TSaveTextWriter()
        {
            base.TSaveTextWriter();
        }

        [TestMethod]
        public override void TEntityIsPreserved()
        {
            base.TEntityIsPreserved();
        }

        [TestMethod]
        public override void TEntityIsPreservedSaved()
        {
            base.TEntityIsPreservedSaved();
        }

        [TestMethod]
        public override void TEntityIsPreservedLoadSaved()
        {
            base.TEntityIsPreservedLoadSaved();
        }

        [TestMethod]
        public override void TRemoveTag()
        {
            base.TRemoveTag();
        }
    }
}
