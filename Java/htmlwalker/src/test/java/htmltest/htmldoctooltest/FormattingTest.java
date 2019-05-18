package htmltest.htmldoctooltest;

import java.io.File;

import org.junit.Test;

import htmljsoupwalker.HtmlPlatform;
import htmltest.base.BaseTest;
import htmltest.base.FormattedCloneTestWalker;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerPlatform;

public class FormattingTest extends BaseTest
{
	private final static String TSTPATH = "Test";

    public FormattingTest() { super("Formatting"); }

    @Override
    protected String testFolder() { return TSTPATH; }

    @Override
    protected String outFolder() { return TSTPATH; }

    @Override
    protected WalkerPlatform platform() { return HtmlPlatform.theInstance; }

    @Override
    protected void createExpected(File expected, File testInput, TestOptions options)
    {
        createFormattedClone(testInput.getPath(), expected.getPath(), options);
    }

    protected TestOptions createTestOptions()
    {
        var options = new TestOptions(platform());
        options.autoCreate = false;
        options.documentOptions.setProvideEol(true);
        return options;
    }

    protected void createFormattedClone(String pathInput, String pathOutput, TestOptions options)
    {
        try {
            var input = platform().newDocument(pathInput, options.documentOptions);
            var walker = new FormattedCloneTestWalker(platform(), options.documentOptions);
            walker.visit(input.documentTag());
            walker.output().save(pathOutput);
        }
        catch (HtmlWalkerException e)
        {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    }

    protected void doTest(File testInput, File testOutput, File expected, TestOptions options)
    {
        createFormattedClone(testInput.getPath(), testOutput.getPath(), options);
        compareToExpected(testOutput, expected, false);
     }

    protected void doTest(String test)
    {
        var options = createTestOptions();
        var testInput = getTestInput("test." + test + ".html");
        var expected = getTestExpected("saved." + test + ".html", testInput, options);
        var testOutput = getTestOutput("output." + test + ".html");
        doTest(testInput, testOutput, expected, options);
    }

    @Test
    public void TFormat_01() { doTest("01"); }

    @Test
    public void TFormat_02() { doTest("02"); }

    @Test
    public void TFormat_03() { doTest("03"); }

    @Test
    public void TFormat_04() { doTest("04"); }
}

