package htmltest.base;

import static org.junit.Assert.fail;

import java.io.File;

import htmlwalker.platform.WalkerPlatform;

public class CloneTest_Base extends CloneTest
{
	private final static String TSTPATH = "Test";

    public CloneTest_Base() { super("html", "Base"); }

    @Override
    protected String testFolder() { return TSTPATH; }

    @Override
    protected boolean isXml() { return false; }

    @Override
    protected WalkerPlatform platform() { throw new UnsupportedOperationException(); }

    @Override
    protected void createExpected(File expected, File testInput, TestOptions options) { }

    public void tEmptyLines()
    {
        if (!compareLines("", "", true))
            fail("Empty lines don't match");
    }

    public void tSkipWhitespace()
    {
        if (!compareLines(" x xx", "xx x ", true))
            fail("Whitespace used to compare");
    }

    public void tDifferentLengths0()
    {
        if (compareLines("xxx", "xxxx", true))
            fail("Lines of different lenght match");
    }

    public void tDifferentLengths1()
    {
        if (compareLines("x xx", "xxxx", true))
            fail("Whitespace used for length");
    }
}
