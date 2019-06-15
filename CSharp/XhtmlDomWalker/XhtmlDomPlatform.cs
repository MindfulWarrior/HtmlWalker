using HtmlWalker;
using HtmlWalker.Platform;
using System.Text;
using System.Xml;
using XhtmlXsd;

namespace XhtmlDomWalker
{
    public partial class XhtmlDomPlatform : WalkerPlatform
    {
        public class Options : IOptions
        {
            private Encoding defaultEncoding;
            private bool provideEol;
            private bool convertToEntities;

            public bool PreserveWhitespace;

            public Encoding Encoding { get => this.defaultEncoding; set => this.defaultEncoding = value; }
            public bool ProvideEol { get => this.provideEol; set => this.provideEol = value; }
            public bool ConvertToEntities { get => this.convertToEntities; set => this.convertToEntities = value; }
        }

        public static readonly XhtmlDomPlatform Instance = new XhtmlDomPlatform();

        private XmlDocument CreateDom(object options)
        {
            var dom = XhtmlEntityResolver.CreateXmlDocument();
            if (options != null)
            {
                var opts = (Options)options;
                dom.PreserveWhitespace = opts.PreserveWhitespace;
            }
            return dom;
        }

        public override string Name => "XhtmlDom";

        public override bool IsXml => true;

        public override IOptions NewDocumentOptions() => new Options();

        public override WalkerDocument NewDocument(IOptions options = null)
        {
            var dom = CreateDom(options);
            var document = new XhtmlDomDocument(dom, this);
            if (options != null)
            {
                document.ProvideEol = options.ProvideEol;
                document.ConvertToEntities = options.ConvertToEntities;
            }
            return document;
        }

        public override WalkerDocument NewDocument(DocumentTag adapter, IOptions options = null)
        {
            var tag = (XmlElement)adapter.Tag;
            var document = new XhtmlDomDocument(CreateDom(options), this);
            if (options != null)
            {
                document.ProvideEol = options.ProvideEol;
                document.ConvertToEntities = options.ConvertToEntities;
            }
            document.LoadHtml(tag.OuterXml);
            return document;
        }

        public override WalkerDocument NewDocument(string path, IOptions options = null)
        {
            var document = new XhtmlDomDocument(CreateDom(options), this);
            if (options != null)
            {
                document.ProvideEol = options.ProvideEol;
                document.ConvertToEntities = options.ConvertToEntities;
            }
            document.Load(path);
            return document;
        }

        protected override bool KeepEntities(bool attribute) => !attribute;
    }
}
