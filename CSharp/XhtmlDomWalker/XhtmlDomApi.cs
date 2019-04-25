using DomWalker;
using HtmlWalker;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace XhtmlDomWalker
{
    public class XhtmlDomApi : DomApi<XmlDocument>
    {
        public static XhtmlDomApi Instance = new XhtmlDomApi();
 
        private XhtmlDomApi() : base(){  }

        protected override object DocumentNode(XmlDocument dom) => dom;

        protected override object HtmlElement(XmlDocument dom) => dom.DocumentElement;

        protected override string Html(XmlDocument dom) => dom.DocumentElement.OuterXml;

        protected override object CreateElement(XmlDocument dom, string tag)
            => dom.CreateElement(tag);

        protected override object CreateTextNode(XmlDocument dom, string text)
            => dom.CreateTextNode(text);

        protected override object CreateEntityNode(XmlDocument dom, string entity)
        {
            var startIndex = entity.IndexOf('&') + 1;
            var length = entity.IndexOf(';') - startIndex;
            var name = entity.Substring(startIndex, length);
            return dom.CreateEntityReference(name);
        }

        protected override IList<object> GetContent(XmlDocument dom, ITag adapter)
        {
            var content = new List<object>();
            var nodes = ((XmlNode)adapter.Tag).ChildNodes;
            for (int n = 0; n < nodes.Count; n++) {
                XmlNode node = nodes.Item(n);
                if (
                    node.NodeType == XmlNodeType.Element ||
                    node.NodeType == XmlNodeType.Text ||
                    node.NodeType == XmlNodeType.EntityReference ||
                    node.NodeType == XmlNodeType.Comment
                )
                    content.Add(node);
            }
            return content;
        }

        protected override void Load(XmlDocument dom, string path) => dom.Load(path);

        protected override void Load(XmlDocument dom, TextReader reader) => dom.Load(reader);

        protected override void LoadHtml(XmlDocument dom, string html) => dom.LoadXml(html);

        // TODO: Add way to set Encoding for Xhtml
        protected override void Save(XmlDocument dom, string path, Encoding encoding) => dom.Save(path);

        protected override void Save(XmlDocument dom, TextWriter writer) => dom.Save(writer);
    }
}
