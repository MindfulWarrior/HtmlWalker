package htmlwalker.tag.base;

import htmlwalker.platform.WalkerFactory;

public abstract class ContentUtilTag extends BaseTag
{
    public ContentUtilTag(WalkerFactory factory, Object tag) { super(factory, tag); }
	
	/**
	 * @see HtmlWalker.ITag#contentType()
	 */
	@Override
	public ContentType contentType() { return ContentType.UTIL; }
}
