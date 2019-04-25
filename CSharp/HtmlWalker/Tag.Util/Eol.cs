using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;
using System;
using System.Linq;

namespace HtmlWalker.Tag.Util
{
    /// <summary>
    ///   Special text tag to contain EOLs characters
    /// </summary>
    /// <author>Robert R Flores</author>
    public class Eol : Text
    {
        /// <summary>
        ///   Instantiates a new entity adapter
        /// </summary>
        /// <param name="factory">the tag that owns the text</param>
        /// <param name="count">Number of Eols</param>
        public Eol(WalkerPlatform.WalkerFactory factory, int count = 1)
            : this(factory, String.Concat(Enumerable.Repeat(Environment.NewLine, count))) { }

        /// <summary>
        ///   Instantiates a new entity adapter
        /// </summary>
        /// <param name="factory">the tag that owns the text</param>
        /// <param name="text">the entity string</param>
        public Eol(WalkerPlatform.WalkerFactory factory, string text) : base(factory, text) { }

        /// <summary>
        ///   Constructor for housing a existing text
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="obj">object managed by the adapter</param>
        public Eol(WalkerPlatform.WalkerFactory factory, object obj) : base(factory, obj) { }

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
        public override string Name => "#eol";
    }
}
