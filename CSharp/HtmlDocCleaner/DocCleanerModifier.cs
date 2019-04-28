using HtmlWalker;
using HtmlWalker.Platform;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;
using HtmlWalker.Visitor;
using System;
using System.Collections.Generic;
using System.Text;
using static HtmlWalker.Platform.WalkerPlatform;

namespace HtmlDocCleaner
{
    public class DocCleanerModifier : EchoModifer
    {
        private WalkerFactory factory;
        public DocCleanerModifier(WalkerFactory Factory)
        {
            this.factory = Factory;
        }

        public override ITag Visit(Comment adapter) => new Skip(factory, adapter);

        public override ITag Visit(TagHead adapter) => new Skip(factory, adapter) { SkipTree = true };

        public override ITag Visit(TagDiv adapter) => new Skip(factory, adapter);
    }
}
