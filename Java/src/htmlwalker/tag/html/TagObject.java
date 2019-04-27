/*
 * 
 */
package htmlwalker.tag.html;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.base.ContentContainerTag;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

/**
* This class houses the HTML <b>&lt;object&gt;</b> tag object and provides the ITag interface.
* 
* @author Robert Flores
* @see HtmlWalker.ITag
*/
public class TagObject extends ContentContainerTag
{
	/**
	 * Constructor for housing a new <b>&lt;object&gt;</b> tag.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 */
	public TagObject(WalkerFactory factory) { super(factory, factory.createObject()); }

	/**
	 * Constructor for housing an existing <b>&lt;object&gt;</b> tag.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 * @param tag - object housed by this tag adapter
	 */
	public TagObject(WalkerFactory factory, Object tag) { super(factory, tag); }
	
	/**
	 * Visit.
	 *
	 * @param visitor the visitor
	 * @throws HtmlWalkerException the html walker exception
	 * @see HtmlWalker.ITag#visit(HtmlWalker.ITagVoidVisitor)
	 */
	@Override
	public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException
	{
		visitor.visit(this);
	}

	/**
	 * Visit.
	 *
	 * @param <T> the generic type
	 * @param visitor the visitor
	 * @return the t
	 * @throws HtmlWalkerException the html walker exception
	 * @see HtmlWalker.ITag#visit(HtmlWalker.ITagGenericVisitor)
	 */
	@Override
	public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException
	{
		return visitor.visit(this);
	}

}
