package htmlwalker.tag.util;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.base.ContentUtilTag;
import htmlwalker.tag.base.TagList;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

public class Unknown extends ContentUtilTag
{
    private TagList tags = null;

    public Unknown(WalkerFactory factory, Object tag) { super(factory, tag); }

    @Override
    public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException { visitor.visit(this);  }

    @Override
    public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException { return visitor.visit(this);  }

    @Override
    public String name() { return "#unknown"; }

	@Override
	public String getTextValue() { return tag().toString(); }

	@Override
	public void setTextValue(String text) { }

	@Override
	public TagList ownedTags()
	{
        if (this.tags == null)
            this.tags = new TagList(this).initialize(this.factory);
        return this.tags;
	}

	@Override
	public String ownedText() { return getTextValue(); }

}