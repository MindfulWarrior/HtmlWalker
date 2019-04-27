/*
 * 
 */
package htmlwalker.tag.util;

import htmlwalker.core.EscHandler;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.base.ContentUtilTag;
import htmlwalker.tag.base.TagList;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

/**
 * This class holds string text and functions as a tag adapter.
 * 
 * While this class implements the ITag interface it houses text,
 * not an HTML tag. It purpose is to act as a tag adapter for
 * specific platforms that need it.
 * 
 * @author Robert Flores
 */
public class Text extends ContentUtilTag
{

	/**
	 * Instantiates a new text adapter.
	 *
	 * @param owner - the tag that owns the text
	 * @param text - the text string
	 */
	public Text(WalkerFactory factory, String text) { super(factory, factory.createText(text)); }
	
	public Text(WalkerFactory factory, Object tag) { super(factory, tag); }
	
	/**
	 * @see HtmlWalker.ITag#visit(HtmlWalker.ITagVoidVisitor)
	 */
	@Override
	public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException { visitor.visit(this); }

	/**
	 * @see HtmlWalker.ITag#visit(HtmlWalker.ITagGenericVisitor)
	 */
	@Override
	public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException { return visitor.visit(this); }

	/**
	 * @see HtmlWalker.ITag#name()
	 */
	@Override
	public String name() { return "#text"; }

	@Override
	public String getTextValue()
	{
        if (this.factory.convertToEntities)
            return EscHandler.theInstance.escape(this.api.getText(tag()));
        else
            return this.api.getText(tag());
	}

	@Override
	public void setTextValue(String text)
	{
		if (this.factory.convertToEntities)
			this.api.setText(tag(), EscHandler.theInstance.escape(text));
		else
			this.api.setText(tag(), text);
	}

	@Override
	public TagList ownedTags() { throw new UnsupportedOperationException(); }
	
	/**
	 * @see java.lang.Object#toString()
	 */
	@Override
	public String toString() { return getTextValue(); }

	@Override
	public String ownedText() { return getTextValue(); }

}
