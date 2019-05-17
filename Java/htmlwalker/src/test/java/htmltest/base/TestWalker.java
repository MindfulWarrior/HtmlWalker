package htmltest.base;

import htmlwalker.JoinedWalker;
import htmlwalker.TagTraceWalker;
import htmlwalker.platform.WalkerDocument;
import htmlwalker.platform.WalkerPlatform;

public class TestWalker extends JoinedWalker
{
	private final WalkerDocument output;

    public final TagTraceWalker tracer = new TagTraceWalker();

    public TestWalker(WalkerPlatform platform, boolean formatted)
    {
    	super();
    	output = platform.newDocument();
        walkers.add(tracer);
        tracer.verbosity = 2;
    }
    
    public TestWalker(WalkerPlatform platform)
    {
    	this(platform, false);
    }

    public WalkerDocument output() { return output; }
}
