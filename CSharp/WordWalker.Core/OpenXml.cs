using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WordWalker
{
    public class OpenXml
    {
        public OpenXml() { }

        public string ToHtml(string input)
        {
            Console.WriteLine(input);
            using (WordprocessingDocument wordDocument
                = WordprocessingDocument.Open(input, false))
            {
                var body = wordDocument.MainDocumentPart.Document.Body;
                foreach (var p in body.ChildElements)
                    foreach (var r in p.ChildElements)
                        foreach (var t in r.ChildElements)
                            Console.WriteLine(t.InnerXml);
            }

            var htmlFilePath = "tmp.html";
            var html = "<html><body><p>Hello, World!</p></body></html>";
            using var writer = new StreamWriter(htmlFilePath);
            writer.WriteLine(html);
            return htmlFilePath;
        }
    }
}
