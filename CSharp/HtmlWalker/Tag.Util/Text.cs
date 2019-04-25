using System;
using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;
using HtmlWalker.Core;

namespace HtmlWalker.Tag.Util
{
    /// <summary>
    ///   This class holds string text and functions as a tag adapter.
    ///
    ///   While this class implements the ITag interface it houses text,
    ///   not an HTML tag.It purpose is to act as a tag adapter for
    ///   specific platforms that need it.
    ///   
    ///   Implements <see cref="ContentUtilTag"/>
    /// </summary>
    /// <author>Robert R Flores</author>
    public class Text : ContentUtilTag
    {
        /// <summary>
        ///   Instantiates a new text adapter
        /// </summary>
        /// <param name="factory">the tag that owns the text</param>
        /// <param name="text">the text string</param>
        public Text(WalkerPlatform.WalkerFactory factory, string text) : base(factory, factory.CreateText(text)) { }

        /// <summary>
        ///   Constructor for housing a existing text
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="obj">object managed by the adapter</param>
        public Text(WalkerPlatform.WalkerFactory factory, object obj) : base(factory, obj) { }

        #region ITag implementations

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
        public override string Name => "#text";

        /// <summary>
        ///   Implements <see cref="ITag.TextValue"/>
        /// </summary>
        public override string TextValue
        {
            get
            {
                if (Factory.ConvertToEntities)
                    return EscHandler.Instance.Escape(Api.GetText(Tag));
                else
                    return Api.GetText(Tag);
            }

            set
            {
                if (Factory.ConvertToEntities)
                    Api.SetText(Tag, EscHandler.Instance.Escape(value));
                else
                    Api.SetText(Tag, value);
            }
        }

        /// <summary>
        ///   Implements <see cref="ITag.OwnedTags"/>
        /// </summary>
        public override TagList OwnedTags => null;

        /// <summary>
        ///   Implement <see cref="ITag.OwnedText"/>
        /// </summary>
        public override string OwnedText => TextValue;

        #endregion

        /// <summary>
        ///   Overrides <see cref="ToString"/>
        /// </summary>
        /// <returns>'text' owned by tag</returns>
        public override string ToString() => TextValue;
    }
}