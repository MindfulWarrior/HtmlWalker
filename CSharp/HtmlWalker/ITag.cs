using HtmlWalker.Core;
using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;

namespace HtmlWalker
{
    /// <summary>
    ///   Describes what the inner tag types are
    /// </summary>
    /// <author>Robert R Flores</author>
    public enum ContentType {
        /// <summary>
        ///   No content will be returned by <see cref="ITag.OwnedTags"/> or <see cref="ITag.TextValue"/>.
        ///   Identifies <see cref="ContentNoneTag"/>
        /// </summary>
        NONE,

        /// <summary>
        ///   Only string text available by <see cref="ITag.TextValue"/>.
        ///   Identifies <see cref="ContentTextTag"/> and <see cref="ContentNoneTag"/>
        /// </summary>
        TEXT,

        /// <summary>
        ///   Multiple tags available by <see cref="ITag.OwnedTags"/>.
        ///   No content from <see cref="ITag.TextValue"/>
        ///   Identifies <see cref="ContentContainerTag"/>
        /// </summary>
        TAG,

        /// <summary>
        ///   Only script text available by <see cref="ITag.TextValue"/>.
        ///   Text may be formatted differently than <see cref="ContentType.TEXT"/>.
        ///   Identifies <see cref="ContentScriptTag"/>
        /// </summary>
        SCRIPT,

        /// <summary>
        ///   For what is not defined as a normal HTML tag.
        ///   Whether there is <see cref="ITag.TextValue"/> or <see cref="ITag.OwnedTags"/>
        ///   depends on each subclass.
        ///   Identifies <see cref="ContentUtilTag"/>
        /// </summary>
        UTIL,

        /// <summary>
        ///   This tag is a place holder for when a tag is marked to be skipped
        ///   from processing.
        ///   Identifies <see cref="ContentUtilTag"/>
        /// </summary>
        SKIP,
    }

    /// <summary>
    ///   Interface describing an HTML tab
    /// </summary>
    /// <author>Robert R Flores</author>
    public interface ITag
    {
        /// <summary>
        ///  Call for the Vistor pattern
        /// </summary>
        /// <param name="visitor">vister object</param>
        void Visit(ITagVoidVisitor visitor);

        /// <summary>
        ///   Call for a Visitor pattern using Generics
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="visitor">vister object</param>
        /// <returns></returns>
        T Visit<T>(ITagGenericVisitor<T> visitor);

        /// <summary>
        ///   Access to any <see cref="ITag"/> owned by this tag
        /// </summary>
        ITag Owner { get; }

        /// <summary>
        /// Returns the enum <b>ContentType</b> for this tag adapter
        /// </summary>
        ContentType ContentType { get; }

        /// <summary>
        ///  Returns the HTML tag object housed by this tag adapter
        /// </summary>
        object Tag { get; }

        /// <summary>
        ///  Returns the tag name as in 'html', 'body', 'p' ...
        /// </summary>
        string Name { get; }

        /// <summary>
        ///   Gets/Sets the string content for tags that do not contain other tags
        ///   Applies to tags of content type<b>TEXT</b> and <b>SCRIPT</b>
        /// </summary>
        string TextValue { get; set; }

        /// <summary>
        ///   Access to the tags owned by this tag
        /// </summary>
        TagList OwnedTags { get; }

        /// <summary>
        ///   The sum of all the <see cref="TextValue"/> of the <see cref="OwnedTags"/>
        /// </summary>
        string OwnedText { get; }

        /// <summary>
        ///   Access to the HTML tag attributes
        /// </summary>
        TagAttributes Attributes { get; }

        /// <summary>
        ///   Creates a shallow clone of the adapter with a cloned HTML tag
        /// </summary>
        /// <param name="factory">factory used to create the clone</param>
        /// <param name="owner">tag to be atteched to. Can be null</param>
        /// <returns></returns>
        ITag Clone(WalkerPlatform.WalkerFactory factory, ITag owner);
    }
}
