package htmltest.base;

import static org.junit.Assert.assertTrue;
import static org.junit.Assert.fail;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;

import org.junit.Test;

import htmlwalker.platform.WalkerPlatform;

public abstract class BaseTest
{
    protected class Options
    {
        public final WalkerPlatform.IOptions documentOptions;

        public boolean formatted = true;

        public Options(WalkerPlatform platform)
        {
            documentOptions = platform.newDocumentOptions();
        }
    }

    private final File tstFolder;
	private final File outFolder;
	
	protected abstract String testFolder();
	protected abstract String outFolder();
	
	protected abstract WalkerPlatform platform();
	
    protected abstract void createExpected(File expected, File testInput);
	
	public BaseTest()
	{
		this.tstFolder = new File(testFolder());
		this.outFolder = new File(outFolder());
	}
	
	protected BaseTest(String subFolder)
	{
		if (null == subFolder)
		{
			this.tstFolder = new File(testFolder());
			this.outFolder = new File(outFolder());
		}
		else
		{
			this.tstFolder = new File(testFolder() + File.separator + subFolder);
			this.outFolder = new File(outFolder() + File.separator + subFolder);
		}
	}

	@Test
	public void t0confirmTestFolder()
	{
		try
		{
			assertTrue(this.tstFolder.getCanonicalPath() + " does not exists", this.tstFolder.getCanonicalFile().exists());
		}
		catch (IOException e)
		{
			e.printStackTrace();
			fail(e.getMessage());
		}
	}

	@Test
	public void t0confirmOutFolder()
	{
		try
		{
			assertTrue(this.outFolder.getCanonicalPath() + " does not exists", this.tstFolder.getCanonicalFile().exists());
		}
		catch (IOException e)
		{
			e.printStackTrace();
			fail(e.getMessage());
		}
	}

	protected String getTestPath(String filename)
	{
		try
		{
			return this.tstFolder.getCanonicalPath() + File.separator + filename;
		}
		catch (IOException e)
		{
			e.printStackTrace();
			return null;
		}
	}

	protected String getOutPath(String filename)
	{
		try
		{
			return this.outFolder.getCanonicalPath() + File.separator + filename;
		}
		catch (IOException e)
		{
			e.printStackTrace();
			return null;
		}
	}

    protected File getTestInput(String filename)
    {
	    return new File(getTestPath(filename));
    }

    protected File getTestOutput(String filename)
    {
	    return new File(getOutPath(filename));
    }    

    protected File getTestExpected(String filename, File testInput)
    {
	    File expected = new File(getOutPath(filename));
	    if (!expected.exists())
		     createExpected(expected, testInput);
	    return expected;
    }

    private String readNextLine(BufferedReader reader, boolean ignoreWhitespace) throws IOException
	{
        String line = reader.readLine();
        if (ignoreWhitespace)
        {
        	while (null != line && line.trim().length() == 0)
        		line = reader.readLine();
        }
	    return line;
	}

	protected boolean compareLines(String expected, String output, boolean ignoreWhitespace)
	{
	    boolean match = true;
		
	    String eLine = expected.trim();
	    String oLine = output.trim();
	
	    int ePos = 0;
	    int oPos = 0;
	
	    while (match && ePos < eLine.length() && oPos < oLine.length())
	    {
	    	if (ignoreWhitespace)
	    	{
	    		while (Character.isWhitespace(eLine.charAt(ePos)) && ePos < eLine.length())
	    			ePos++;
		
	    		while (Character.isWhitespace(oLine.charAt(oPos)) && oPos < oLine.length())
	    			oPos++;
	    	}
		
		    match = eLine.charAt(ePos) == oLine.charAt(oPos);
		
		    ePos++;
		    oPos++;
	    }
	
	    if (match)
		    match = ePos == eLine.length() && oPos == oLine.length();
	
	    return match;
	}

    protected void compareToExpected(File testOutput, File testInput, String expectedFile, boolean ignoreWhitespace)
    {
        File testExpected = getTestExpected(expectedFile, testInput);
        compareToExpected(testOutput, testExpected, ignoreWhitespace);
    }

    protected void compareToExpected(File testOutput, File testExpected, boolean ignoreWhitespace)
	{
	    String failure = null;
	    
	    try
	    {
	        try (BufferedReader output = new BufferedReader(new FileReader(testOutput.getPath())))
	        {
	            try (BufferedReader expected = new BufferedReader(new FileReader(testExpected.getPath())))
	            {
	            	// TODO: Confirm not empty in sharp
	                // First line is declarations
	                String outputLine = output.readLine();
	                
	                while (outputLine != null && !outputLine.contains("<html"))
	                    outputLine = output.readLine();
	                
	                if (outputLine != null)
	                	outputLine = outputLine.substring(outputLine.indexOf("<html"));
	
	                String expectedLine = expected.readLine();
	                while (expectedLine != null && !expectedLine.contains("<html"))
	                    expectedLine = expected.readLine();
	                
	                if (expectedLine != null)
	                	expectedLine = expectedLine.substring(expectedLine.indexOf("<html"));

	                if (null != outputLine && !outputLine.isEmpty() && null != expectedLine && !expectedLine.isEmpty())
	                {
	                    outputLine = readNextLine(output, ignoreWhitespace);
	                    expectedLine = readNextLine(expected, ignoreWhitespace);
	                    while (null != outputLine && null != expectedLine && null == failure)
	                    {
	                        if (!compareLines(expectedLine, outputLine, ignoreWhitespace))
	                            failure = "Expected - [" + expectedLine + "] vs Out - [" + outputLine + "]";
	                        outputLine = readNextLine(output, ignoreWhitespace);
	                        expectedLine = readNextLine(expected, ignoreWhitespace);
	                    }
	                }
	                else
	                    failure = "Nothing to test";
	
	                if ((null != outputLine || null != expectedLine) && null == failure)
	                    failure = "One file is larger";
	            }
	            catch(Exception e)
	            {
	            	throw e;
	            }
	        }
            catch(Exception e)
            {
            	throw e;
            }
	    }
	    catch(Exception e)
	    {
	    	e.printStackTrace();
	    	failure = e.getMessage();
	    }

	    if (null != failure)
		    fail(failure);
	}

    protected void compareToExpected(File testOutput, String expected, boolean ignoreWhitespace)
    {
        String output = "";
        try (BufferedReader reader = new BufferedReader(new FileReader(testOutput.getPath())))
        {
        	String outputLine = readNextLine(reader, ignoreWhitespace);
            while (null != outputLine)
            {
                output += outputLine + System.lineSeparator();
                outputLine = readNextLine(reader, ignoreWhitespace);
            }
        }
        catch (IOException e)
        {
			e.printStackTrace();
			fail(e.getMessage());
		}

        if (!expected.equals(output))
            fail("Expected - [" + expected + "] vs Out - [" + output + "]");
    }
}
