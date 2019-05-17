package domwalker;

import java.io.Writer;
import java.util.List;

import htmlwalker.ITag;
import htmlwalker.exception.HtmlWalkerException;

public abstract class DomApi<D>
{
	protected DomApi() { }
	
    public abstract Object documentNode(D dom);
    
    public abstract Object htmlElement(D dom);
    
    public abstract String html(D dom);

    public abstract Object createElement(D dom, String name);

    public abstract Object createTextNode(D dom, String text);

    public abstract Object createEntityNode(D dom, String entity);

    public abstract List<Object> getContent(D dom, ITag adapter);
    
    public abstract D load(D dom, String path) throws HtmlWalkerException;

    public abstract D loadHtml(D dom, String html) throws HtmlWalkerException;    	    

    public abstract void save(D dom, String path, String encoding) throws HtmlWalkerException;

    public abstract void save(D dom, String path) throws HtmlWalkerException;

    public abstract void save(D dom, Writer writer) throws HtmlWalkerException;
}
