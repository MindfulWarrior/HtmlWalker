using DomWalker;
using System.Xml;

namespace XhtmlDomWalker
{
    public partial class XhtmlDomPlatform
    {
        public class XhtmlDomDocument
            : DomDocument<XhtmlDomPlatform.XhtmlDomFactory, XhtmlDomApi, XmlDocument>
        {
            internal XhtmlDomDocument(XmlDocument dom, XhtmlDomPlatform platform)
                : base(new XhtmlDomPlatform.XhtmlDomFactory(dom, platform)) { }
        }
    }
}
