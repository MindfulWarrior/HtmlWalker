/*
 * 
 */
package htmlwalker.platform;

import htmlwalker.*;
import htmlwalker.core.EscHandler;
import htmlwalker.exception.*;

/**
 * This abstract class is overwritten to provide the basis for each specific platform used by an HTML Walker.
 * 
 * Developers implement this class as the main point to interact with their implementation.
 * While it is not required that the WalkerPlatform is implemented as a singleton, it is
 * suggested if appropriate.
 * 
 * @author Robert Flores
 */
public abstract class WalkerPlatform
{	
	public interface IOptions
	{
		boolean getProvideEol();
		void setProvideEol(boolean flag);

		boolean getConvertToEntities();
		void setConvertToEntities(boolean flag);

		String getEncoding();
		void setEncoding(String encoding);
	}
	
	/**
	 * This method is used by other classes to preserve/restore HTML entities.
	 *
	 * Thought this method the <b>EscHandler</b> is used depending on whether
	 * <b>keepEntities</b> returns true.
	 * 
	 * @param content - content where entities are preserve/restore
	 * @param attribute - whether or not the content is an attribute string
	 * @return content modified if necessary to preserve/restore entities
	 * 
	 * @see HtmlWalker.EscHandler
	 */
	public String handleEntities(String content, boolean attribute)
	{
		String text;
		
		if (keepEntities(attribute))
			text = EscHandler.theInstance.escape(content);
		else
			text = content;
		
		return text;
	}
	
	/**
	 * This method is overwritten to determine whether entities need to be preserved/restored.
	 * 
	 * The Platform uses this method to determine if the EscHandler is needed.
	 *
	 * @param attribute - whether or not the content is from a tag attribute
	 * @return true, if entities need to be preserved/restored
	 * 
	 * @see HtmlWalker.EscHandler
	 */
	protected abstract boolean keepEntities(boolean attribute);

	public abstract String name();
	
	/**
	 * Instantiates a new walker document for the specific platform.
	 *
	 * @param options - document options to use, can be null
	 * 
	 * @return the walker document
	 * 
	 * @see ITagDocument.WalkerDocument
	 */
	public abstract WalkerDocument newDocument(IOptions options);
	
	/**
	 * Instantiates a new walker document for the specific platform.
	 *
	 * @return the walker document
	 * 
	 * @see ITagDocument.WalkerDocument
	 */
	public WalkerDocument newDocument() { return newDocument((IOptions)null); }

	/**
	 * Instantiates a new walker document for the specific platform.
	 *
	 * @param options - document options to use, can be null
	 * @return the walker document
	 * 
	 * @see ITagDocument.WalkerDocument
	 */
	public abstract WalkerDocument newDocument(DocumentTag adapter, IOptions options);
	
	/**
	 * Instantiates a new walker document for the specific platform.
	 *
	 * @param html - html adapter holding root tag
	 * @param options - document options to use, can be null
	 * @return the walker document
	 * 
	 * @see ITagDocument.WalkerDocument
	 */
	public WalkerDocument newDocument(DocumentTag adapter) { return newDocument(adapter, null); }
	
	/**
	 * Instantiates a new walker document from an existing file for the specific platform.
	 *
	 * @param path - path to the existing file
	 * @param options - document options to use, can be null
	 * @return the walker document
	 * @throws HtmlWalkerException the exception
	 * 
	 * @see ITagDocument.WalkerDocument
	 */
	public abstract WalkerDocument newDocument(String path, IOptions options) throws HtmlWalkerException;
	
	/**
	 * Instantiates a new walker document from an existing file for the specific platform.
	 *
	 * @param path - path to the existing file
	 * @return the walker document
	 * @throws HtmlWalkerException the exception
	 * 
	 * @see ITagDocument.WalkerDocument
	 */
	public WalkerDocument newDocument(String path) throws HtmlWalkerException { return newDocument(path, null); }
}
