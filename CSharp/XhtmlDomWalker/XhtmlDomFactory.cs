using DomWalker;
using System.Xml;
using HtmlWalker.Platform;

namespace XhtmlDomWalker
{
    public partial class XhtmlDomPlatform
    {
        public class XhtmlDomFactory : DomFactory<XhtmlDomApi, XmlDocument>
        {
            internal XhtmlDomFactory(XmlDocument dom, XhtmlDomPlatform platform)
                : base(XhtmlDomApi.Instance, dom, platform) { }

            protected override ITagApi Api => XhtmlDomTagApi.Instance;

            protected override object CloneTag(object tag)
            {
                var xml = tag as XmlNode;
                return Dom.CreateNode(xml.NodeType, xml.Name, xml.NamespaceURI);
            }

            public override void Close() => Dom = null;
        }
    }
}