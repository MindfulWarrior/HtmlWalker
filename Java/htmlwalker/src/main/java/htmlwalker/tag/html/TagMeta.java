/*
 * 
 */
package htmlwalker.tag.html;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.base.ContentTextTag;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

/**
* This class houses the HTML <b>&lt;meta&gt;</b> tag object and provides the ITag interface.
* 
* @author Robert Flores
* @see HtmlWalker.ITag
*/
public class TagMeta extends ContentTextTag
{
	/**
	 * Constructor for housing a new <b>&lt;meta&gt;</b> tag.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 */
	public TagMeta(WalkerFactory factory) { super(factory, factory.createMeta()); }

	/**
	 * Constructor for housing an existing <b>&lt;meta&gt;</b> tag.
	 *
	 * @param factory - used to produce objects as per the specific platform
	 * @param tag - object housed by this tag adapter
	 */
	public TagMeta(WalkerFactory factory, Object tag) { super(factory, tag); }

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

	@Override
	public String getTextValue() { return attributes().get("content"); }
	
	@Override
	public void setTextValue(String value) { attributes().put("content", value); }
}
