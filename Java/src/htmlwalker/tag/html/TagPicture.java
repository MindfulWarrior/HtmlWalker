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
 * This class houses the HTML <b>&lt;picture&gt;</b> tag object and provides the ITag interface.
 * 
 * @author Robert Flores
 * @see HtmlWalker.ITag
 */
public class TagPicture extends ContentContainerTag
{
    public TagPicture(WalkerFactory factory) { super(factory, factory.createPicture()); }

    public TagPicture(WalkerFactory factory, Object tag) { super(factory, tag); }

	@Override
    public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException { visitor.visit(this); }

	@Override
    public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException { return visitor.visit(this); }
}
   