package htmljsoupwalker;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.Writer;
import java.util.ArrayList;
import java.util.List;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Node;
import domwalker.DomApi;
import htmlwalker.ITag;
import htmlwalker.exception.HtmlWalkerException;

public class HtmlDomApi extends DomApi<Document>
{
	static HtmlDomApi Instance = new HtmlDomApi();

	private HtmlDomApi() { super(); }
	
	@Override
	public Object documentNode(Document dom) { return dom.ownerDocument(); }

	@Override
	public Object htmlElement(Document dom) { return dom.getElementsByTag("html").first(); }
	
	@Override
	public String html(Document dom) { return dom.outerHtml(); }

	@Override
	public Object createElement(Document dom, String name) { return dom.createElement(name); }

	@Override
	public Object createTextNode(Document dom, String text) { return dom.text(text); }

	@Override
	public Object createEntityNode(Document dom, String entity) { return dom.text(entity); }

	@Override
	public List<Object> getContent(Document dom, ITag adapter)
	{
		List<Object> content = new ArrayList<Object>();
		Node node = (Node)adapter.tag();
		for (int n = 0; n < node.childNodeSize(); n++)
			content.add(node.childNode(n));		
		return content;	
	}

	@Override
	public Document load(Document dom, String path) throws HtmlWalkerException
	{
		try
		{
			return Jsoup.parse(new File(path), "UTF-8");
		}
		catch (IOException e)
		{
			throw new HtmlWalkerException(e);
		}
	}

	@Override
	public Document loadHtml(Document dom, String html) throws HtmlWalkerException { return Jsoup.parse(html); }

	@Override
	public void save(Document dom, String path, String encoding) throws HtmlWalkerException
	{
		try (FileWriter writer = new FileWriter(path))
		{
			save(dom, writer);
		}
		catch (IOException e)
		{
			throw new HtmlWalkerException(e);
		}
	}

	@Override
	public void save(Document dom, Writer writer) throws HtmlWalkerException
	{
		try
		{
			writer.write(dom.html());
		}
		catch (IOException e)
		{
			throw new HtmlWalkerException(e);
		}
	}
}
