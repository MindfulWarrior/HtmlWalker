/*
 * 
 */
package htmlwalker.tag.util;

import htmlwalker.ITag;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.base.BaseTag;
import htmlwalker.tag.base.ContentUtilTag;
import htmlwalker.tag.base.TagList;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

/**
 * This class exist to house a tag object meant to not be process or 'skipped'.
 * 
 * @author Robert Flores
 * @see HtmlWalker.ITag
 */
public class Skip extends ContentUtilTag
{

	/** The tag object housed by the adapter. */
	private TagList tags = null;
	
	private final BaseTag nodeOwner;
	
	public final BaseTag skippedTag;

	// TODO: need to make this readonly/final
    public boolean skipTree;

	public Skip(WalkerFactory factory, ITag adapter)
	{
		super(factory, adapter.tag());
		this.skippedTag = (BaseTag)adapter;
		
        ITag nodeOwner = adapter.owner();
        while (nodeOwner != null && nodeOwner.contentType() == ContentType.SKIP)
            nodeOwner = nodeOwner.owner();
        this.nodeOwner = (BaseTag)nodeOwner;

        if (nodeOwner != null)
        {
            if (adapter.ownedTags() != null)
            {
                for (ITag tag : adapter.ownedTags())
                    ownedTags().add(tag);
            }
        }

        if (owner() != null)
        {
        	owner().ownedTags().tags.add(this);
        	owner().ownedTags().tags.remove(adapter);
            this.nodeOwner.api.remove(tag(), adapter);
        }
		
	}

	@Override
	public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException { }

	@Override
	public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException { return null; }
	
	@Override
	public ContentType contentType() { return ContentType.SKIP; }
	
	@Override
	public String name() { return "#skip"; }
	
	@Override
	public ITag owner() { return this.skippedTag.owner(); }
	
	@Override
	public String getTextValue() { return tag().toString(); }

	@Override
	public void setTextValue(String text) { }

	@Override
	public TagList ownedTags()
	{
        if (this.tags == null)
            this.tags = new TagList(this, skipTree ? skippedTag : nodeOwner).initialize(this.factory);
        return this.tags;
	}

	@Override
	public String ownedText() { return skippedTag.ownedText(); }

}
