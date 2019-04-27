package htmljsoupwalker;

import java.io.File;
import java.io.IOException;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Node;

import htmlwalker.*;
import htmlwalker.exception.*;
import htmlwalker.platform.*;

public class HtmlPlatform extends WalkerPlatform
{
	public static final WalkerPlatform theInstance = new HtmlPlatform();
	
	public static class Options implements IOptions
	{
		private boolean privateEol = false;
		private boolean convertToEntities = false;
		private String encoding = "UTF-8";
		
		public Options() { }

		@Override
		public boolean getProvideEol() { return this.privateEol; }

		@Override
		public void setProvideEol(boolean flag) { this.privateEol = flag; }

		@Override
		public boolean getConvertToEntities() { return this.convertToEntities; }

		@Override
		public void setConvertToEntities(boolean flag) { this.convertToEntities = flag; }

		@Override
		public String getEncoding() { return this.encoding; }

		@Override
		public void setEncoding(String encoding) { this.encoding = encoding; }
	}
	
	private HtmlPlatform() { super(); }

	@Override
	protected boolean keepEntities(boolean attribute) { return false; }
	
	@Override
	public String name() { return "HtmlJsoup"; }

	@Override
	public WalkerDocument newDocument(IOptions options)
	{
		Document dom = Jsoup.parse("<html/>");
		HtmlDocument document = new HtmlDocument(dom, this);
		if (options != null)
		{
			if (options.getEncoding() != null)
				document.encoding = options.getEncoding();
			document.factory().provideEol = options.getProvideEol();
			document.factory().convertToEntities = options.getConvertToEntities();
		}
		return document;
	}

	@Override
	public WalkerDocument newDocument(DocumentTag adapter, IOptions options)
	{
		Node node = (Node)adapter.tag();
		Document dom = Jsoup.parse(node.outerHtml());
		HtmlDocument document = new HtmlDocument(dom, this);
		if (options != null)
		{
			if (options.getEncoding() != null)
				document.encoding = options.getEncoding();
			document.factory().provideEol = options.getProvideEol();
			document.factory().convertToEntities = options.getConvertToEntities();
		}
		return document;
	}

	@Override
	public WalkerDocument newDocument(String path, IOptions options) throws HtmlWalkerException
	{
		try
		{
			if (options == null)
				options = new Options();
			Document dom = Jsoup.parse(new File(path), options.getEncoding());
			HtmlDocument document = new HtmlDocument(dom, this);
			document.encoding = options.getEncoding();
			document.factory().provideEol = options.getProvideEol();
			document.factory().convertToEntities = options.getConvertToEntities();
			return document;
		}
		catch (IOException e)
		{
			throw new HtmlWalkerException(e);
		}
	}
}
