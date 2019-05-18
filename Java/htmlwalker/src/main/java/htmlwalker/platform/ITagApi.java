/*
 * 
 */
package htmlwalker.platform;

import java.util.Map;

import htmlwalker.ITag;

/**
 * The interface provides the platform specific implementation for the tag
 * adapters.
 * 
 * This is essentially a bridge between the platform specific implementation and
 * the tag adapter interface. Generally, this interface is used to in the
 * platform implementation but is not used directly when making use of the HTML
 * walker.
 * 
 * @author Robert Flores
 */
public interface ITagApi
{
	/**
	 * Access to the walker platform object used to generate this instance.
	 *
	 * @return the walker platform
	 */
	public WalkerPlatform platform();

	/**
	 * Returns the tag name.
	 *
	 * @return the string
	 */
	public String name(Object tag);

	/**
	 * Provides the implementation for the <b>ITag.getAttributes()</b>
	 *
	 * @return the attributes
	 * 
	 * @see HtmlWalker.ITag#getAttributes()
	 */
	public Map<String, Object> getAttributes(Object tag);

	/**
	 * Gets the tag attribute value for a given attribute name.
	 *
	 * @param attr - the attribute name
	 * @return the attribute value
	 * 
	 * @see HtmlWalker.ITag#getAttribute(String)
	 */
	public String getAttribute(Object tag, String attr);

	/**
	 * Sets the tag attribute value for a given attribute name.
	 *
	 * @param attr - the attribute name
	 * @param value - the attribute value
	 * 
	 * @see HtmlWalker.ITag#setAttribute(String, String)
	 */
	public void setAttribute(Object tag, String attr, Object value);

	/**
	 * Gets the text for tags of content type <b>TEXT</b>.
	 *
	 * @return the text belonging to the HTML tag
	 * 
	 * @see HtmlWalker.ITag#getInnerText()
	 */
	public String getText(Object tag);

	/**
	 * Sets the text for tags of content type <b>TEXT</b>.
	 *
	 * @param text - new text
	 */
	public void setText(Object tag, String text);

	/**
	 * Gets the script for tags of content type <b>SCRIPT</b>.
	 *
	 * @return the script belonging to the HTML tag
	 * 
	 * @see HtmlWalker.ITag#getInnerText()
	 */
	public String getScript(Object tag);

	/**
	 * Sets the script for tags of content type <b>SCRIPT</b>.
	 *
	 * @param script - new script
	 */
	public void setScript(Object tag, String script);
	
	public void add(Object tag, ITag adapter);
	
	public void remove(Object tag, ITag adapter);

	public String ownedText(Object tag);
}
