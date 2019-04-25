using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;

namespace HtmlWalker.Tag.Html
{
    /// <summary>
    ///   This class houses the HTML <b>&lt;br&gt;</b> tag object and provides the <see cref="ITag"/> interface.
    ///   
    ///   Implements <see cref="ContentNoneTag"/>
    /// </summary>
    /// <author>Robert R Flores</author>
    public class TagBr : ContentNoneTag
    {
        /// <summary>
        ///   Constructor for housing a new <b>&lt;br&gt;</b> tag
        /// </summary>
        /// <param name="factory">
        ///   used to produce the new HTML tag and other objects as per the specific platform
        /// </param>
        public TagBr(WalkerPlatform.WalkerFactory factory) : base(factory, factory.CreateBr()) { }

        /// <summary>
        ///   Constructor for housing a existing <b>&lt;br&gt;</b> tag
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="tag">object managed by the adapter</param>
        public TagBr(WalkerPlatform.WalkerFactory factory, object tag) : base(factory, tag) { }

        /// <summary>
        ///   Implements <see cref="ITag.Visit(ITagVoidVisitor)"/>
        /// </summary>
        public override void Visit(ITagVoidVisitor visitor) { visitor.Visit(this); }

        /// <summary>
        ///   Implements <see cref="ITag.Visit{T}(ITagGenericVisitor{T})"/>
        /// </summary>
        public override T Visit<T>(ITagGenericVisitor<T> visitor) { return visitor.Visit(this); }
    }
}