package htmldoccleaner;

import htmlwalker.FormattedCloneWalker;
import htmlwalker.platform.WalkerDocument;

public class DocCleanerWalker extends FormattedCloneWalker
{
    public DocCleanerWalker(WalkerDocument document)
    {
        super(document);
        modifiers.add(new DocCleanerModifier(output.factory()));
    }
}
