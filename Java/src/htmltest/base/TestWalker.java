package htmltest.base;

import htmlwalker.CloneWalker;
import htmlwalker.JoinedWalker;
import htmlwalker.TagTraceWalker;
import htmlwalker.platform.WalkerDocument;
import htmlwalker.platform.WalkerPlatform;

public class TestWalker extends JoinedWalker
{
	private final WalkerDocument output;

    public final TagTraceWalker tracer;

    public TestWalker(WalkerPlatform platform)
    {
    	super();
    	
    	output = platform.newDocument();
        tracer = new TagTraceWalker();
        
        CloneWalker cloner = new CloneWalker(output);

        walkers.add(tracer);
        walkers.add(cloner);
    }

    public WalkerDocument output() { return output; }
}
