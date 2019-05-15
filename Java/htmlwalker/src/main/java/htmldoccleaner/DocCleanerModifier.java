package htmldoccleaner;

import htmlwalker.ITag;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.html.*;
import htmlwalker.tag.util.*;
import htmlwalker.visitor.EchoModifier;

public class DocCleanerModifier extends EchoModifier
{
    private WalkerFactory factory;

    public DocCleanerModifier(WalkerFactory factory)
    {
        this.factory = factory;
    }

    @Override
    public ITag visit(Comment adapter) { return new Skip(factory, adapter); }

    @Override
    public ITag visit(TagHead adapter)
    {
        var skip = new Skip(factory, adapter);
        skip.skipTree = true;
        return skip;
    }

    @Override
    public ITag visit(TagDiv adapter) { return new Skip(factory, adapter); }
}
