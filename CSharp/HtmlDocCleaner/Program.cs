using Html5DomWalker;
using HtmlWalker.Platform;
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

                var inputOptions = platform.NewDocumentOptions();
                inputOptions.ProvideEol = true;
                inputOptions.ConvertToEntities = true;
                inputOptions.Encoding = cmdLine.EncodingInput;

                var outputOptions = platform.NewDocumentOptions();
                outputOptions.ProvideEol = true;
                outputOptions.ConvertToEntities = true;
                outputOptions.Encoding = cmdLine.EncodingOutput;

                var input = platform.NewDocument(cmdLine.Input, inputOptions);
                var output = platform.NewDocument(outputOptions);
                var walker = new DocCleanerWalker(output);
                walker.Visit(input.DocumentTag);
                output.Save(cmdLine.Output);
            }
        }
    }
}
