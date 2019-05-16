package htmltest.base;

import htmlwalker.FormattedCloneWalker;
import htmlwalker.platform.WalkerPlatform;

public class FormattedCloneTestWalker extends TestWalker
{
    public FormattedCloneTestWalker(WalkerPlatform platform)
    {
        super(platform);
        walkers.add(new FormattedCloneWalker(output()));
    }
}
