package htmltest.base;

import htmlwalker.CloneWalker;
import htmlwalker.platform.WalkerPlatform;

public class CloneTestWalker extends TestWalker
{
    public CloneTestWalker(WalkerPlatform platform)
    {
        super(platform);
        walkers.add(new CloneWalker(output()));
    }
}
