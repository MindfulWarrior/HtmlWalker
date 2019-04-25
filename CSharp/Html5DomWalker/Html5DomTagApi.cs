using HtmlAgilityPack;
using HtmlWalker;
using HtmlWalker.Platform;
using System;
using System.Collections.Generic;

namespace Html5DomWalker
{
    public partial class Html5DomPlatform
    {
        internal class Html5DomTagApi : ITagApi
        {
            internal static Html5DomTagApi Instance = new Html5DomTagApi();

            private Html5DomTagApi() { }

            public WalkerPlatform Platform { get { return Html5DomPlatform.Instance; } }

            public string Name(object tag) => ((HtmlNode)tag).Name;

            public IDictionary<string, string> GetAttributes(object tag)
            {
                var node = ((HtmlNode)tag);
                var attrs = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                foreach (var attr in node.Attributes)
                    attrs.Add(attr.Name, attr.Value);
                return attrs;
            }

            public string GetAttribute(object tag, string attr) => ((HtmlNode)tag).GetAttributeValue(attr, null);

            public void SetAttribute(object tag, string attr, string value)
            {
                var node = ((HtmlNode)tag);
                if (null != value)
                    node.SetAttributeValue(attr, value);
                else
                    node.Attributes.Remove(attr);
            }

            public string GetText(object tag) => ((HtmlNode)tag).InnerText;

            public void SetText(object tag, string value)
            {
                if (!String.IsNullOrEmpty(value))
                {
                    var node = ((HtmlNode)tag);
                    switch (node.NodeType)
                    {
                        case HtmlNodeType.Text:
                            ((HtmlTextNode)node).Text = value;
                            break;
                        case HtmlNodeType.Comment:
                            ((HtmlCommentNode)node).Comment = value;
                            break;
                        case HtmlNodeType.Element:
                            node.AppendChild(HtmlTextNode.CreateNode(value));
                            break;
                        default:
                            throw new NotSupportedException(node.Name);
                    }
                }
            }

            public string GetScript(object tag) => ((HtmlNode)tag).InnerHtml;

            public void SetScript(object tag, string value)
            {
                var node = ((HtmlNode)tag);
                node.ChildNodes.Clear();
                if (value != null)
                {
                    string[] script = value.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    foreach (var line in script)
                        node.AppendChild(HtmlTextNode.CreateNode(line + Environment.NewLine));
                }
            }

            public string OwnedText(object tag) => ((HtmlNode)tag).InnerText;

            public void Add(object tag, ITag adapter)
            {
                var parent = ((HtmlNode)tag);
                if (adapter.Tag is HtmlNode node)
                    parent.AppendChild(node);
                else if (adapter.Tag is string str && !String.IsNullOrEmpty(str))
                    parent.AppendChild(HtmlTextNode.CreateNode(str));
                else
                    throw new NotSupportedException();
            }

            public void Remove(object tag, ITag adapter)
            {
                if (adapter.Tag is HtmlNode node)
                    node.Remove();
                else
                    throw new NotSupportedException();
            }

            public void Insert(object tag, int index, ITag adapter)
            {
                var parent = ((HtmlNode)tag);
                if (adapter.Tag is HtmlNode node)
                    parent.InsertBefore(node, parent.ChildNodes[index]);
                else
                    throw new NotSupportedException();
            }
        }
    }
}
