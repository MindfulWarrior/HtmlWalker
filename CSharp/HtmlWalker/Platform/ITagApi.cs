using System.Collections.Generic;

namespace HtmlWalker.Platform
{
    public abstract partial class WalkerPlatform
    {
        /// <summary>
        ///   The interface provides the platform specific implementation for the tag
        ///   adapters.
        ///
        ///   This is essentially a bridge between the platform specific implementation and
        ///   the tag adapter interface. Generally, this interface is used to in the
        ///   platform implementation but is not used directly when making use of the HTML
        ///   walker.
        /// </summary>
        /// <author>Robert R Flores</author>
        public interface ITagApi
        {
            /// <summary>
            ///   Returns the name of the housed HTML tag, such as 'html', 'body', 'p', etc
            /// </summary>
            string Name(object tag);

            /// <summary>
            ///   Access to the walker platform object specific to the HTML Walker implementation
            /// </summary>
            WalkerPlatform Platform { get; }

            /// <summary>
            ///   Gives the platorm specific way to get a tags inner text
            /// </summary>
            string GetText(object tag);

            void SetText(object tag, string text);

            string OwnedText(object tag);

            /// <summary>
            ///   Gives the platform specific way to get the 'script' text
            ///   in such HTML tags such as <b>&lt;script&gt;</b> and <b>&lt;style&gt;</b>
            /// </summary>
            string GetScript(object tag);

            void SetScript(object tag, string script);

            /// <summary>
            ///   Gives the platfrom specifice way to get attributes, used by <see cref="BaseTag.Attributes"/>
            ///   to implement <see cref="ITagApi.GetAttributes"/>
            /// </summary>
            /// <returns>map of attributes to values</returns>
            IDictionary<string, string> GetAttributes(object tag);

            /// <summary>
            ///   Gives the platfrom specifice way to get an attribute, used by <see cref="BaseTag.Attributes"/>
            ///   to implement <see cref="ITagApi.GetAttribute(string)"/>
            /// </summary>
            /// <param name="attr">attribute name</param>
            /// <returns>attribute value</returns>
            string GetAttribute(object tag, string attr);

            /// <summary>
            ///   Gives the platfrom specifice way to set an attribute, used by <see cref="BaseTag.Attributes"/>
            ///   to implement <see cref="ITagApi.SetAttribute(string, string)"/>
            /// </summary>
            /// <param name="attr">attribute name</param>
            /// <param name="value">attribute value</param>
            void SetAttribute(object tag, string attr, string value);

            /// <summary>
            ///   Provides the platform specific way to add an HTML tag to the content
            /// </summary>
            /// <param name="tag">the HTML tag object</param>
            void Add(object tag, ITag adapter);

            void Remove(object tag, ITag adapter);

            void Insert(object tag, int index, ITag adapter);
        }
    }
}