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
    protected void createExpected(File expected, File testInput, Options options)
    {
        createFormattedClone(testInput.getPath(), expected.getPath());
    }

    protected void createFormattedClone(String pathInput, String pathOutput)
    {
        var options = platform().newDocumentOptions();
        options.setProvideEol(true);

        try {
            var input = platform().newDocument(pathInput, options);
            var walker = new FormattedCloneTestWalker(platform());
            walker.visit(input.documentTag());
            walker.output().save(pathOutput);
        }
        catch (HtmlWalkerException e)
        {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    }

    protected void doTest(String test)
    {
        var testInput = getTestInput("test." + test + ".html");
        var expected = getTestExpected("saved." + test + ".html", testInput);
        var testOutput = getTestOutput("output." + test + ".html");
        createFormattedClone(testInput.getPath(), testOutput.getPath());
        compareToExpected(testOutput, expected, false);
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

