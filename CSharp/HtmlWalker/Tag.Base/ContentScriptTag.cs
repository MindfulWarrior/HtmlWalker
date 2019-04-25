using HtmlWalker.Core;
using HtmlWalker.Platform;

namespace HtmlWalker.Tag.Base
{
    /// <summary>
    ///   This class is used to support implementation tag adapters for HTML tags that only have <b>script</b> content
    /// </summary>
    /// <author>Robert R Flores</author>
    public abstract class ContentScriptTag : BaseTag
    {
        /// <summary>
        ///   Instantiates a new content script tag
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="tag">object housed by this tag adapter</param>
        public ContentScriptTag(WalkerPlatform.WalkerFactory factory, object tag) : base(factory, tag) { }

        /// <summary>
        ///   Implement <see cref="ITag.ContentType"/>
        /// </summary>
        /// <returns><see cref="ContentType.SCRIPT"/></returns>
        public override ContentType ContentType => ContentType.SCRIPT;

        /// <summary>
        ///   Implement <see cref="ITag.TextValue"/>
        /// </summary>
        public override string TextValue { get => Api.GetScript(Tag); set => Api.SetScript(Tag, value); }

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