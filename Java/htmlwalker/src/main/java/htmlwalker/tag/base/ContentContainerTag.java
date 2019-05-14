/*
 * 
 */
package htmlwalker.tag.base;

import htmlwalker.platform.WalkerFactory;

/**
 * This class is used to support implementation of tags that have other tags as
 * content with little restriction.
 * 
 * This includes most tags.
 * 
 * @author Robert Flores
 */
public abstract class ContentContainerTag extends BaseTag
{
	
	/** The content. */
	private TagList tags = null;
	
	/**
	 * Instantiates a new content container tag.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 * @param tag - object housed by this tag adapter
	 */
	protected ContentContainerTag(WalkerFactory factory, Object tag) { super(factory, tag); }

	/**
	 * @see HtmlWalker.ITag#contentType()
	 */
	@Override
	public ContentType contentType() { return ContentType.TAG; }
	
	/**
	 * @see HtmlWalker.ITag#getTextValue()
	 */
	@Override
	public String getTextValue() { return null; }

	/**
	 * @see HtmlWalker.ITag#setTextValue(java.lang.String)
	 */
	@Override
	public void setTextValue(String text) {}

	/**
	 * @see HtmlWalker.ITag#ownedTags()
	 */
	@Override
    public TagList ownedTags()
    {
        if (this.tags == null)
            this.tags = new TagList(this).initialize(this.factory);
        return this.tags;
    }
	
	@Override
	public String ownedText() { return this.api.ownedText(tag()); }
}
