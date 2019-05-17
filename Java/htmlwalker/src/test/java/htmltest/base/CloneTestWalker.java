package htmltest.base;

import htmlwalker.CloneWalker;
import htmlwalker.platform.WalkerPlatform;

public class CloneTestWalker extends TestWalker
{
    public CloneTestWalker(WalkerPlatform platform, WalkerPlatform.IOptions options)
    {
        super(platform, options);
        walkers.add(new CloneWalker(output()));
    }

    public CloneTestWalker(WalkerPlatform platform)
    {
        this(platform, null);
    }
}
