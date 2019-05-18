package htmltest.xhtmldom;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

import javax.xml.transform.TransformerException;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.junit.Test;
import org.w3c.dom.Document;
import org.xml.sax.SAXException;

import htmltest.base.CloneWalker_Base;
import htmlwalker.platform.WalkerPlatform;
import xhtmldomwalker.XhtmlDomDocument;
import xhtmldomwalker.XhtmlDomPlatform;

public class Xhtml_Base extends CloneWalker_Base
{
    public Xhtml_Base() { }

    @Override
    protected boolean isXml() { return true; }

    @Override
    protected WalkerPlatform platform() { return XhtmlDomPlatform.theInstance; }


	@Override
	protected void createExpected(File expected, File testInput, TestOptions options)
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
    @Test
	public void tConfirmTestFolder()
	{
        super.tConfirmTestFolder();
	}

    @Override
    @Test
	public void tConfirmOutFolder()
	{
        super.tConfirmOutFolder();
	}

    @Override
    @Test
    public void tWalk()
    {
        super.tWalk();
    }

    @Override
    @Test
    public void tUnsupported()
    {
        super.tUnsupported();
    }

    @Override
    @Test
    public void tLoadHtml()
    {
        super.tLoadHtml();
    }

    @Override
    @Test
    public void tLoadPath()
    {
        super.tLoadPath();
    }

    @Override
    @Test
    public void tLoadHtmWalk()
    {
        super.tLoadHtmWalk();
    }

    @Override
    @Test
    public void tLoadPathWalk()
    {
        super.tLoadPathWalk();
    }

    @Override
    @Test
    public void tSavePath()
    {
        super.tSavePath();
    }

    @Override
    @Test
    public void tSaveWriter()
    {
        super.tSaveWriter();
    }

    @Test
    public void tEntityIsPreserved()
    {
    	// TODO: Get entities working
    	//super.tEntityIsPreserved();
    }

    @Test
    public void tEntityIsPreservedSaved()
    {
    	// TODO: Get entities working
    	//super.tEntityIsPreservedSaved();
    }

    @Test
    public void tEntityIsPreservedLoadSaved()
    {
        super.tEntityIsPreservedLoadSaved();
    }
}
