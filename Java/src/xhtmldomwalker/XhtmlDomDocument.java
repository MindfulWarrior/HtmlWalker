package xhtmldomwalker;

import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;

import javax.xml.transform.OutputKeys;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerConfigurationException;
import javax.xml.transform.TransformerFactory;

import org.w3c.dom.Document;

import domwalker.DomDocument;

public class XhtmlDomDocument extends DomDocument<XhtmlDomFactory, XhtmlDomApi, Document>
{
	private static final TransformerFactory tFactory = TransformerFactory.newInstance();
	
	private static final Lock lock = new ReentrantLock();

	private static Transformer transformer = null;

	public static Transformer transformer() throws TransformerConfigurationException
	{
		if (null == transformer)
		{
			lock.lock();
			if (null == transformer)
			{
				transformer = tFactory.newTransformer();
				transformer.setOutputProperty(OutputKeys.DOCTYPE_PUBLIC, XhtmlDomPlatform.DOCTYPE_PUBLIC);
				transformer.setOutputProperty(OutputKeys.OMIT_XML_DECLARATION, "yes");
				transformer.setOutputProperty(OutputKeys.METHOD, "html");
				//transformer.setOutputProperty(OutputKeys.INDENT, "yes");
			}
			lock.unlock();
		}
		return transformer;
	}

	XhtmlDomDocument(Document dom, XhtmlDomPlatform platform)
	{
		super(new XhtmlDomFactory(dom, platform));
	}
}
