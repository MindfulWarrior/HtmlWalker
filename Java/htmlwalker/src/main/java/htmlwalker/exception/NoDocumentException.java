/*
 * 
 */
package htmlwalker.exception;

/**
 * This exception is called when an atempt is made to walk HTML and the document
 * has not been set or made available.
 * 
 * Currently this document is intentially hidden, so it appears to the user as
 * its parent class <b>HtmlWalkerException</b>.
 * 
 * @author Robert Flores
 */
@SuppressWarnings("serial")
public class NoDocumentException extends HtmlWalkerException
{
	
	/**
	 * Instantiates a new no document exception.
	 */
	public NoDocumentException()
	{
		super(new IllegalStateException("IDocument not set"));
	}
	
	public NoDocumentException(String msg)
	{
		super(new IllegalStateException(msg));		
	}
}
