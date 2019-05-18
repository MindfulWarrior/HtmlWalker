using HtmlWalker;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;
using HtmlWalker.Visitor;
using static HtmlWalker.Platform.WalkerPlatform;

namespace HtmlDocCleaner
{
    public class DocCleanerModifier : EchoModifer
    {
        private WalkerFactory factory;
        public DocCleanerModifier(WalkerFactory factory)
        {
            this.factory = factory;
        }

        public override ITag Visit(Comment adapter) => new Skip(factory, adapter);

        public override ITag Visit(TagHead adapter) => new Skip(factory, adapter) { SkipTree = true };

        public override ITag Visit(TagDiv adapter) => new Skip(factory, adapter);
    }
}
