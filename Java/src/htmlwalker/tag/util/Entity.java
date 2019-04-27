package htmlwalker.tag.util;

import htmlwalker.core.EscHandler;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

public class Entity extends Text
{
    public Entity(WalkerFactory factory, String entity) { super(factory, factory.createEntityNode(entity)); }
    
    public Entity(WalkerFactory factory, Object tag) { super(factory, tag); }

    @Override
    public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException { visitor.visit(this); }

    @Override
    public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException { return visitor.visit(this); }
    
    @Override
    public String name() { return "#entity"; }
    
    @Override
    public String getTextValue() { return EscHandler.theInstance.escape(this.api.getText(tag())); }
    
    @Override
    public void setTextValue(String text) { throw new IllegalStateException(); }

}
