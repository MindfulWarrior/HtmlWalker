package htmltest.base;

import static org.junit.Assert.fail;

import java.io.File;

import htmlwalker.exception.HtmlWalkerException;

public abstract class CloneTest extends BaseTest
{
    private final static String OUTPATH = "Test";
	protected final String ext;
	
	protected abstract boolean isXml();

	@Override
	protected String outFolder()  { return OUTPATH; }
    
	public CloneTest() { this("html");	}
	
	public CloneTest(String ext)
	{
		super();
		this.ext = ext;
	}

	public CloneTest(String ext, String subFolder)
	{
		super(subFolder);
		this.ext = ext;
	}
	
	protected void doTest(File testInput, File testOutput, File testExpected, TestOptions options)
	{
		TestWalker walker;
		if (!platform().isXml() && options.formatted && options.documentOptions.getProvideEol())
			walker = new FormattedCloneTestWalker(platform(), options.documentOptions);
		else
			walker = new CloneTestWalker(platform(), options.documentOptions);

	    try
	    {
	    	var document = platform().newDocument(testInput.getPath(), options.documentOptions);
	    	walker.visit(document.documentTag());
			if (testOutput.exists())
            	testOutput.delete();
	        walker.output().save(testOutput.getPath(), document.encoding);
		}
	    catch (HtmlWalkerException e)
	    {
			fail(e.getMessage());
		}
	
		compareToExpected(testOutput, testExpected, true);
	}

	protected void doTest(String inFile, String outFile, String expectedFile, TestOptions options)
	{
	    var testInput = getTestInput(inFile);
	    var testOutput = getTestOutput(outFile);
		var testExpected = getTestExpected(expectedFile, testInput, options);
		doTest(testInput, testOutput, testExpected, options);
	}

	protected void doTest(TestOptions options)
    {
	    doTest("test." + this.ext, "clone." + this.ext, "expected." + this.ext, options);
    }

    protected void doTest(String t, TestOptions options)
    {
	    doTest("test." + t + "." + this.ext, "clone." + t + "." + this.ext, "expected." + t + "." + this.ext, options);
    }
	
    protected void doTest(int t, TestOptions options)
    {
    	options.documentOptions.setProvideEol(false);
	    doTest(String.valueOf(t), options);
    	options.documentOptions.setProvideEol(true);
	    doTest(String.valueOf(t), options);
    }
	
    protected void doTest(int t)
    {
	    doTest(t, new TestOptions(platform()));
    }
}