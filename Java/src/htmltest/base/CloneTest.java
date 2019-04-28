package htmltest.base;

import static org.junit.Assert.fail;

import java.io.File;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerDocument;
import htmlwalker.platform.WalkerPlatform;

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
	
	protected void doTest(String inFile, String outFile, String expectedFile, WalkerPlatform.IOptions options)
	{
	    File testInput = getTestInput(inFile);

	    File testOutput = getTestOutput(outFile);
        if (testOutput.exists())
            testOutput.delete();

	    TestWalker cloner = new TestWalker(platform());
	    cloner.tracer.verbosity = 2;
	    
	    try
	    {
	    	WalkerDocument document = platform().newDocument(testInput.getPath(), options);
	    	cloner.visit(document.documentTag());
	        cloner.output().save(testOutput.getPath());
		}
	    catch (HtmlWalkerException e)
	    {
			fail(e.getMessage());
		}
	
	    if (null != expectedFile)
		    compareToExpected(testOutput, testInput, expectedFile, true);
	}

	protected void doTest(String inFile, String outFile, String expectedFile)
	{
		doTest(inFile, outFile, expectedFile, null);
	}

	protected void doTest(WalkerPlatform.IOptions options)
    {
	    doTest("test." + this.ext, "clone." + this.ext, "expected." + this.ext, options);
    }

	protected void doTest()
    {
	    doTest("test." + this.ext, "clone." + this.ext, "expected." + this.ext);
    }

    protected void doTest(String t, WalkerPlatform.IOptions options)
    {
	    doTest("test." + t + "." + this.ext, "clone." + t + "." + this.ext, "expected." + t + "." + this.ext, options);
    }

    protected void doTest(String t)
    {
	    doTest("test." + t + "." + this.ext, "clone." + t + "." + this.ext, "expected." + t + "." + this.ext, null);
    }
	
    protected void doTest(int t, Options options)
    {
    	if (options == null)
			options = new Options(platform());
    	options.documentOptions.setProvideEol(false);
	    doTest(String.valueOf(t), options.documentOptions);
    	options.documentOptions.setProvideEol(true);
	    doTest(String.valueOf(t), options.documentOptions);
    }
	
    protected void doTest(int t)
    {
	    doTest(String.valueOf(t), null);
    }
}
