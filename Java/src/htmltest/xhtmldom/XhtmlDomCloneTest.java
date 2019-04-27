package htmltest.xhtmldom;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import javax.xml.transform.TransformerException;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.w3c.dom.Document;
import org.xml.sax.SAXException;

import htmltest.base.CloneTest;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.*;
import htmlwalker.platform.WalkerPlatform.IOptions;
import xhtmldomwalker.*;

public class XhtmlDomCloneTest extends CloneTest
{
	private final static String TSTPATH = "Test";
   
	@Override
	protected boolean isXml() { return true; }

	public XhtmlDomCloneTest() { super("xhtml", "Base"); }
	
	protected XhtmlDomCloneTest(String subfolder) { super("xhtml", subfolder); }

	@Override
	public String testFolder() { return TSTPATH; }

	@Override
	protected void createExpected(File expected, File testInput)
	{
		try {
			Document dom = XhtmlDomPlatform.documentBuilder().parse(testInput);
			DOMSource source = new DOMSource(dom);
			FileWriter writer = new FileWriter(expected.getAbsolutePath());
			StreamResult result = new StreamResult(writer);		
			XhtmlDomDocument.transformer().transform(source, result);
		}
		catch (IOException | SAXException | TransformerException e) {
			e.printStackTrace();
		}		
	}

	@Override
	protected IOptions createOptions() throws HtmlWalkerException
	{
		return new XhtmlDomPlatform.Options();
	}

	@Override
	protected WalkerPlatform platform() { return XhtmlDomPlatform.theInstance; }
}
