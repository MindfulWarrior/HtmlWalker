/*
 * 
 */
package htmlwalker.tag.base;

import htmlwalker.platform.*;

/**
 * This class is used to support implementation tag adapters for HTML tags that only have script content.
 * 
 * @author Robert Flores
 */
public abstract class ContentScriptTag extends BaseTag
{
	
	/**
	 * Instantiates a new content script tag.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 * @param tag - object housed by this tag adapter
	 */
	protected ContentScriptTag(WalkerFactory factory, Object tag) { super(factory, tag); }

	/**
	 * Content type.
	 *
	 * @return the content type
	 * @see HtmlWalker.ITag#contentType()
	 */
	@Override
	public ContentType contentType() { return ContentType.SCRIPT; }
	
	/**
	 * Gets the content text.
	 *
	 * @return the content text
	 * @see HtmlWalker.ITag#getTextValue()
	 */
	@Override
	public String getTextValue() { return this.api.getScript(tag()); }

	/**
	 * Sets the content text.
	 *
	 * @param text the new content text
	 * @see HtmlWalker.ITag#setTextValue(java.lang.String)
	 */
	@Override
	public void setTextValue(String text) { this.api.setScript(tag(), text); }

	/**
	 * @see HtmlWalker.ITag#ownedTags()
	 */
	@Override
	public TagList ownedTags() { return null; }
	
	@Override
	public String ownedText() { return getTextValue(); }
}
