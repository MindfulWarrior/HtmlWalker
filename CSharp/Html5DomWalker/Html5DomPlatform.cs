using HtmlAgilityPack;
using HtmlWalker;
using HtmlWalker.Platform;
using System.Text;

namespace Html5DomWalker
{
    public partial class Html5DomPlatform : WalkerPlatform
    {
        public class Options : IOptions
        {
            public bool AddDebuggingAttributes;
            public bool AutoCloseOnEnd;
            public bool CheckSyntax = true;
            public bool ComputeChecksum;
            public bool ExtractErrorSourceText;
            public bool FixNestedTags;
            public bool OutputAsXml;
            public bool OutputOptimizeAttributeValues;
            public bool OutputOriginalCase;
            public bool OutputUpperCase;
            public bool ReadEncoding = true;
            public bool UseIdAttribute = true;
            public bool WriteEmptyNodes;

            public string StopperNodeName;

            public Encoding DefaultStreamEncoding;
            public Encoding Encoding { get; set; }
            public bool ProvideEol { get; set; }
            public bool ConvertToEntities { get; set; }
        }

        public static readonly Html5DomPlatform Instance = new Html5DomPlatform();

        protected HtmlDocument CreateDom(object options)
        {
            var dom = new HtmlDocument();
            if (options != null)
            {
                var opts = (Options)options;
                dom.OptionAddDebuggingAttributes = opts.AddDebuggingAttributes;
                dom.OptionAutoCloseOnEnd = opts.AutoCloseOnEnd;
                dom.OptionCheckSyntax = opts.CheckSyntax;
                dom.OptionComputeChecksum = opts.ComputeChecksum;
                dom.OptionExtractErrorSourceText = opts.ExtractErrorSourceText;
                dom.OptionFixNestedTags = opts.FixNestedTags;
                dom.OptionOutputAsXml = opts.OutputAsXml;
                dom.OptionOutputOptimizeAttributeValues = opts.OutputOptimizeAttributeValues;
                dom.OptionOutputOriginalCase = opts.OutputOriginalCase;
                dom.OptionOutputUpperCase = opts.OutputUpperCase;
                dom.OptionReadEncoding = opts.ReadEncoding;
                dom.OptionUseIdAttribute = opts.UseIdAttribute;
                dom.OptionWriteEmptyNodes = opts.WriteEmptyNodes;

                if (opts.DefaultStreamEncoding != null)
                    dom.OptionDefaultStreamEncoding = opts.DefaultStreamEncoding;

                if (opts.StopperNodeName != null)
                    dom.OptionStopperNodeName = opts.StopperNodeName;
            }
            return dom;
        }

        public override string Name => "Html5Dom";

        public override bool IsXml => false;

        public override IOptions NewDocumentOptions() => new Options();

        public override WalkerDocument NewDocument(IOptions options = null)
        {
            var document = new Html5DomDocument(CreateDom(options), this);
            if (options != null)
            {
                if (options.Encoding != null)
                    document.Encoding = options.Encoding;
                document.ProvideEol = options.ProvideEol;
                document.ConvertToEntities = options.ConvertToEntities;
            }
            return document;
        }

        public override WalkerDocument NewDocument(DocumentTag adpater, IOptions options = null)
        {
            var tag = (HtmlNode)adpater.Tag;
            var document = new Html5DomDocument(CreateDom(options), this);
            if (options != null)
            {
                if (options.Encoding != null)
                    document.Encoding = options.Encoding;
                document.ProvideEol = options.ProvideEol;
                document.ConvertToEntities = options.ConvertToEntities;
            }
            return document.LoadHtml(tag.OuterHtml);
        }

        public override WalkerDocument NewDocument(string path, IOptions options = null)
        {
            var document = new Html5DomDocument(CreateDom(options), this);
            if (options != null)
            {
                if (options.Encoding != null)
                    document.Encoding = options.Encoding;
                document.ProvideEol = options.ProvideEol;
                document.ConvertToEntities = options.ConvertToEntities;
            }
            return document.Load(path);
        }

        protected override bool KeepEntities(bool attribute) => false;
    }
}
