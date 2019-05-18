package htmlwalker.tag.util;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

public class Eol extends Text
{

    public Eol(WalkerFactory factory) { super(factory, System.lineSeparator()); }

    public Eol(WalkerFactory factory, int count) { super(factory, new String(new char[count]).replace("\0", System.lineSeparator())); }

    public Eol(WalkerFactory factory, String text) { super(factory, text); }

    public Eol(WalkerFactory factory, Object obj) { super(factory, obj); }

    @Override
    public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException { visitor.visit(this); }

    @Override
    public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException { return visitor.visit(this); }

    @Override
    public String name() { return "#eol"; }

}
