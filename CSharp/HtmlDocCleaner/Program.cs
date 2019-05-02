using Html5DomWalker;
using HtmlWalker.Platform;
using System;
using System.Collections.Generic;
using System.Text;
using XhtmlDomWalker;

namespace HtmlDocCleaner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cmdLine = new CmdLine();
            if (cmdLine.Read(args))
            {
                WalkerPlatform platform;
                if (cmdLine.IsXhtml)
                    platform = new XhtmlDomPlatform();
                else
                    platform = new Html5DomPlatform();

                var options = platform.NewDocumentOptions();
                options.ProvideEol = true;

                var input = platform.NewDocument(cmdLine.Input, options);
                var output = platform.NewDocument();
                var walker = new DocCleanerWalker(output);
                walker.Visit(input.DocumentTag);
                output.Save(cmdLine.Output);
            }
        }
    }
}
