using HtmlWalker.Core;
using HtmlWalker.Platform;
using System;

namespace HtmlWalker.Tag.Base
{
    /// <summary>
    ///   This class is used to support implementation of tags that have other tags as
    ///   content with little restriction.
    ///    
    ///   This includes most tags.
    /// </summary>
    /// <author>Robert R Flores</author>
    public abstract class ContentContainerTag : BaseTag
    {
        private TagList tags = null;

        /// <summary>
        ///   Instantiates a new content container tag.
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="tag">object housed by this tag adapter</param>
        public ContentContainerTag(WalkerPlatform.WalkerFactory factory, Object tag) : base(factory, tag) { }

        /// <summary>
        ///   Implements <see cref="ITag.ContentType"/>
        /// </summary>
        /// <returns><see cref="ContentType.TAG"/></returns>
        public override ContentType ContentType => ContentType.TAG;

        /// <summary>
        ///   Implements <see cref="ITag.TextValue"/>
        /// </summary>
        /// <remarks>This tag type always has no text, so always returns 'null'</remarks>
        public override String TextValue { get => null; set { } }
        
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
        public override string OwnedText => Api.OwnedText(Tag);
    }
}
