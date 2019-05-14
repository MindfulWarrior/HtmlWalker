package xhtmldomwalker;

import java.util.Map;
import java.util.TreeMap;

import org.w3c.dom.Element;
import org.w3c.dom.NamedNodeMap;
import org.w3c.dom.Node;

import htmlwalker.ITag;
import htmlwalker.platform.ITagApi;
import htmlwalker.platform.WalkerPlatform;

class XhtmlDomTagApi implements ITagApi
{
	static XhtmlDomTagApi Instance = new XhtmlDomTagApi();

	private XhtmlDomTagApi() { }
	
	@Override
	public String name(Object tag)
	{
		Node node = (Node)tag;
		if (node.getNodeType() == Node.ELEMENT_NODE)
			return ((Element)node).getTagName();
		return node.getNodeName();
	}

	@Override
	public WalkerPlatform platform() { return XhtmlDomPlatform.theInstance; }

	@Override
	public Map<String, String> getAttributes(Object tag)
	{
		Node node = (Node)tag;
		Map<String, String> attrs = new TreeMap<String, String>(String.CASE_INSENSITIVE_ORDER);
		NamedNodeMap attributes = node.getAttributes();
		if (attributes != null)
		{
			for (int n = 0; n < attributes.getLength(); n++)
			{
				Node attr = attributes.item(n);
				attrs.put(attr.getNodeName(), attr.getNodeValue());
			}
		}
		return attrs;		
	}

	@Override
	public String getAttribute(Object tag, String attr)
	{
		Node node = (Node)tag;
		if (Node.ELEMENT_NODE == node.getNodeType())
			return ((Element)node).getAttribute(attr);
		return null;
	}

	@Override
	public void setAttribute(Object tag, String attr, String value)
	{
		Node node = ((Node)tag);
		if (Node.ELEMENT_NODE == node.getNodeType())
			((Element)node).setAttribute(attr, value);
	}

	@Override
	public String getText(Object tag) { return ((Node)tag).getTextContent(); }

	@Override
	public void setText(Object tag, String text) { ((Node)tag).setTextContent(text); }

	@Override
	public String getScript(Object tag) { return ((Node)tag).getTextContent(); }

	@Override
	public void setScript(Object tag, String script) { ((Node)tag).setTextContent(script); }

	@Override
	public void add(Object tag, ITag adapter)
	{
		Node node = (Node)tag;
		if (adapter.tag() instanceof Node)
			node.appendChild((Node)adapter.tag());
		// TODO: Do we still need
		//else if (adapter.tag() instanceof String)
		//	node.appendChild(this.tag.getOwnerDocument().createTextNode((String)adapter.tag()));
		else
			throw new UnsupportedOperationException();
	}

	@Override
	public void remove(Object tag, ITag adapter)
	{
		Node node = (Node)tag;
		if (adapter.tag() instanceof Node)
			node.removeChild((Node)adapter.tag());
		// TODO: Do we still need
		//else if (adapter.tag() instanceof String)
		//	node.setTextContent(null);
		else
			throw new UnsupportedOperationException();
	}

	@Override
	public String ownedText(Object tag)
	{
		// TODO try and make this different from getTextValue
		return ((Node)tag).getTextContent();
	}
}
