/*
 * 
 */
package htmlwalker.tag.html;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.base.ContentNoneTag;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

/**
 * This class houses the HTML <b>&lt;input&gt;</b> tag object and provides the ITag interface.
 * 
 * @author Robert Flores
 * @see HtmlWalker.ITag
 */
public class TagInput extends ContentNoneTag
{
	/**
	 * Constructor for housing a new <b>&lt;input&gt;</b> tag.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 */
	public TagInput(WalkerFactory factory) { super(factory, factory.createInput()); }

	/**
	 * Constructor for housing an exsiting <b>&lt;input&gt;</b> tag.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 * @param tag - object housed by this tag adapter
	 */
	public TagInput(WalkerFactory factory, Object tag) { super(factory, tag); }

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
