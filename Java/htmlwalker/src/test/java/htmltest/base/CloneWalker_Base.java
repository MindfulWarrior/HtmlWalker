package htmltest.base;

import static org.junit.Assert.fail;

import java.io.FileWriter;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.exception.TagNotSupportedException;
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
        var document = platform().newDocument();
        var walker = new CloneTestWalker(platform());

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
        
        var testExpected = getTestOutput("expected.path_load." + this.ext);
        try
        {
            if (testExpected.exists())
            	testExpected.delete();

            try (var writer = new FileWriter(testExpected.getAbsolutePath()))
            {
                writer.write(html);
            }

            var document = platform().newDocument(testExpected.getPath());
            var walker = new CloneTestWalker(platform());
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
        	var document = platform().newDocument();
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
        
        var testExpected = getTestOutput("expected_load_path." + this.ext);
        try
        {
            if (testExpected.exists())
            	testExpected.delete();

            try (var writer = new FileWriter(testExpected.getAbsolutePath()))
            {
                writer.write(html);
            }

            var document = platform().newDocument();
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
        	var document = platform().newDocument();
            document.loadHtml(html);

            var walker = new CloneTestWalker(platform());
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

        var testExpected = getTestOutput("expected_load_path_walk." + this.ext);
        try
        {
            if (testExpected.exists())
            	testExpected.delete();

            try (var writer = new FileWriter(testExpected.getAbsolutePath()))
            {
                writer.write(html);
            }

            var document = platform().newDocument();
            document.load(testExpected.getAbsolutePath());

            var walker = new CloneTestWalker(platform());
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
            var testOutput = getTestOutput("output_save_path." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            var document = platform().newDocument();
            document.loadHtml(html);

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());

            walker.output().save(testOutput.getAbsolutePath());

            String expected = html;
            if (isXml())
            	expected = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator() + html;
            
            compareToExpected(testOutput, expected, true);
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
            var testOutput = getTestOutput("output_save_writer." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            var document = platform().newDocument();
            document.loadHtml(html);

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());

            try (var writer = new FileWriter(testOutput.getAbsolutePath()))
            {
                walker.output().save(writer);
            }

            String expected = html;
            if (isXml())
            	expected = "<!DOCTYPE html PUBLIC \"" + XhtmlDomPlatform.DOCTYPE_PUBLIC + "\">" + System.lineSeparator() + html;            

            compareToExpected(testOutput, expected, true);
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
        	var document = platform().newDocument();
            document.loadHtml(html);

            var walker = new CloneTestWalker(platform());
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
            var testOutput = getTestOutput("output_entity." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            var document = platform().newDocument();
            document.loadHtml(html);

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());
            walker.output().save(testOutput.getAbsolutePath());

            compareToExpected(testOutput, html, true);
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

        var testExpected = getTestOutput("expected_load_entity." + this.ext);
        try
        {
            if (testExpected.exists())
            	testExpected.delete();

            try (var writer = new FileWriter(testExpected.getAbsolutePath()))
            {
                writer.write(html);
            }

            var testOutput = getTestOutput("output_load_entity." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            var document = platform().newDocument();
            document.load(testExpected.getAbsolutePath());

            if (!isXml())
                html += System.lineSeparator();

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());
            walker.output().save(testOutput.getAbsolutePath());

            compareToExpected(testOutput, testExpected, true);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }


    public void tNoEntityConversion()
    {
        String hdr = "";
        if (platform().isXml())
            hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
        var html = "<html><body><p>“Hello, World!”</p></body></html>";

        try
        {
            var document = platform().newDocument();
            document.loadHtml(hdr + html);

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());

            if (walker.output().html() != html)
                fail("Expected - [" + html + "] vs Out - [" + walker.output().html() + "]");
        }   
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tNoEntityConversionSaved()
    {
        String hdr = "";
        if (platform().isXml())
            hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
        var html = "<html>  <body>    <p>“Hello, World!”</p>  </body></html>";

        try
        {
            var testOutput = getTestOutput("output_noentity." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            var document = platform().newDocument();
            document.loadHtml(hdr + html);

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());
            walker.output().save(testOutput.getPath());

            compareToExpected(testOutput, html, true);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void tNoEntityConversionLoadSaved()
    {
        String hdr = "";
        if (platform().isXml())
            hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
        var html = "<html><body><p>“Hello, World!”</p></body></html>";

        var testExpected = getTestOutput("expected_load_noentity." + this.ext);
        try
        {
            if (!testExpected.exists())
            {
                try (var writer = new FileWriter(testExpected.getPath()))
                {
                    if (platform().isXml())
                        writer.write(hdr + "\n");
                    writer.write(html + "\n");
                }
            }
            var testOutput = getTestOutput("output_noentity." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            var document = platform().newDocument();
            document.loadHtml(hdr + html);

            if (!platform().isXml())
                html += System.lineSeparator();

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());
            walker.output().save(testOutput.getPath());

            compareToExpected(testOutput, testExpected, true);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void TNoEntityConversion()
    {
        String hdr = "";
        if (platform().isXml())
            hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
        var html = "<html><body><p>“Hello, World!”</p></body></html>";

        try
        {
            var document = platform().newDocument();
            document.loadHtml(hdr + html);

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());

            if (walker.output().html() != html)
                fail("Expected - [" + html + "] vs Out - [" + walker.output().html() + "]");
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void TNoEntityConversionSaved()
    {
        String hdr = "";
        if (platform().isXml())
            hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
        var html = "<html>  <body>    <p>“Hello, World!”</p>  </body></html>";

        try
        {
            var testOutput = getTestOutput("output_noentity." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            var document = platform().newDocument();
            document.loadHtml(hdr + html);

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());
            walker.output().save(testOutput.getPath());

            compareToExpected(testOutput, html, true);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void TNoEntityConversionLoadSaved()
    {
        String hdr = "";
        if (platform().isXml())
            hdr = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
        var html = "<html><body><p>“Hello, World!”</p></body></html>";

        var testExpected = getTestOutput("expected_load_noentity." + this.ext);
        try
        {
            if (!testExpected.exists())
            {
                try (var writer = new FileWriter(testExpected.getPath()))
                {
                    if (platform().isXml())
                        writer.write(hdr + "\n");
                    writer.write(html + "\n");
                }
            }
            var testOutput = getTestOutput("output_noentity." + this.ext);
            if (testOutput.exists())
                testOutput.delete();

            var document = platform().newDocument();
            document.loadHtml(hdr + html);

            if (!platform().isXml())
                html += System.lineSeparator();

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());
            walker.output().save(testOutput.getPath());

            compareToExpected(testOutput, testExpected, true);
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }

    public void TRemoveTag()
    {
        var html = "<html><body><p>Hello, World!</p><p>REMOVE THIS</p></body></html>";
        var expected = "<html><body><p>Hello, World!</p></body></html>";

        try
        {
            var document = platform().newDocument();
            document.loadHtml(html);

            var walker = new CloneTestWalker(platform());
            walker.visit(document.documentTag());

            var body = walker.output().documentTag().bodyTag();
            var removeThis = body.ownedTags().stream().filter(
                p -> p.name() == "p" && p.ownedText() == "REMOVE THIS"
            ).findFirst();
            body.ownedTags().remove(removeThis.get());

            if (walker.output().html() != expected)
                fail("Expected - [" + expected + "] vs Out - [" + walker.output().html() + "]");
        }
        catch (Exception e)
        {
            e.printStackTrace();
            fail(e.getMessage());
        }
    }
}
