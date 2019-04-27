using HtmlWalker.Core;
using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;

namespace HtmlWalker.Tag.Util
{
    /// <summary>
    ///   Holds an HTML entity
    /// </summary>
    /// <author>Robert R Flores</author>
    public class Entity : Text
    {
        /// <summary>
        ///   Instantiates a new entity adapter
        /// </summary>
        /// <param name="factory">the tag that owns the text</param>
        /// <param name="entity">the entity string</param>
        public Entity(WalkerPlatform.WalkerFactory factory, string entity) : this(factory, factory.CreateEntityNode(entity)) { }

        /// <summary>
        ///   Constructor for housing a existing text
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="obj">object managed by the adapter</param>
        public Entity(WalkerPlatform.WalkerFactory factory, object obj) : base(factory, obj) { }

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
        public override string Name => "#entity";

        /// <summary>
        ///   Implements <see cref="ITag.TextValue"/>
        /// </summary>
        public override string TextValue
        {
            get => EscHandler.Instance.Escape(Api.GetText(Tag)); set => Api.SetText(Tag, value);
        }
    }
}
