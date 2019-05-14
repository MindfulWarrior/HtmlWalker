package xhtmldomwalker;

import org.w3c.dom.Document;
import org.w3c.dom.Node;

import domwalker.DomFactory;
import htmlwalker.platform.ITagApi;

public class XhtmlDomFactory extends DomFactory<XhtmlDomApi, Document>
{
	
	XhtmlDomFactory(Document dom, XhtmlDomPlatform platform) { super(XhtmlDomApi.Instance, dom, platform); }

	@Override
	public ITagApi api() { return XhtmlDomTagApi.Instance; }
	
	@Override
	public Object cloneTag(Object tag)
	{
		Node node = (Node)tag;
		if (node.getNodeName() == dom.getDocumentElement().getNodeName())
			return dom.getDocumentElement();
		else if (node.getNodeType() == Node.ELEMENT_NODE)
			return dom.createElement(node.getNodeName());
		else if (node.getNodeType() == Node.TEXT_NODE)
			return dom.createTextNode(node.getNodeValue());
		else if (node.getNodeType() == Node.ENTITY_NODE)
			return dom.createEntityReference(node.getNodeValue());
		else if (node.getNodeType() == Node.COMMENT_NODE)
			return dom.createComment(node.getNodeValue());
		throw new UnsupportedOperationException();
	}

	@Override
	public void close() { this.dom = null; }

}
