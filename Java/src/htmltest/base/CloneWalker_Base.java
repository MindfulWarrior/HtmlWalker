package htmltest.base;

import static org.junit.Assert.fail;

import java.io.File;
import java.io.FileWriter;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.exception.TagNotSupportedException;
import htmlwalker.platform.WalkerDocument;
import xhtmldomwalker.XhtmlDomPlatform;

public abstract class CloneWalker_Base extends CloneTest
{
	private final static String TSTPATH = "Test";

    public CloneWalker_Base() { super("html", "Base"); }
    public CloneWalker_Base(String ext) { super(ext, "Base"); }
    
    private String testHtml()
    {
        String eol = isXml() ? System.lineSeparator() : "\n";
        
    	String html = "";

        if (isXml())
    		html += "<html xmlns=\"http://www.w3.org/1999/xhtml\">" + eol;
        else
    		html += "<html>" + eol +" <head></head> " + eol;
        html += " <body> " + eol + "  <p>Hello, World!</p>  " + eol + " </body>" + eol + "</html>";
        
        return html;
    }

    @Override
    protected String testFolder() { return TSTPATH; }

    public void tUnsupported()
    {
        String html = "<html><body><unsupported></unsupported></body></html>";
        TestWalker walker = new TestWalker(platform());
        WalkerDocument document = platform().newDocument();

        try
        {
            document.loadHtml(html);
            walker.visit(document.documentTag());
            fail("Did not throw an exception");
        }
        catch (TagNotSupportedException e)
        {
            // Test passes
        }
        catch (HtmlWalkerException e)
        {
			e.printStackTrace();
			fail(e.getMessage());
		}
    }

    public void tWalk()
    {
        String html = testHtml();
        
        File testExpected = getTestOutput("expected.path_load." + this.ext);
        try
        {
            if (testExpected.exists())
            	testExpected.delete();

            try (FileWriter writer = new FileWriter(testExpected.getAbsolutePath()))
            {
                writer.write(html);
            }

            WalkerDocument document = platform().newDocument(testExpected.getPath());
            TestWalker walker = new TestWalker(platform());
            walker.visit(document.documentTag());

            String expected = html;
            if (isXml())
            	expected = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator() + html;

            if (!expected.equals(walker.output().html()))
                fail("Expected - [" + expected + "] vs Out - [" + walker.output().html() + "]");
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tLoadHtml()
    {
        String html = testHtml();

        try
        {
        	WalkerDocument document = platform().newDocument();
            document.loadHtml(html);
            
            String expected = html;
            if (isXml())
            	expected = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator() + html;
            
            if (!expected.equals(document.html()))
                fail("Expected - [" + expected + "] vs Out - [" + document.html() + "]");
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tLoadPath()
    {
        String html = testHtml();
        
        File testExpected = getTestOutput("expected_load_path." + this.ext);
        try
        {
            if (testExpected.exists())
            	testExpected.delete();

            try (FileWriter writer = new FileWriter(testExpected.getAbsolutePath()))
            {
                writer.write(html);
            }

            WalkerDocument document = platform().newDocument();
            document.load(testExpected.getAbsolutePath());
                        
            String expected = html;
            if (isXml())
            	expected = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator() + html;
            
            if (!expected.equals(document.html()))
                fail("Expected - [" + expected + "] vs Out - [" + document.html() + "]");
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tLoadHtmWalk()
    {
        String html = testHtml();
        
        try
        {
        	WalkerDocument document = platform().newDocument();
            document.loadHtml(html);

            TestWalker walker = new TestWalker(platform());
            walker.visit(document.documentTag());

            String expected = html;
            if (isXml())
            	expected = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator() + html;
            
            if (!expected.equals(document.html()))
                fail("Expected - [" + expected + "] vs Out - [" + document.html() + "]");
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tLoadPathWalk()
    {
        String html = testHtml();

        File testExpected = getTestOutput("expected_load_path_walk." + this.ext);
        try
        {
            if (testExpected.exists())
            	testExpected.delete();

            try (FileWriter writer = new FileWriter(testExpected.getAbsolutePath()))
            {
                writer.write(html);
            }

            WalkerDocument document = platform().newDocument();
            document.load(testExpected.getAbsolutePath());

            TestWalker walker = new TestWalker(platform());
            walker.visit(document.documentTag());

            String expected = html;
            if (isXml())
            	expected = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator() + html;
            
            if (!expected.equals(document.html()))
                fail("Expected - [" + expected + "] vs Out - [" + document.html() + "]");
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tSavePath()
    {
        String eol = System.lineSeparator();
        String html = "<html>" + eol;
        if (!isXml())
        	html += " <head></head> " + eol;
        html += " <body> " + eol;
        html += "  <p>Hello, World!</p>   " + eol; 
        html += " </body>" + eol;
        html += "</html>" + eol;

        try
        {
            File testOutput = getTestOutput("output_save_path." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            WalkerDocument document = platform().newDocument();
            document.loadHtml(html);

            TestWalker walker = new TestWalker(platform());
            walker.visit(document.documentTag());

            walker.output().save(testOutput.getAbsolutePath());

            String expected = html;
            if (isXml())
            	expected = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator() + html;
            
            compareToExpected(testOutput, expected);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tSaveWriter()
    {
    	String eol = System.lineSeparator();
        String html = "<html>" + eol;
        if (!isXml())
        	html += " <head></head> " + eol;
        html += " <body> " + eol;
        html += "  <p>Hello, World!</p>   " + eol; 
        html += " </body>" + eol;
        html += "</html>" + eol;

        try
        {
            File testOutput = getTestOutput("output_save_writer." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            WalkerDocument document = platform().newDocument();
            document.loadHtml(html);

            TestWalker walker = new TestWalker(platform());
            walker.visit(document.documentTag());

            try (FileWriter writer = new FileWriter(testOutput.getAbsolutePath()))
            {
                walker.output().save(writer);
            }

            String expected = html;
            if (isXml())
            	expected = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator() + html;            

            compareToExpected(testOutput, expected);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tEntityIsPreserved()
    {
        String html = "";
        if (isXml())
        	html = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator();
        
    	String eol = isXml() ? System.lineSeparator() : "\n";
    	html += "<html>" + eol;
    	if (!isXml())
    		html += " <head></head> " + eol;
        html += " <body> " + eol;
        html += "  <p>&lsquo;Hello, World!&rsquo;</p>  " + eol;
        html += " </body>" + eol;
        html += "</html>";

        try
        {
        	WalkerDocument document = platform().newDocument();
            document.loadHtml(html);

            TestWalker walker = new TestWalker(platform());
            walker.visit(document.documentTag());

            if (!html.equals(walker.output().html()))
                fail("Expected - [" + html + "] vs Out - [" + walker.output().html() + "]");
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tEntityIsPreservedSaved()
    {
        String html = "";
        if (isXml())
        	html = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator();
        
    	String eol = isXml() ? System.lineSeparator() : System.lineSeparator();
    	html += "<html>" + eol;
    	if (!isXml())
    		html += " <head></head> " + eol;
        html += " <body> " + eol;
        html += "  <p>&lsquo;Hello, World!&rsquo;</p>  " + eol;
        html += " </body>" + eol;
        html += "</html>" + eol;

        try
        {
            File testOutput = getTestOutput("output_entity." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            WalkerDocument document = platform().newDocument();
            document.loadHtml(html);

            TestWalker walker = new TestWalker(platform());
            walker.visit(document.documentTag());
            walker.output().save(testOutput.getAbsolutePath());

            compareToExpected(testOutput, html);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tEntityIsPreservedLoadSaved()
    {
        String html = "";
        if (isXml())
        	html = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator();
        
    	String eol = isXml() ? System.lineSeparator() : "\n";
    	html += "<html>" + eol;
    	if (!isXml())
    		html += " <head></head> " + eol;
        html += " <body> " + eol;
        html += "  <p>&lsquo;Hello, World!&rsquo;</p>  " + eol;
        html += " </body>" + eol;
        html += "</html>";

        File testExpected = getTestOutput("expected_load_entity." + this.ext);
        try
        {
            if (testExpected.exists())
            	testExpected.delete();

            try (FileWriter writer = new FileWriter(testExpected.getAbsolutePath()))
            {
                writer.write(html);
            }

            File testOutput = getTestOutput("output_load_entity." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            WalkerDocument document = platform().newDocument();
            document.load(testExpected.getAbsolutePath());

            if (!isXml())
                html += System.lineSeparator();

            TestWalker walker = new TestWalker(platform());
            walker.visit(document.documentTag());
            walker.output().save(testOutput.getAbsolutePath());

            compareToExpected(testOutput, testExpected);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }
}

