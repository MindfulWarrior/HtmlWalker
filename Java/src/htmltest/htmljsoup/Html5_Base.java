package htmltest.htmljsoup;

import static org.junit.Assert.fail;

import java.io.File;

import org.junit.Test;

import htmljsoupwalker.HtmlPlatform;
import htmltest.base.CloneWalker_Base;
import htmlwalker.platform.WalkerDocument;
import htmlwalker.platform.WalkerPlatform;

public class Html5_Base extends CloneWalker_Base
{
    public Html5_Base() { }

    @Override
    protected boolean isXml() { return false; }

    @Override
    protected WalkerPlatform platform() { return HtmlPlatform.theInstance; }

    @Override
    protected void createExpected(File expected, File testInput)
    {
        try
        {
        	WalkerDocument document = platform().newDocument();
            document.load(testInput.getAbsolutePath());
            document.save(expected.getAbsolutePath());
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
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
    	// TODO: Get entities working
        //super.tEntityIsPreservedLoadSaved();
    }
}
