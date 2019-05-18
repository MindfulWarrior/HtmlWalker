package htmltest.base;

import htmlwalker.FormattedCloneWalker;
import htmlwalker.platform.WalkerPlatform;

public class FormattedCloneTestWalker extends TestWalker
{
    public FormattedCloneTestWalker(WalkerPlatform platform, WalkerPlatform.IOptions options)
    {
        super(platform, options);
        walkers.add(new FormattedCloneWalker(output()));
    }
}
