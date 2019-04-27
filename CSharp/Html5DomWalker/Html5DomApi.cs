using DomWalker;
using HtmlAgilityPack;
using HtmlWalker;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Html5DomWalker
{
    public class Html5DomApi : DomApi<HtmlDocument>
    {
        internal static Html5DomApi Instance = new Html5DomApi();

        private Html5DomApi() : base() { }

        protected override object DocumentNode(HtmlDocument dom)
            => dom.DocumentNode;

        protected override object HtmlElement(HtmlDocument dom)
            => dom.DocumentNode.Element("html");

        protected override string Html(HtmlDocument dom)
            => dom.DocumentNode.OuterHtml;

        protected override object CreateElement(HtmlDocument dom, string tag)
            => dom.CreateElement(tag);

        protected override object CreateTextNode(HtmlDocument dom, string text)
            => dom.CreateTextNode(text);

        protected override object CreateEntityNode(HtmlDocument dom, string entity)
            => dom.CreateTextNode(entity);

        protected override IList<object> GetContent(HtmlDocument dom, ITag adapter)
        {
            var content = new List<object>();
            var node = (HtmlNode)adapter.Tag;
            foreach (var child in node.ChildNodes)
            {
                if (
                    child.NodeType == HtmlNodeType.Element ||
                    child.NodeType == HtmlNodeType.Text ||
                    child.NodeType == HtmlNodeType.Comment
                )
                    content.Add(child);
            }
            return content;
        }

        protected override void Load(HtmlDocument dom, string path) => dom.Load(path);

        protected override void Load(HtmlDocument dom, TextReader reader) => dom.Load(reader);

        protected override void LoadHtml(HtmlDocument dom, string html) => dom.LoadHtml(html);

        protected override void Save(HtmlDocument dom, string path, Encoding encoding)
        {
            if (encoding == null)
                dom.Save(path);
            else
                dom.Save(path, encoding);
        }

        protected override void Save(HtmlDocument dom, TextWriter writer) => dom.Save(writer);
    }
}
