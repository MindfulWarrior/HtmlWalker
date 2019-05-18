package htmldoccleaner;

import htmlwalker.FormattedCloneWalker;
import htmlwalker.ITag;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerDocument;

public class DocCleanerWalker extends FormattedCloneWalker {
    public DocCleanerWalker(WalkerDocument document)
    {
        super(document);
        modifiers.add(new DocCleanerModifier(output.factory()));
    }

    @Override
    protected <T extends ITag> ITag handleTag(T adapter) throws HtmlWalkerException
    {
        var tag = super.handleTag(adapter);
        tag.attributes().clear();
        return tag;
    }

    @Override
    protected <T extends ITag> ITag startTag(T adapter) throws HtmlWalkerException
    {
        var tag = super.startTag(adapter);
        tag.attributes().clear();
        return tag;
    }
}
