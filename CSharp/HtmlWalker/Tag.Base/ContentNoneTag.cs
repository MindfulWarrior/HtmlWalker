using HtmlWalker.Platform;

namespace HtmlWalker.Tag.Base
{
    /// <summary>
    ///   This class is used to support implementation tag adapters for HTML tags that have no content
    /// </summary>
    /// <author>Robert R Flores</author>
    public abstract class ContentNoneTag : BaseTag
    {
        /// <summary>
        ///   Instantiates a new content none tag
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="tag">object housed by this tag adapter</param>
        public ContentNoneTag(WalkerPlatform.WalkerFactory factory, object tag) : base(factory, tag) { }

        /// <summary>
        ///   Implements <see cref="ITag.ContentType"/>
        /// </summary>
        /// <returns><see cref="ContentType.NONE"/></returns>
        public override ContentType ContentType => ContentType.NONE;

        /// <summary>
        ///   Implements s<see cref="ITag.TextValue"/>
        /// </summary>
        /// <remarks>This tag type always has no text, so always returns 'null'</remarks>
        public override string TextValue { get => null; set { } }

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