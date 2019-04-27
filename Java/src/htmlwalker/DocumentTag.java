package htmlwalker;

import java.util.Iterator;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.base.ContentUtilTag;
import htmlwalker.tag.base.TagList;
import htmlwalker.tag.html.TagBody;
import htmlwalker.tag.html.TagHead;
import htmlwalker.tag.html.TagHtml;
import htmlwalker.visitor.ITagGenericVisitor;
import htmlwalker.visitor.ITagVoidVisitor;

public class DocumentTag extends ContentUtilTag
{
    private TagList tags = null;
    private TagHtml html = null;
    private TagHead head = null;
    private TagBody body = null;

    public DocumentTag(WalkerFactory factory, Object tag) { super(factory, tag); }

	@Override
	public void visit(ITagVoidVisitor visitor) throws HtmlWalkerException
	{
    	visitor.visit(this);
    }

	@Override
	public <T> T visit(ITagGenericVisitor<T> visitor) throws HtmlWalkerException
	{
		return visitor.visit(this);
	}

	@Override
	public String getTextValue() { return null; }

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
	public String ownedText() { return this.api.ownedText(tag()); }
	
	public TagHtml htmlTag()
	{
		if (this.html != null)
			return this.html;

		Iterator<ITag> itr = ownedTags().tags.iterator();
		while (itr.hasNext() && this.html == null) {
			ITag tag = itr.next();
			if (tag.name() == "html")
				this.html = (TagHtml)tag;
		}
		
		return this.html;
	}
	
	public TagHead headTag()
	{
		if (this.head != null)
			return this.head;

		Iterator<ITag> itr = ownedTags().tags.iterator();
		while (itr.hasNext() && this.head == null) {
			ITag tag = itr.next();
			if (tag.name() == "head")
				this.head = (TagHead)tag;
		}
		
		return this.head;
	}
	
	public TagBody bodyTag()
	{
		if (this.body != null)
			return this.body;

		Iterator<ITag> itr = ownedTags().tags.iterator();
		while (itr.hasNext() && this.body == null) {
			ITag tag = itr.next();
			if (tag.name() == "body")
				this.body = (TagBody)tag;
		}
		
		return this.body;
	}
}
