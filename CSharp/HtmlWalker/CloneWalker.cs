using HtmlWalker.Core;
using HtmlWalker.Platform;

namespace HtmlWalker
{
    /// <summary>
    ///   This class implements a walker class to produce a clone of existing HTML.
    ///   Meant for testing the walker class and to be subclassed for uses where HTML
    ///   is copied with slight changes.
    /// </summary>
    /// <author>Robert R Flores</author>
    public class CloneWalker : DocGeneratorWalker
    {
        protected override ITag GenerateTag<T>(T adapter) => adapter.Clone(Output.Factory, currentTag);

        /// <summary>
        ///   Instanitiates the WalkerCloner that strps no tag attributes
        /// </summary>
        /// <param name="platform">the singleton that gives platform specfic implementation</param>
        public CloneWalker(WalkerPlatform.WalkerDocument document) : base(document) { }
    }
}