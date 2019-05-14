package htmljsoupwalker;

import java.util.List;
import java.util.Map;
import java.util.TreeMap;

import org.jsoup.nodes.Attribute;
import org.jsoup.nodes.Attributes;
import org.jsoup.nodes.BooleanAttribute;
import org.jsoup.nodes.DataNode;
import org.jsoup.nodes.Element;
import org.jsoup.nodes.Node;
import org.jsoup.nodes.TextNode;

import htmlwalker.ITag;
import htmlwalker.platform.ITagApi;
import htmlwalker.platform.WalkerPlatform;

class HtmlTagApi implements ITagApi
{
	static HtmlTagApi Instance = new HtmlTagApi();

	private HtmlTagApi() { }

	@Override
	public String name(Object tag)
	{
		Node node = (Node)tag;
		if (node instanceof Element)
			return ((Element)node).tagName();
		// TODO: Make use of #doctype instead of treating as a comment
		else if (node.nodeName() == "#doctype")
			return "#comment";
		return node.nodeName();
	}

	@Override
	public WalkerPlatform platform() { return HtmlPlatform.theInstance; }

	@Override
	public Map<String, String> getAttributes(Object tag)
	{
		var node = (Node)tag;
		var attrs = new TreeMap<String, String>(String.CASE_INSENSITIVE_ORDER);
		var attributes = node.attributes().asList();
		for (Attribute attr : attributes)
		{
			// TODO: Handle Boolean attributes better.
			if (attr instanceof BooleanAttribute)
				attrs.put(attr.getKey(), null);
			else
				attrs.put(attr.getKey(), attr.getValue());
		}
		return attrs;		
	}

	@Override
	public String getAttribute(Object tag, String attr)
	{
		Node node = (Node)tag;
		if (node.hasAttr(attr))
			return node.attr(attr);
		return null;
	}

	// TODO: Add way to remove attribute
	@Override
	public void setAttribute(Object tag, String attr, String value)
	{
		if (value == null && tag instanceof Element)
			((Element) tag).attr(attr, true);
		else
			((Node)tag).attr(attr, value);
	}

	@Override
	public String getText(Object tag)
	{
		if (tag instanceof Element)
			return ((Element)tag).text();
		else if (tag instanceof TextNode)
			return ((TextNode)tag).text();
		return ((Node)tag).outerHtml();
	}

	@Override
	public void setText(Object tag, String text)
	{
		if (text == null || text.isEmpty())
			return;

		if (tag instanceof TextNode)
			((TextNode)tag).text(text);
		else if (tag instanceof Element)
			((Element)tag).appendText(text);
	}

	@Override
	public String getScript(Object tag)
	{
		String script = null;		
		Element scriptTag = (Element)tag;
		
		List<DataNode> nodes = scriptTag.dataNodes();
		if (!nodes.isEmpty())
		{
			script = nodes.get(0).toString();
			for (int n = 1; n < nodes.size(); n++)
				script += "\n" + nodes.get(n).toString();
		}

		return script;
	}

	@Override
	public void setScript(Object tag, String script)
	{
		Element scriptTag = (Element)tag;
		while (!scriptTag.dataNodes().isEmpty())
			scriptTag.dataNodes().get(0).remove();
		
		if (null != script)
		{
			String[] css = script.split(System.lineSeparator());
			for (int n = 0; n < css.length; n++)
				scriptTag.appendChild(new DataNode(css[n] + System.lineSeparator()));
		}
	}

	@Override
	public void add(Object tag, ITag adapter)
	{
		if (tag instanceof Element)
		{
			Element element = (Element)tag;
			if (adapter.tag() instanceof Node)
				element.appendChild((Node)adapter.tag());
			else
				throw new UnsupportedOperationException();			
		}
	}

	@Override
	public void remove(Object tag, ITag adapter)
	{
		if (adapter.tag() instanceof Node)
			((Node)adapter.tag()).remove();
		else
			throw new UnsupportedOperationException();
	}

	@Override
	public String ownedText(Object tag)
	{
		if (tag instanceof Element)
			return ((Element)tag).ownText();
		return getText(tag);
	}
}
