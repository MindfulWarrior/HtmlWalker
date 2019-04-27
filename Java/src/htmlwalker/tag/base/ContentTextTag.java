/*
 * 
 */
package htmlwalker.tag.base;

import htmlwalker.platform.*;

/**
 * This class is used to support implementation tag adapters for HTML tags that only have text content.
 * 
 * @author Robert Flores
 */
public abstract class ContentTextTag extends BaseTag
{
	
	/**
	 * Instantiates a new content text tag.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 * @param tag - object housed by this tag adapter
	 */
	protected ContentTextTag(WalkerFactory factory, Object tag) { super(factory, tag); }
	
	/**
	 * @see HtmlWalker.ITag#contentType()
	 */
	@Override
	public ContentType contentType() { return ContentType.TEXT; }
	
	/**
	 * @see HtmlWalker.ITag#getTextValue()
	 */
	@Override
	public String getTextValue() { return this.api.getText(tag()); }
	
	/**
	 * @see HtmlWalker.ITag#setTextValue(java.lang.String)
	 */
	@Override
	public void setTextValue(String text) { this.api.setText(tag(), text); }
	
	/**
	 * @see HtmlWalker.ITag#ownedTags()
	 */
	@Override
	public TagList ownedTags() { return null; }
	
	@Override
	public String ownedText() { return getTextValue(); }
}
