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
 * This class houses the HTML <b>&lt;dfn&gt;</b> tag object and provides the ITag interface.
 * 
 * @author Robert Flores
 * @see HtmlWalker.ITag
 */
public class TagDfn extends ContentContainerTag {

	/**
	 * Constructor for housing a new <b>&lt;dfn&gt;</b> tag.
	 *
	 * @param factory
	 *			the factory
	 */
	public TagDfn(WalkerFactory factory) {
		super(factory, factory.createDfn());
	}

	/**
	 * Constructor for housing an existing <b>&lt;dfn&gt;</b> tag.
	 *
	 * @param factory
	 *			the factory
	 * @param tag
	 *			the tag
	 */
	public TagDfn(WalkerFactory factory, Object tag) {
		super(factory, tag);
	}

	/**
	 * @see HtmlWalker.ITag#visit(HtmlWalker.ITagVoidVisitor)
	 */
	@Override
	public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException {
		visitor.visit(this);
	}

	/**
	 * @see HtmlWalker.ITag#visit(HtmlWalker.ITagGenericVisitor)
	 */
	@Override
	public <T> T visit(ITagGenericVisitor<T> visitor)
			throws HtmlWalkerException {
		return visitor.visit(this);
	}

}
