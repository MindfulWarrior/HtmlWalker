package htmltest.base;

import static org.junit.Assert.fail;

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
	
	protected void doTest(String inFile, String outFile, String expectedFile, Options options)
	{
	    var testInput = getTestInput(inFile);

	    var testOutput = getTestOutput(outFile);
        if (testOutput.exists())
            testOutput.delete();

		var walker = new TestWalker(platform(), options == null ? false : options.formatted && options.documentOptions.getProvideEol());
	    walker.tracer.verbosity = 2;
	    
	    try
	    {
	    	var document = platform().newDocument(testInput.getPath(), options.documentOptions);
	    	walker.visit(document.documentTag());
	        walker.output().save(testOutput.getPath());
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
		doTest(inFile, outFile, expectedFile, new Options(platform()));
	}

	protected void doTest(Options options)
    {
	    doTest("test." + this.ext, "clone." + this.ext, "expected." + this.ext, options);
    }

	protected void doTest()
    {
	    doTest("test." + this.ext, "clone." + this.ext, "expected." + this.ext);
    }

    protected void doTest(String t, Options options)
    {
	    doTest("test." + t + "." + this.ext, "clone." + t + "." + this.ext, "expected." + t + "." + this.ext, options);
    }

    protected void doTest(String t)
    {
	    doTest("test." + t + "." + this.ext, "clone." + t + "." + this.ext, "expected." + t + "." + this.ext, new Options(platform()));
    }
	
    protected void doTest(int t, Options options)
    {
    	options.documentOptions.setProvideEol(false);
	    doTest(String.valueOf(t), options);
    	options.documentOptions.setProvideEol(true);
	    doTest(String.valueOf(t), options);
    }
	
    protected void doTest(int t)
    {
	    doTest(t, new Options(platform()));
    }
}
