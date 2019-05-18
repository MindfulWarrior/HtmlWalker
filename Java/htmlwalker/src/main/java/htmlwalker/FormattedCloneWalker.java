/**
 * 
 */
package htmlwalker;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerDocument;
import htmlwalker.tag.html.*;
import htmlwalker.tag.util.*;

/**
 * This classes clones and does simple formatting.
 * 
 * @author Robert R Flores
 */
public class FormattedCloneWalker extends CloneWalker
{

    private ITag currentOwner()
    {
        ITag owner = currentTag;
        while (owner != null && owner.name() == "#skip")
            owner = owner.owner();
        return owner;
    }

	public FormattedCloneWalker(WalkerDocument document) { super(document); }

	@Override
    protected <T extends ITag> ITag handleTag(T adapter) throws HtmlWalkerException
    {
        ITag tag = super.handleTag(adapter);
        ITag owner = currentOwner();
        if (owner != null && tag.name() != "#skip")
        {
            if (owner.name() == "body")
                owner.ownedTags().add(new Eol(output.factory(), 2));
            else if (owner.name() == "head")
                owner.ownedTags().add(new Eol(output.factory()));
        }
        return tag;
    }

	@Override
    protected void endTag()
    {
        boolean skipped = (currentTag.name() == "#skip");
        super.endTag();
        if (!skipped)
        {
            ITag owner = currentOwner();
            if (owner != null)
            {
                if (owner.name() == "body")
                    owner.ownedTags().add(new Eol(output.factory(), 2));
                else if (owner.name() == "head")
                    owner.ownedTags().add(new Eol(output.factory()));
            }
        }
    }

	@Override
    public void start(TagHtml adapter) throws HtmlWalkerException
    {
        super.start(adapter);
        if (currentTag.name() != "#skip")
        	currentTag.ownedTags().add(new Eol(output.factory()));
    }

	@Override
    public void start(TagHead adapter) throws HtmlWalkerException
    {
        super.start(adapter);
        if (currentTag.name() != "#skip")
        	currentTag.ownedTags().add(new Eol(output.factory()));
    }

	@Override
    public void end(TagHead adapter)
    {
        boolean skipped = (currentTag.name() == "#skip");
        super.end(adapter);
        if (!skipped)
            currentTag.ownedTags().add(new Eol(output.factory()));
    }

	@Override
    public void start(TagBody adapter) throws HtmlWalkerException
    {
        super.start(adapter);
        if (currentTag.name() != "#skip")
        	currentTag.ownedTags().add(new Eol(output.factory(), 2));
    }

	@Override
    public void end(TagBody adapter)
    {
        boolean skipped = (currentTag.name() == "#skip");
        super.end(adapter);
        if (!skipped)
            currentTag.ownedTags().add(new Eol(output.factory()));
    }

	@Override
    public void handle(Eol adapter) throws HtmlWalkerException
    {
        ITag owner = currentOwner();
        if (
            owner != null &&
            owner.name() != "#skip" &&
            owner.name() != "body" &&
            owner.name() != "head" &&
            owner.name() != "html"
        )
            super.handle(adapter);
    }
}
