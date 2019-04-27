using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;

namespace HtmlWalker.Tag.Html
{
    public class TagBig : ContentContainerTag
    {
        public TagBig(WalkerPlatform.WalkerFactory factory) : base(factory, factory.CreateBig()) { }

        public TagBig(WalkerPlatform.WalkerFactory factory, object tag) : base(factory, tag) { }

        public override void Visit(ITagVoidVisitor visitor) { visitor.Visit(this); }

        public override T Visit<T>(ITagGenericVisitor<T> visitor) { return visitor.Visit(this); }
    }
}
