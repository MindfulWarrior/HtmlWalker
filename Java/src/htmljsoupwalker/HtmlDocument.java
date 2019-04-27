package htmljsoupwalker;

import org.jsoup.nodes.Document;

import domwalker.DomDocument;

class HtmlDocument extends DomDocument<HtmlFactory, HtmlDomApi, Document>
{
	HtmlDocument(Document dom, HtmlPlatform platform)
	{
		super(new HtmlFactory(dom, platform));
	}
}
