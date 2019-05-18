package htmltest.base;

import htmlwalker.JoinedWalker;
import htmlwalker.TagTraceWalker;
import htmlwalker.platform.WalkerDocument;
import htmlwalker.platform.WalkerPlatform;

public class TestWalker extends JoinedWalker
{
	private final WalkerDocument output;

    public final TagTraceWalker tracer = new TagTraceWalker();

    public TestWalker(WalkerPlatform platform, WalkerPlatform.IOptions options)
    {
    	super();
    	output = platform.newDocument(options);
        walkers.add(tracer);
        tracer.verbosity = 2;
    }
 
    public WalkerDocument output() { return output; }
}
