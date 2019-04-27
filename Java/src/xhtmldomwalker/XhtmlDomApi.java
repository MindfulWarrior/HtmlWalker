package xhtmldomwalker;

import java.io.FileWriter;
import java.io.IOException;
import java.io.StringReader;
import java.io.StringWriter;
import java.io.Writer;
import java.util.ArrayList;
import java.util.List;

import javax.xml.transform.TransformerException;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.InputSource;
import org.xml.sax.SAXException;

import domwalker.DomApi;
import htmlwalker.ITag;
import htmlwalker.exception.HtmlWalkerException;

public class XhtmlDomApi extends DomApi<Document>
{
	static XhtmlDomApi Instance = new XhtmlDomApi();

	private XhtmlDomApi() { super(); }

	@Override
	public Object documentNode(Document dom) { return dom; }
	
	@Override
	public Object htmlElement(Document dom)
	{
		Element element = dom.getDocumentElement();

		if (null == element)
			return null;
		
		if (element.getTagName().equalsIgnoreCase("html"))
			return element;

		return null;
	}

	@Override
	public String html(Document dom)
	{
       StringWriter writer = new StringWriter();
       try
       {
    	   save(dom, writer);
       }
	   catch (HtmlWalkerException e)
       {
			// TODO Auto-generated catch block
			e.printStackTrace();
       }
       return writer.toString();
	}

	@Override
	public Object createElement(Document dom, String name) { return dom.createElement(name); }

	@Override
	public Object createTextNode(Document dom, String text) { return dom.createTextNode(text); }

	@Override
	public Object createEntityNode(Document dom, String entity) { return dom.createEntityReference(entity); }

	@Override
	public List<Object> getContent(Document dom, ITag adapter)
	{
		List<Object> content = new ArrayList<Object>();
		
		NodeList nodes = null;
		if (adapter.tag() instanceof Element)
			nodes = ((Element)adapter.tag()).getChildNodes();
		else if (adapter.tag() instanceof Document)
			nodes = ((Document)adapter.tag()).getChildNodes();
		
		if (nodes != null)
		{
			for (int n = 0; n < nodes.getLength(); n++)
			{
				Node node = nodes.item(n);
				if (node.getNodeType() == Node.ELEMENT_NODE || node.getNodeType() == Node.TEXT_NODE || node.getNodeType() == Node.COMMENT_NODE)
					content.add(node);
			}
		}
		return content;	
	}
	
	@Override
	public Document load(Document dom, String path) throws HtmlWalkerException
	{
		try
		{
			return XhtmlDomPlatform.documentBuilder().parse(path);
		}
		catch (SAXException | IOException e)
		{
			throw new HtmlWalkerException(e);
		}		
	}

	@Override
	public Document loadHtml(Document dom, String html) throws HtmlWalkerException
	{
		try
		{
			StringReader reader = new StringReader(html);
			return XhtmlDomPlatform.documentBuilder().parse(new InputSource(reader));
		}
		catch (SAXException | IOException e)
		{
			throw new HtmlWalkerException(e);
		}
	}
	
	@Override
	public void save(Document dom, String path, String encoding) throws HtmlWalkerException
	{
		try
		{
			FileWriter writer = new FileWriter(path);
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
		DOMSource source = new DOMSource(dom);
		try
		{
			StreamResult result = new StreamResult(writer);
			XhtmlDomDocument.transformer().transform(source, result);
		}
		catch (TransformerException e)
		{
			throw new HtmlWalkerException(e);
		}				
	}
}
