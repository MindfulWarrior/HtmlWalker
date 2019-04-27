package xhtmldomwalker;

import java.io.IOException;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

import org.w3c.dom.Document;
import org.xml.sax.SAXException;

import htmlwalker.*;
import htmlwalker.exception.*;
import htmlwalker.platform.*;
import xhtmlxsd.XhtmlEntityResolver;

public class XhtmlDomPlatform extends WalkerPlatform
{
	public static final String DOCTYPE_PUBLIC = "-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd";
	
	private static final Lock lock = new ReentrantLock();
	private static DocumentBuilderFactory dbfactory = null;
	private static DocumentBuilder builder = null;
	
	public static class Options implements IOptions
	{
		public Options() { }

		@Override
		public boolean getProvideEol()
		{
			// TODO Auto-generated method stub
			return false;
		}

		@Override
		public void setProvideEol(boolean flag)
		{
			// TODO Auto-generated method stub
			
		}

		@Override
		public boolean getConvertToEntities()
		{
			// TODO Auto-generated method stub
			return false;
		}

		@Override
		public void setConvertToEntities(boolean flag)
		{
			// TODO Auto-generated method stub
			
		}

		@Override
		public String getEncoding()
		{
			// TODO Auto-generated method stub
			return null;
		}

		@Override
		public void setEncoding(String encoding)
		{
			// TODO Auto-generated method stub
			
		}
	}
	
	public static DocumentBuilder documentBuilder()
	{
		if (null == dbfactory || null == builder)
		{
			lock.lock();
			if (null == dbfactory)
				dbfactory =  DocumentBuilderFactory.newInstance();
			
			if (null == builder)
			{
				try
				{
					builder = dbfactory.newDocumentBuilder();
					builder.setEntityResolver(XhtmlEntityResolver.theInstance);
				}
				catch (ParserConfigurationException e)
				{
					e.printStackTrace();
				}
			}
			lock.unlock();
		}
		return builder; 
	}

	public static final WalkerPlatform theInstance = new XhtmlDomPlatform();

	private XhtmlDomPlatform() { super(); }

	@Override
	protected boolean keepEntities(boolean attribute) { return !attribute; }
	
	@Override
	public String name() { return "XhtmlDom"; }

	@Override
	public WalkerDocument newDocument(IOptions options)
	{
		Document doc = documentBuilder().newDocument();
		doc.appendChild(doc.createElement("html"));
		XhtmlDomDocument document = new XhtmlDomDocument(doc, this);
		if (options != null)
		{
			if (options.getEncoding() != null)
				document.encoding = options.getEncoding();
			document.factory().provideEol = options.getProvideEol();
			document.factory().convertToEntities = options.getConvertToEntities();
		}
		return document;
	}
	
	@Override
	public WalkerDocument newDocument(DocumentTag adapter, IOptions options)
	{
		Document dom = (Document)adapter.tag();
		XhtmlDomDocument document = new XhtmlDomDocument(dom, this);
		if (options != null)
		{
			if (options.getEncoding() != null)
				document.encoding = options.getEncoding();
			document.factory().provideEol = options.getProvideEol();
			document.factory().convertToEntities = options.getConvertToEntities();
		}
		return document;
	}
	
	@Override
	public WalkerDocument newDocument(String path, IOptions options) throws HtmlWalkerException
	{
		try
		{
			Document in = documentBuilder().parse(path);
			XhtmlDomDocument document = new XhtmlDomDocument(in, this);
			if (options != null)
			{
				if (options.getEncoding() != null)
					document.encoding = options.getEncoding();
				document.factory().provideEol = options.getProvideEol();
				document.factory().convertToEntities = options.getConvertToEntities();
			}
			return document;
		}
		catch (SAXException | IOException e)
		{
			throw new HtmlWalkerException(e);
		}		
	}
}
