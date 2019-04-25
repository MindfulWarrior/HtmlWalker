using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;

namespace HtmlWalker.Tag.Util
{
    public class Comment : Text
    {
        private static string CommentFormatted(string text)
        {
            if (!text.StartsWith("<!--"))
                text = "<!--" + text;
            if (!text.EndsWith("-->"))
                text = text + "-->";
            return text;
        }

        public Comment(WalkerPlatform.WalkerFactory factory, string text) : base(factory, CommentFormatted(text)) { }

        public Comment(WalkerPlatform.WalkerFactory factory, object obj) : base(factory, obj) { }

        /// <summary>
        ///   Implements <see cref="ITag.Visit(ITagVoidVisitor)"/>
        /// </summary>
        public override void Visit(ITagVoidVisitor visitor) { visitor.Visit(this); }

        /// <summary>
        ///   Implements <see cref="ITag.Visit{T}(ITagGenericVisitor{T})"/>
        /// </summary>
        public override T Visit<T>(ITagGenericVisitor<T> visitor) { return visitor.Visit(this); }

        /// <summary>
        ///  Override <see cref="BaseTag.Name"/> for one that identifies it utility function
        /// </summary>
        public override string Name => "#comment";

        /// <summary>
        ///   Implements <see cref="ITag.TextValue"/>
        /// </summary>
        public override string TextValue { get => Api.GetText(Tag); set => Api.SetText(Tag, value); }
    }
}
