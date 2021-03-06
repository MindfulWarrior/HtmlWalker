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
 * This class houses the HTML <b>&lt;tt&gt;</b> tag object and provides the ITag interface.
 * 
 * @author Robert Flores
 * @see HtmlWalker.ITag
 */
public class TagTt extends ContentContainerTag
{
    public TagTt(WalkerFactory factory) { super(factory, factory.createTt()); }

    public TagTt(WalkerFactory factory, Object tag) { super(factory, tag); }

	@Override
    public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException { visitor.visit(this); }

	@Override
    public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException { return visitor.visit(this); }
}
