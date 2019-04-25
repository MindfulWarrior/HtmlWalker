using HtmlWalker.Core;
using System.Text;

namespace HtmlWalker.Platform
{
    /// <summary>
    ///   This abstract class is overwritten to provide the basis for each specific platform used by an HTML Walker.
    ///   Developers implement this class as the main point to interact with their implementation.
    ///   The WalkerPlatform is expected to be implemented as a singleton.
    /// </summary>
    /// <author>Robert R Flores</author>
    public abstract partial class WalkerPlatform
    {
        /// <summary>
        ///   Defines shared and platform specific document options 
        /// </summary>
        public interface IOptions
        {
            /// <summary>
            ///   Access to witch <see cref="System.Text.Encoding"/> is used
            /// </summary>
            Encoding Encoding { get; set; }

            /// <summary>
            ///   If <b>true</b>, break text in to <see cref="Text"/> and <see cref="Eol"/> tags.
            /// </summary>
            bool ProvideEol { get; set; }

            /// <summary>
            ///   Convert raw text to entities using <see cref="EscHandler.Escape(string)"/>
            ///   Unlike <see cref="WalkerPlatform.KeepEntities(bool)"/>, this is regardless of platform
            ///   and assumes enties already converted before becomming <see cref="Walker.Input"/>
            /// </summary>
            bool ConvertToEntities { get; set; }
        }

        /// <summary>
        ///   This method is used by other classes to preserve/restore HTML entities.
        ///   Thought this method the <b>EscHandler</b> is used depending on whether
        ///   <b>keepEntities</b> returns true.
        ///   <see cref="EscHandler"/>
        /// </summary>
        /// <param name="content"></param>
        /// <param name="attribute"></param>
        /// <returns>content modified if necessary to preserve/restore entitie</returns>
        public string HandleEntities(string content, bool attribute)
        {
            string text;

            if (KeepEntities(attribute))
                text = EscHandler.Instance.Escape(content);
            else
                text = content;

            return text;
        }

        /// <summary>
        ///   This method is overwritten to determine whether entities need to be preserved/restored.
        ///   The Platform uses this method to determine if the EscHandler is needed.
        ///   <see cref="EscHandler"/>
        /// </summary>
        /// <param name="attribute">whether or not the content is from a tag attribute</param>
        /// <returns>true, if entities need to be preserved/restored</returns>
        protected abstract bool KeepEntities(bool attribute);

        /// <summary>
        ///   Property defined to identify the platform for testing and other uses.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        ///   <b>true</b> if this platform is XHTML
        /// </summary>
        public abstract bool IsXml { get; }

        /// <summary>
        ///   Create the platform specific implementation of <see cref="IOptions"/>
        /// </summary>
        /// <returns>an <see cref="IOptions"/> objet</returns>
        public abstract IOptions NewDocumentOptions();

        /// <summary>
        ///   Instantiates a new walker document for the specific platform.
        ///   <see cref="EscHandler"/>
        /// </summary>
        /// <param name="options">platorm specific structure to set document options</param>
        /// <returns>the walker document</returns>
        public abstract WalkerDocument NewDocument(IOptions options = null);

        /// <summary>
        ///   Instantiates a new walker document for the specific platform
        ///   <see cref="WalkerDocument"/>
        /// </summary>
        /// <param name="adapter">document adapter holding root tag</param>
        /// <param name="options">platorm specific structure to set document options</param>
        /// <returns>the walker document</returns>
        public abstract WalkerDocument NewDocument(DocumentTag adapter, IOptions options = null);

        /// <summary>
        ///   Instantiates a new walker document from an existing file for the specific platform
        ///   <see cref="WalkerDocument"/>
        /// </summary>
        /// <param name="path">path to the existing file</param>
        /// <param name="options">platorm specific structure to set document options</param>
        /// <returns>the walker document</returns>
        public abstract WalkerDocument NewDocument(string path, IOptions options = null);
    }
}
