using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;

namespace HtmlWalker.Tag.Html
{
    /// <summary>
    ///   This class houses the HTML <b>&lt;legend&gt;</b> tag object and provides the <see cref="ITag"/> interface.
    ///   
    ///   Implements <see cref="ContentContainerTag"/>
    /// </summary>
    /// <author>Robert R Flores</author>
    public class TagLegend : ContentContainerTag
    {
        /// <summary>
        ///   Constructor for housing a new <b>&lt;legend&gt;</b> tag
        /// </summary>
        /// <param name="factory">
        ///   used to produce the new HTML tag and other objects as per the specific platform
        /// </param>
        public TagLegend(WalkerPlatform.WalkerFactory factory) : base(factory, factory.CreateLegend()) { }

        /// <summary>
        ///   Constructor for housing a existing <b>&lt;legend&gt;</b> tag
        /// </summary>
        public TagLegend(WalkerPlatform.WalkerFactory factory, object tag) : base(factory, tag) { }

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