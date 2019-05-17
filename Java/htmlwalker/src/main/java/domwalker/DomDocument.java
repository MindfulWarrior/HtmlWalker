package domwalker;

import java.io.Writer;
import java.nio.charset.Charset;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerDocument;
import htmlwalker.platform.WalkerFactory;

public abstract class DomDocument<F extends DomFactory<A, D>, A extends DomApi<D>, D> extends WalkerDocument
{
	private final F factory;
		
	protected DomDocument(F factory)
	{
		super();
		this.factory = factory;
	}
	
	protected D getDom() { return this.factory.dom; }
	protected void setDom(D dom) { this.factory.dom = dom; }
	
	@Override
	protected Object documentNode() { return this.factory.dapi.documentNode(getDom()); }

	@Override
	public WalkerFactory factory() { return this.factory; }
	
	@Override
	public String html() { return this.factory.dapi.html(getDom()); }

	@Override
    public WalkerDocument load(String path) throws HtmlWalkerException
    {
		close();
		
        this.factory.dom = this.factory.dapi.load(getDom(), path);
        this.documentTag = null;
        return this;
    }


	@Override
    public WalkerDocument loadHtml(String html) throws HtmlWalkerException
    {
		close();

        this.factory.dom = this.factory.dapi.loadHtml(getDom(), html);
        this.documentTag = null;
        return this;
    }
	
	@Override
	public void save(String path, String encoding) throws HtmlWalkerException
	{
		this.factory.dapi.save(getDom(), path, encoding);
	}
	
	@Override
	public void save(String path) throws HtmlWalkerException
	{
		if (this.encoding == null)
			this.factory.dapi.save(getDom(), path);
		else
			this.factory.dapi.save(getDom(), path, this.encoding);
	}
	
	@Override
	public void save(Writer writer) throws HtmlWalkerException
	{
		this.factory.dapi.save(getDom(), writer);
	}
	
	@Override
	public void close()
	{
		super.close();
		this.factory.close();
	}
}
