/*
 * 
 */
package htmlwalker.tag.base;

import java.util.Map.Entry;

import htmlwalker.ITag;
import htmlwalker.core.TagAttributes;
import htmlwalker.platform.ITagApi;
import htmlwalker.platform.WalkerFactory;

/**
 * This abstract class provides the foundation for all of the ITag adapter
 * classes. Code which is common among them is implemented here.
 * 
 * @author Robert Flores
 */
public abstract class BaseTag implements ITag
{
	private ITag owner = null;
	
	private final Object tag; 
	private final TagAttributes attributes;
	
	protected final WalkerFactory factory;
	
	/** Holds the ITagApi implementation for the housed tag object. */
	public final ITagApi api;
	
	/**
	 * Instantiates a new base tag adapter.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 * @param tag - object housed by this tag adapter
	 */
	BaseTag(WalkerFactory factory, Object tag)
	{
		this.factory = factory;
		this.tag = tag;
		this.api = factory.api();
		this.attributes = new TagAttributes(this, this.api);
	}
	
	/**
	 * @see HtmlWalker.ITag#name()
	 */
	@Override
	public String name() { return this.api.name(tag); }
	
	@Override
	public ITag owner() { return this.owner; }
	
	public void owner(ITag tag) { this.owner = tag; }
	
	/**
	 * @see HtmlWalker.ITag#tag()
	 */
	@Override
	public Object tag() { return this.tag; }

	@Override
	public TagAttributes attributes() { return this.attributes; }
	
	/**
	 * This method is class to create a clone of the given.
	 *
	 * @param <T> - the tag adapter class
	 * @param source - the original tag adapter
	 * @return the new cloned tag adapter
	 */
	public ITag clone(WalkerFactory factory, ITag owner)
	{
		Object tagObj = factory.cloneTag(tag());
		ITag adapter = factory.createAdapter(owner, tagObj, name());
	
        if (contentType() == ContentType.TEXT || contentType() == ContentType.SCRIPT)		
        	adapter.setTextValue(getTextValue());
	
        for (Entry<String, String> attr : attributes().entrySet())
        	adapter.attributes().put(attr.getKey(), attr.getValue());
        
		if (owner != null && owner.contentType() == ContentType.TAG)
            owner.ownedTags().add(adapter);
		
		return adapter;
	}	
}
