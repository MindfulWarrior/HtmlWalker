using HtmlWalker.Core;
using HtmlWalker.Platform;
using HtmlWalker.Tag.Util;

namespace HtmlWalker.Tag.Base
{
    /// <summary>
    ///   This class is used to support implementation tag adapters for what is not an HTML tag
    ///   but needs to be treated as a tag, such as <see cref="Text"/>.
    /// </summary>
    /// <author>Robert R Flores</author>
    public abstract class ContentUtilTag : BaseTag
    {
        /// <summary>
        ///   Instantiates a new content text tag
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="tag">object housed by this tag adapter</param>
        public ContentUtilTag(WalkerPlatform.WalkerFactory factory, object tag) : base(factory, tag) { }

        /// <summary>
        ///   Implement <see cref="ITag.ContentType"/>
        /// </summary>
        /// <returns><see cref="ContentType.UTIL"/></returns>
        public override ContentType ContentType => ContentType.UTIL;
    }
}
