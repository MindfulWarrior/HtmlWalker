using HtmlWalker.Platform;

namespace HtmlWalker.Tag.Base
{
    /// <summary>
    ///   This class is used to support implementation tag adapters for HTML tags that only have <see cref="ITag.TextValue"/> content
    /// </summary>
    /// <author>Robert R Flores</author>
    public abstract class ContentTextTag : BaseTag
    {
        /// <summary>
        ///   Instantiates a new content text tag
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="tag">object housed by this tag adapter</param>
        public ContentTextTag(WalkerPlatform.WalkerFactory factory, object tag) : base(factory, tag) { }

        /// <summary>
        ///   Implement <see cref="ITag.ContentType"/>
        /// </summary>
        /// <returns><see cref="ContentType.TEXT"/></returns>
        public override ContentType ContentType => ContentType.TEXT;

        /// <summary>
        ///   Implement <see cref="ITag.TextValue"/>
        /// </summary>
        public override string TextValue { get => Api.GetText(Tag); set => Api.SetText(Tag, value); }

        /// <summary>
        ///   Impleents <see cref="ITag.OwnedTags"/>
        /// </summary>
        public override TagList OwnedTags => null;

        /// <summary>
        ///   Impleents <see cref="ITag.OwnedText"/>
        /// </summary>
        public override string OwnedText => TextValue;
    }
}
