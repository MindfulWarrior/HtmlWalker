/*
 * 
 */
package htmlwalker;

import htmlwalker.core.TagAttributes;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.base.TagList;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

/**
 * This interface provides a non-platform specific representation of an HTML tag.
 * 
 * The intention is that this interface will be impleneted by tag adapter classes
 * for each type of HTML tag. 
 * 
 * @author Robert Flores
 */
public interface ITag
{
	
	/**
	 * This method provides the implementation of the visitor pattern for the ITagVoidVisitor.
	 *
	 * @param visitor - the visitor
	 * @throws HtmlWalkerException the html walker exception
	 * 
	 * @see HtmlWalker.ITagVoidVisitor
	 */
	public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException;
	
	/**
	 * This method provides the implementation of the visitor pattern for the ITagGenericVisitor.
	 *
	 * @param <T> - the generic type that is returned by each 'visit'
	 * @param visitor - the visitor
	 * @return T
	 * @throws HtmlWalkerException the html walker exception
	 * 
	 * @see HtmlWalker.ITagGenericVisitor
	 */
	public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException;
	
	/**
	 * This enum represents what kinds of tags will be return as content.
	 */
	public enum ContentType
	{
		NONE, /** No content will be returned by <b>innerTag</b> and <b>innerText</b> */
		TEXT, /** Only string text available by <b>innerText</b> */
		TAG, /** Multiple tags available by <b>innerTag</b> */
		SCRIPT, /** Only script text available by <b>innerText</b> */
		UTIL, /** For what is normally not an HTML tag. The subclass defines <b>innerTag</b> and <b>innerText</b> */
		SKIP, /** Acting as a place holder for tags is to be skipped from processing. */
	}
	
	/**
	 * Returns the enum <b>ContentType</b> for this tag adapter
	 *
	 * @return the content type 
	 * 
	 * @see HtmlWalker.ITag.ContentType
	 */
	public ContentType contentType();
	
	/**
	 * Access to the HTML tag object housed by this tag adapter.
	 *
	 * @return the tag object
	 */
	public Object tag();
	
	/**
	 * Returns the tag name.
	 *
	 * @return the string
	 */
	public String name();
	
	public ITag owner();
	
	public TagAttributes attributes();
	
	/**
	 * Gets the string content for tags that do not contain other tags.
	 * 
	 * Applies to tags of content type <b>TEXT</b> and <b>SCRIPT</b>
	 *
	 * @return the content text
	 */
	public String getTextValue();
	
	/**
	 * Sets the string content for tags that do not contain other tags.
	 * 
	 * Applies to tags of content type <b>TEXT</b> or <b>SCRIPT</b>
	 *
	 * @param text the new content text
	 */
	public void setTextValue(String text);
	
	public TagList ownedTags();
	
	public String ownedText();
	
	public ITag clone(WalkerFactory factory, ITag owner);
}
