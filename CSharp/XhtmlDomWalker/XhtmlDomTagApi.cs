using HtmlWalker;
using HtmlWalker.Platform;
using System;
using System.Collections.Generic;
using System.Xml;

namespace XhtmlDomWalker
{
    public partial class XhtmlDomPlatform
    {
        internal class XhtmlDomTagApi : ITagApi
        {
            public static XhtmlDomTagApi Instance = new XhtmlDomTagApi();

            private XhtmlDomTagApi() { }

            public WalkerPlatform Platform => XhtmlDomPlatform.Instance;

            public string Name(object tag)
            {
                var node = ((XmlNode)tag);
                if (node.NodeType == XmlNodeType.EntityReference)
                    return "#entity";
                return node.LocalName;
            }

            public IDictionary<string, string> GetAttributes(object tag)
            {
                var node = ((XmlNode)tag);
                Dictionary<string, string> attrs = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                XmlAttributeCollection attributes = node.Attributes;
                if (attributes != null)
                {
                    for (int n = 0; n < attributes.Count; n++)
                    {
                        XmlNode attr = attributes.Item(n);
                        attrs.Add(attr.Name, attr.Value);
                    }
                }
                return attrs;
            }

            public string GetAttribute(object tag, string attr)
            {
                var node = ((XmlNode)tag);
                if (XmlNodeType.Element == node.NodeType)
                    return ((XmlElement)node).GetAttribute(attr);
                return null;
            }

            public void SetAttribute(object tag, string attr, string value)
            {
                var node = ((XmlNode)tag);
                if (XmlNodeType.Element == node.NodeType)
                    ((XmlElement)node).SetAttribute(attr, value);
            }

            public string GetText(object tag) => ((XmlNode)tag).InnerText;

            public void SetText(object tag, string value)
            {
                if (!((XmlNode)tag).IsReadOnly)
                    ((XmlNode)tag).InnerText = value;
            }

            public string GetScript(object tag) => ((XmlNode)tag).InnerXml;

            public void SetScript(object tag, string value) => ((XmlNode)tag).InnerXml = value;

            public string OwnedText(object tag) => ((XmlNode)tag).InnerText;

            public void Add(object tag, ITag adapter)
            {
                var parent = ((XmlNode)tag);
                if (adapter.Tag is string text)
                    parent.AppendChild(parent.OwnerDocument.CreateTextNode(text));
                else if (adapter.Tag is XmlNode node)
                {
                    if (node.NodeType == XmlNodeType.EntityReference)
                        node = parent.OwnerDocument.CreateEntityReference(node.Name);
                    parent.AppendChild(node);
                }
                else
                    throw new NotSupportedException();
            }

            public void Remove(object tag, ITag adapter)
            {
                var parent = ((XmlNode)tag);
                if (adapter.Tag is XmlNode node)
                    parent.RemoveChild(node);
                else
                    throw new NotSupportedException();
            }

            public void Insert(object tag, int index, ITag adapter)
            {
                var parent = ((XmlNode)tag);
                if (adapter.Tag is XmlNode node)
                    parent.InsertBefore(node, parent.ChildNodes[index]);
                else
                    throw new NotSupportedException();
            }
        }
    }
}
