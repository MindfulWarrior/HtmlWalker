package htmldoccleaner;

import htmljsoupwalker.HtmlPlatform;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.platform.WalkerPlatform;
import xhtmldomwalker.XhtmlDomPlatform;

public class App {
    public static void main(String[] args) {
        if (CmdLine.read(args)) {
            WalkerPlatform platform;
            if (CmdLine.isXhtml())
                platform = XhtmlDomPlatform.theInstance;
            else
                platform = HtmlPlatform.theInstance;

            var options = platform.newDocumentOptions();
            options.setProvideEol(true);

            try
            {
                var input = platform.newDocument(CmdLine.input(), options);
                var output = platform.newDocument();
                var walker = new DocCleanerWalker(output);
                walker.visit(input.documentTag());
                output.save(CmdLine.output());
            }
            catch (HtmlWalkerException e)
            {
                // TODO Auto-generated catch block
                e.printStackTrace();
            }
        }
    }
}
