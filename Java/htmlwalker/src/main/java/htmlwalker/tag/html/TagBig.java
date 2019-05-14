package htmlwalker.tag.html;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.base.ContentContainerTag;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

public class TagBig extends ContentContainerTag
{
    public TagBig(WalkerFactory factory) { super(factory, factory.createBig()); }

    public TagBig(WalkerFactory factory, Object tag) { super(factory, tag); }

    @Override
    public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException { visitor.visit(this); }

    @Override
    public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException { return visitor.visit(this); }
}
