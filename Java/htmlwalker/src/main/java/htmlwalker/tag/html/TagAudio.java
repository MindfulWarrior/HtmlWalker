/*
 * 
 */
package htmlwalker.tag.html;

import htmlwalker.exception.*;
import htmlwalker.platform.*;
import htmlwalker.tag.base.*;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

/**
 * This class houses the HTML <b>&lt;audio&gt;</b> tag object and provides the ITag interface.
 * 
 * @author Robert Flores
 * @see HtmlWalker.ITag
 */
public class TagAudio extends ContentContainerTag
{
	/**
	 * Constructor for housing a new <b>&lt;audio&gt;</b> tag audio.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 */
	public TagAudio(WalkerFactory factory) { super(factory, factory.createAudio()); }

	/**
	 * Constructor for housing an existing <b>&lt;audio&gt;</b> tag.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 * @param tag - object housed by this tag adapter
	 */
	public TagAudio(WalkerFactory factory, Object tag) { super(factory, tag); }
	
	/**
	 * @see HtmlWalker.ITag#visit(HtmlWalker.ITagVoidVisitor)
	 */
	@Override
	public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException
	{
		visitor.visit(this);
	}

	/**
	 * @see HtmlWalker.ITag#visit(HtmlWalker.ITagGenericVisitor)
	 */
	@Override
	public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException
	{
		return visitor.visit(this);
	}

}
