package htmldoccleaner;

import htmljsoupwalker.HtmlPlatform;
import htmlwalker.JoinedWalker;
import htmlwalker.TagTraceWalker;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerPlatform;
import xhtmldomwalker.XhtmlDomPlatform;

public class App {
    public static void main(String[] args)
    {
        var cmdLine = new CmdLine();
        if (cmdLine.read(args)) {
            WalkerPlatform platform;
            if (cmdLine.isXhtml())
                platform = XhtmlDomPlatform.theInstance;
            else
                platform = HtmlPlatform.theInstance;

            var options = platform.newDocumentOptions();
            options.setProvideEol(true);

            try
            {
                var input = platform.newDocument(cmdLine.input(), options);
                var output = platform.newDocument(options);
                var walker = new JoinedWalker();
                walker.walkers.add(new TagTraceWalker());
                walker.walkers.add(new DocCleanerWalker(output));
                walker.visit(input.documentTag());
                output.save(cmdLine.output());
            }
            catch (HtmlWalkerException e)
            {
                // TODO Auto-generated catch block
                e.printStackTrace();
            }
        }
    }
}
