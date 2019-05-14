package htmlwalker.tag.util;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

public class Comment extends Text
{
    public Comment(WalkerFactory factory, String text) { super(factory, text); }

    public Comment(WalkerFactory factory, Object obj) { super(factory, obj); }

    @Override
    public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException { visitor.visit(this); }

    @Override
    public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException { return visitor.visit(this); }

    @Override
    public String name() { return "#comment"; }
}
