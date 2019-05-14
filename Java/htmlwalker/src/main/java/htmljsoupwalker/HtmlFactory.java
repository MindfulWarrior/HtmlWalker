package htmljsoupwalker;

import org.jsoup.nodes.Document;
import org.jsoup.nodes.Node;

import domwalker.DomFactory;
import htmlwalker.platform.ITagApi;

public class HtmlFactory extends DomFactory<HtmlDomApi, Document>
{
	public HtmlFactory(Document dom, HtmlPlatform platform)
	{
		// TODO: Use theInstance?
		super(HtmlDomApi.Instance, dom, platform);
	}

	@Override
	public ITagApi api() { return HtmlTagApi.Instance; }
	
	@Override
	public Object cloneTag(Object tag)
	{
		Node node = (Node)tag;
		if (node.nodeName() == "body")
			return dom.body();
		else if (node.nodeName() == "head")
			return dom.head();
		else if (node.nodeName() == "html")
			return dapi.htmlElement(dom);
		return node.shallowClone();
	}

	@Override
	public Object createBody() { return dom.body(); }

	@Override
	public Object createHead() { return dom.head(); }

	@Override
	public void close() { this.dom = null; }

}
