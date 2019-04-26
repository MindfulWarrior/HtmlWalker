using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;

namespace HtmlWalker.Tag.Html
{
    /// <summary>
    ///   This class houses the HTML <b>&lt;meta&gt;</b> tag object and provides the <see cref="ITag"/> interface.
    ///   
    ///   Implements <see cref="ContentTextTag"/>
    /// </summary>
    /// <author>Robert R Flores</author>
    public class TagMeta : ContentTextTag
    {
        /// <summary>
        ///   Constructor for housing a new <b>&lt;meta&gt;</b> tag
        /// </summary>
        /// <param name="factory">
        ///   used to produce the new HTML tag and other objects as per the specific platform
        /// </param>
        public TagMeta(WalkerPlatform.WalkerFactory factory) : base(factory, factory.CreateMeta()) { }

        /// <summary>
        ///   Constructor for housing a existing <b>&lt;meta&gt;</b> tag
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="tag">object managed by the adapter</param>
        public TagMeta(WalkerPlatform.WalkerFactory factory, object tag) : base(factory, tag) { }

        /// <summary>
        ///   Implements <see cref="ITag.Visit(ITagVoidVisitor)"/>
        /// </summary>
        public override void Visit(ITagVoidVisitor visitor) { visitor.Visit(this); }

        /// <summary>
        ///   Implements <see cref="ITag.Visit{T}(ITagGenericVisitor{T})"/>
        /// </summary>
        public override T Visit<T>(ITagGenericVisitor<T> visitor) { return visitor.Visit(this); }

        /// <summary>
        ///   Implement <see cref="ITag.TextValue"/>
        /// </summary>
        public override string TextValue { get => Attributes["content"]; set => Attributes["content"] = value; }
    }
}