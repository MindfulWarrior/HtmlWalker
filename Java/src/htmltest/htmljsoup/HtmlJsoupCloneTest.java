package htmltest.htmljsoup;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;

import htmljsoupwalker.*;
import htmltest.base.CloneTest;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.*;
import htmlwalker.platform.WalkerPlatform.IOptions;

public class HtmlJsoupCloneTest extends CloneTest
{
	private final static String TSTPATH = "Test";

	@Override
	protected boolean isXml() { return false; }

	public HtmlJsoupCloneTest()
	{
		super("html", "Base");
		//this.html5 = true;
	}
	
	protected HtmlJsoupCloneTest(String subFolder)
	{
		super("html", subFolder);
		//this.html5 = true;
	}
	
	@Override
	public String testFolder() { return TSTPATH; }
	
	@Override
	protected WalkerPlatform platform() { return HtmlPlatform.theInstance; }

	@Override
	protected void createExpected(File expected, File testInput)
	{
		try
		{
			Document doc = Jsoup.parse(testInput, "UTF-8");
			FileWriter writer = new FileWriter(expected);
			writer.write(doc.html());
			writer.close();
		}
		catch (IOException e)
		{
			e.printStackTrace();
		}				
	}

	@Override
	protected IOptions createOptions() throws HtmlWalkerException
	{
		return new HtmlPlatform.Options();
	}
}