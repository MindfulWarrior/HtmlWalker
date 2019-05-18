using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HtmlTest.Base
{
    public abstract class CloneWalker_Base : CloneTest
    {
        public CloneWalker_Base() : base("html", "Base") { }
        public CloneWalker_Base(string ext) : base(ext, "Base") { }


        public virtual void TUnsupported()
        {
            var html = @"<html><body><unsupported></unsupported></body></html>";
            var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
            var document = Platform.NewDocument();

            document.LoadHtml(html);

            try
            {
                walker.Visit(document.DocumentTag);
                Assert.Fail("Did not throw an exception");
            }
            catch (NotSupportedException)
            {
                // Test passes
            }
        }

        public virtual void TWalk()
        {
            var html = "<html><body><p>Hello, World!</p></body></html>";

            FileInfo testExpected = GetTestOutput("expected.path_load." + Ext);
            try
            {
                if (!testExpected.Exists)
                {
                    using var writer = new StreamWriter(testExpected.FullName);
                    writer.WriteLine(html);
                }

                var document = Platform.NewDocument(testExpected.FullName);
                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);

                if (walker.Output.Html.Replace(Environment.NewLine, "") != html)
                    Assert.Fail("Expected - [" + html + "] vs Out - [" + walker.Output.Html + "]");
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TLoadHtml()
        {
            var html = "<html><body><p>Hello, World!</p></body></html>";

            try
            {
                var document = Platform.NewDocument();
                document.LoadHtml(html);

                if (document.Html != html)
                    Assert.Fail("Expected - [" + html + "] vs Out - [" + document.Html + "]");
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TLoadPath()
        {
            var html = "<html><body><p>Hello, World!</p></body></html>";

            FileInfo testExpected = GetTestOutput("expected_load_path." + Ext);
            try
            {
                if (!testExpected.Exists)
                {
                    using var writer = new StreamWriter(testExpected.FullName);
                    writer.WriteLine(html);
                }

                var document = Platform.NewDocument();
                document.Load(testExpected.FullName);

                if (!Platform.IsXml)
                    html += Environment.NewLine;

                if (document.Html != html)
                    Assert.Fail("Expected - [" + html + "] vs Out - [" + document.Html + "]");
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TLoadHtmWalk()
        {
            var html = "<html><body><p>Hello, World!</p></body></html>";

            try
            {
                var document = Platform.NewDocument();
                document.LoadHtml(html);

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);

                if (walker.Output.Html != html)
                    Assert.Fail("Expected - [" + html + "] vs Out - [" + walker.Output.Html + "]");
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TLoadPathWalk()
        {
            var html = "<html><body><p>Hello, World!</p></body></html>";

            FileInfo testExpected = GetTestOutput("expected_load_path_walk." + Ext);
            try
            {
                if (!testExpected.Exists)
                {
                    using var writer = new StreamWriter(testExpected.FullName);
                    writer.WriteLine(html);
                }

                var document = Platform.NewDocument();
                document.Load(testExpected.FullName);

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);

                if (walker.Output.Html.Replace(Environment.NewLine, "") != html)
                    Assert.Fail("Expected - [" + html + "] vs Out - [" + walker.Output.Html + "]");
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TSavePath()
        {
            var html = "<html>  <body>    <p>Hello, World!</p>  </body></html>";

            try
            {
                FileInfo testOutput = GetTestOutput("output_save_path." + Ext);
                if (testOutput.Exists)
                    testOutput.Delete();

                var document = Platform.NewDocument();
                document.LoadHtml(html);

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);

                walker.Output.Save(testOutput.FullName);

                CompareToExpected(testOutput, html);
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TSaveTextWriter()
        {
            string html = "";
            if (Platform.IsXml)
                html += "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            html += "<html>  <body>    <p>Hello, World!</p>  </body></html>";

            try
            {
                FileInfo testOutput = GetTestOutput("output_save_writer." + Ext);
                if (testOutput.Exists)
                    testOutput.Delete();

                var document = Platform.NewDocument();
                document.LoadHtml(html);

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);

                using (var writer = new StreamWriter(testOutput.FullName))
                    walker.Output.Save(writer);

                CompareToExpected(testOutput, html);
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TEntityIsPreserved()
        {
            string hdr = "";
            if (Platform.IsXml)
                hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
            var html = "<html><body><p>&lsquo;Hello, World!&rsquo;</p></body></html>";

            try
            {
                var document = Platform.NewDocument();
                document.LoadHtml(hdr + html);

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);

                if (walker.Output.Html != html)
                    Assert.Fail("Expected - [" + html + "] vs Out - [" + walker.Output.Html + "]");
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TEntityIsPreservedSaved()
        {
            string hdr = "";
            if (Platform.IsXml)
                hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
            var html = "<html>  <body>    <p>&lsquo;Hello, World!&rsquo;</p>  </body></html>";

            try
            {
                FileInfo testOutput = GetTestOutput("output_entity." + Ext);
                if (testOutput.Exists)
                    testOutput.Delete();

                var document = Platform.NewDocument();
                document.LoadHtml(hdr + html);

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);
                walker.Output.Save(testOutput.FullName);

                CompareToExpected(testOutput, html);
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TEntityIsPreservedLoadSaved()
        {
            string hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
            var html = "<html><body><p>&lsquo;Hello, World!&rsquo;</p> </body></html>";

            var testExpected = GetTestOutput("expected_load_entity." + Ext);
            try
            {
                if (!testExpected.Exists)
                {
                    using var writer = new StreamWriter(testExpected.FullName);
                    if (Platform.IsXml)
                        writer.WriteLine(hdr);
                    writer.WriteLine(html);
                }

                var testOutput = GetTestOutput("output_load_entity." + Ext);
                if (testOutput.Exists)
                    testOutput.Delete();

                var document = Platform.NewDocument();
                document.Load(testExpected.FullName);

                if (!Platform.IsXml)
                    html += Environment.NewLine;

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);
                walker.Output.Save(testOutput.FullName);

                CompareToExpected(testOutput, testExpected);
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TNoEntityConversion()
        {
            string hdr = "";
            if (Platform.IsXml)
                hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
            var html = "<html><body><p>“Hello, World!”</p></body></html>";

            try
            {
                var document = Platform.NewDocument();
                document.LoadHtml(hdr + html);

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);

                if (walker.Output.Html != html)
                    Assert.Fail("Expected - [" + html + "] vs Out - [" + walker.Output.Html + "]");
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TNoEntityConversionSaved()
        {
            string hdr = "";
            if (Platform.IsXml)
                hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
            var html = "<html>  <body>    <p>“Hello, World!”</p>  </body></html>";

            try
            {
                FileInfo testOutput = GetTestOutput("output_noentity." + Ext);
                if (testOutput.Exists)
                    testOutput.Delete();

                var document = Platform.NewDocument();
                document.LoadHtml(hdr + html);

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);
                walker.Output.Save(testOutput.FullName);

                CompareToExpected(testOutput, html);
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TNoEntityConversionLoadSaved()
        {
            string hdr = "";
            if (Platform.IsXml)
                hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
            var html = "<html><body><p>“Hello, World!”</p></body></html>";

            FileInfo testExpected = GetTestOutput("expected_load_noentity." + Ext);
            try
            {
                if (!testExpected.Exists)
                {
                    using var writer = new StreamWriter(testExpected.FullName);
                    if (Platform.IsXml)
                        writer.WriteLine(hdr);
                    writer.WriteLine(html);
                }
                FileInfo testOutput = GetTestOutput("output_noentity." + Ext);
                if (testOutput.Exists)
                    testOutput.Delete();

                var document = Platform.NewDocument();
                document.LoadHtml(hdr + html);

                if (!Platform.IsXml)
                    html += Environment.NewLine;

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);
                walker.Output.Save(testOutput.FullName);

                CompareToExpected(testOutput, testExpected);
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }

        public virtual void TRemoveTag()
        {
            var html = "<html><body><p>Hello, World!</p><p>REMOVE THIS</p></body></html>";
            var expected = "<html><body><p>Hello, World!</p></body></html>";

            try
            {
                var document = Platform.NewDocument();
                document.LoadHtml(html);

                var walker = new CloneTestWalker(Platform, Platform.NewDocumentOptions());
                walker.Visit(document.DocumentTag);

                var body = walker.Output.DocumentTag.BodyTag;
                var removeThis = body.OwnedTags.ToList().Find(p => p.Name == "p" && p.OwnedText == "REMOVE THIS");
                body.OwnedTags.Remove(removeThis);

                if (walker.Output.Html != expected)
                    Assert.Fail("Expected - [" + expected + "] vs Out - [" + walker.Output.Html + "]");
            }
            catch (Exception e)
            {
                PrintStackTrace(e);
                Assert.Fail(e.Message);
            }
        }
    }
}
