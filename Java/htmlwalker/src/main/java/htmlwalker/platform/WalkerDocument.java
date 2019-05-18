/*
 * 
 */
package htmlwalker.platform;

import java.io.Writer;

import htmlwalker.DocumentTag;
import htmlwalker.exception.HtmlWalkerException;

/**
 * This abstract class is overwritten to represent the XML Dom style document for the
 * specific platform.
 * 
 * Part of the role of a walker document is to provide the main point of access in
 * processing the result of the HTML walked as a whole.
 * 
 * @author Robert Flores
 */
public abstract class WalkerDocument
{
    protected DocumentTag documentTag = null;
    
    public String encoding = null;

    protected WalkerDocument() { }

    public DocumentTag documentTag()
    {
        if (this.documentTag == null)
            this.documentTag = new DocumentTag(factory(), documentNode());
        return this.documentTag;
    }
    
    protected abstract Object documentNode();

	/**
	 * Access to the WalkerFactory used to create the document
	 * @return the walker factory
	 * @see HtmlWalker.WalkerFactory
	 */
    public abstract WalkerFactory factory();

    public abstract String html();

	/**
	 * This method releases the document specifically to the platform
	 */
    public void close() { this.documentTag = null; }

    public abstract WalkerDocument load(String path) throws HtmlWalkerException;

    //public abstract WalkerDocument load(Reader reader) throws HtmlWalkerException;

    public abstract WalkerDocument loadHtml(String html) throws HtmlWalkerException;

	/**
	 * This method is overwritten to provide the platform specific what the HTML
	 * needs to be written with a given encoding.
	 *
	 * @param writer - the writer
     * @param encoding - which encoding to use.
	 * @throws HtmlWalkerException the html walker exception
	 */
    public abstract void save(String path, String encoding) throws HtmlWalkerException;;

	/**
	 * This method is overwritten to provide the platform specific what the HTML
	 * needs to be written using the default encoding
	 *
	 * @param writer the writer
	 * @throws HtmlWalkerException the html walker exception
	 */
    public abstract void save(String path) throws HtmlWalkerException;;

    public abstract void save(Writer writer) throws HtmlWalkerException;;
}
