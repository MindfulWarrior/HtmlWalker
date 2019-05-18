package htmltest.htmldoctooltest;

import java.io.File;

import org.junit.Test;

import htmldoccleaner.App;
import htmljsoupwalker.HtmlPlatform;
import htmltest.base.BaseTest;
import htmlwalker.platform.WalkerPlatform;

public class CleanerTest extends BaseTest
{
	private final static String TSTPATH = "Test";

    public CleanerTest() { super("Cleaner"); }

    @Override
    protected String testFolder() { return TSTPATH; }

    @Override
    protected String outFolder() { return TSTPATH; }

    @Override
    protected WalkerPlatform platform() { return HtmlPlatform.theInstance; }

    @Override
    protected void createExpected(File expected, File testInput, TestOptions options)
    {
        App.main(new String[] { testInput.getPath(), expected.getPath() });
    }

    protected void doTest(String test)
    {
        var options = new TestOptions(platform());
        options.autoCreate = false;

        var testInput = getTestInput("test." + test + ".html");
        var expected = getTestExpected("saved." + test + ".html", testInput, options);
        var testOutput = getTestOutput("output." + test + ".html");
        App.main(new String[] { testInput.getPath(), testOutput.getPath() });
        compareToExpected(testOutput, expected, false);
    }

    @Test
    public void comment_01() { doTest("comment.01"); }

    @Test
    public void head_01() { doTest("head.01"); }

    @Test
    public void div_01() { doTest("div.01"); }

    @Test
    public void attribute_01() { doTest("attribute.01"); }

    @Test
    public void word_01() { doTest("word.01"); }
}
