using HtmlWalker;
using HtmlWalker.Platform;
using HtmlWalker.Tag.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlDocCleaner
{
    public class DocCleanerWalker : FormattedCloneWalker
    {
        public DocCleanerWalker(WalkerPlatform.WalkerDocument document) : base(document)
        {
            Modifiers.Add(new DocCleanerModifier(Output.Factory));
        }
    }
}
