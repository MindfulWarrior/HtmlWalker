using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;

namespace HtmlWalker.Tag.Util
{
    /// <summary>
    ///   This tag adapter is usd to hold HTML tags that the <see cref="Walker"/>
    ///   failed t identify
    /// </summary>
    /// <author>Robert R Flores</author>
    public class Unknown : ContentUtilTag
    {
        private TagList tags = null;

        /// <summary>
        ///   Instantiates a new entity adapter
        /// </summary>
        /// <param name="factory">the tag that owns the text</param>
        /// <param name="text">the entity string</param>
        public Unknown(WalkerPlatform.WalkerFactory factory, string text) : base(factory, text) { }

        /// <summary>
        ///   Constructor for housing a existing text
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="obj">object managed by the adapter</param>
        public Unknown(WalkerPlatform.WalkerFactory factory, object obj) : base(factory, obj) { }

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
        public override string Name => "#unknown";

        /// <summary>
        ///   Implements <see cref="ITag.TextValue"/>
        /// </summary>
        public override string TextValue { get => Tag.ToString(); set { } }

        /// <summary>
        ///   Impleents <see cref="ITag.OwnedTags"/>
        /// </summary>
        public override TagList OwnedTags
        {
            get
            {
                if (this.tags == null)
                    this.tags = new TagList(this).Initialize(Factory);
                return this.tags;
            }
        }

        /// <summary>
        ///   Implement <see cref="ITag.OwnedText"/>
        /// </summary>
        public override string OwnedText => TextValue;
    }
}