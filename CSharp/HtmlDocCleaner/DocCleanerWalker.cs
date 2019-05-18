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
            // TODO add TagTrader
            Modifiers.Add(new DocCleanerModifier(Output.Factory));
        }

        protected override ITag HandleTag<T>(T adapter)
        {
            var tag = base.HandleTag(adapter);
            tag.Attributes.Clear();
            return tag;
        }

        protected override ITag StartTag<T>(T adapter)
        {
            var tag = base.StartTag(adapter);
            tag.Attributes.Clear();
            return tag;
        }
    }
}
