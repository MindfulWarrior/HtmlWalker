package htmltest.base;

import htmlwalker.CloneWalker;
import htmlwalker.FormattedCloneWalker;
import htmlwalker.JoinedWalker;
import htmlwalker.TagTraceWalker;
import htmlwalker.platform.WalkerDocument;
import htmlwalker.platform.WalkerPlatform;

public class TestWalker extends JoinedWalker
{
	private final WalkerDocument output;

    public final TagTraceWalker tracer;

    public TestWalker(WalkerPlatform platform, boolean formatted)
    {
    	super();
    	
    	output = platform.newDocument();
        tracer = new TagTraceWalker();
        
        CloneWalker cloner;
        if (formatted && !platform.isXml())
        	cloner = new FormattedCloneWalker(output);
        else
        	cloner = new CloneWalker(output);

        walkers.add(tracer);
        walkers.add(cloner);
    }
    
    public TestWalker(WalkerPlatform platform)
    {
    	this(platform, false);
    }

    public WalkerDocument output() { return output; }
}
