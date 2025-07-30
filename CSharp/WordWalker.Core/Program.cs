using Html5DomWalker;
using HtmlDocCleaner;
using HtmlWalker;

namespace WordWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmdLine = new CmdLine();
            if (cmdLine.Read(args))
            {
                if (cmdLine.Input.EndsWith(".docx"))
                {
                    var openXml = new OpenXml();
                    cmdLine.Input = openXml.ToHtml(cmdLine.Input);
                }

                var platform = new Html5DomPlatform();

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

                var walker = new JoinedWalker();
                walker.Walkers.Add(new TagTraceWalker());
                walker.Walkers.Add(new WordHtmlCleanerWalker(output as Html5DomDocument));

                walker.Visit(input.DocumentTag);
                output.Save(cmdLine.Output);
            }
        }
    }
}
