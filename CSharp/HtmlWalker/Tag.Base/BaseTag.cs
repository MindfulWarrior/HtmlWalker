using HtmlWalker.Core;
using HtmlWalker.Platform;
using HtmlWalker.Visitor;

namespace HtmlWalker.Tag.Base
{
    /// <summary>
    ///   This abstract class provides the foundation for all of the ITag adapter classes.
    /// </summary>
    /// <remark>Code which is common among them is implemented here.</remark>
    /// <author>Robert R Flores</author>
    public abstract class BaseTag : ITag
    {
        private ITag owner = null;

        /// <summary>
        ///   Access to the <see cref=" WalkerPlatform.WalkerFactory"/> used to create this tag
        /// </summary>
        protected readonly WalkerPlatform.WalkerFactory Factory;

        /// <summary>
        ///   Instantiates a new base tag adapter.
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="tag">object housed by this tag adapter</param>
        public BaseTag(WalkerPlatform.WalkerFactory factory, object tag)
        {
            Tag = tag;
            Factory = factory;
            Attributes = new TagAttributes(this, Api);
        }

        /// <summary>
        ///   Holds the ITagApi implementation for the housed tag object.
        /// </summary>
        internal WalkerPlatform.ITagApi Api => Factory.Api;

        /// <summary>
        ///   Overrides <see cref="ToString"/>
        /// </summary>
        /// <returns>'text' owned by tag</returns>
	    public override string ToString() { return Tag != null ? Tag.ToString() : base.ToString(); }

        #region ITag methods made abstract

        /// <summary>
        ///   See <see cref="ITag.ContentType"/>
        /// </summary>
        public abstract ContentType ContentType { get; }

        /// <summary>
        ///   See <see cref="ITag.TextValue"/>
        /// </summary>
        public abstract string TextValue { get; set; }

        /// <summary>
        ///   See <see cref="ITag.OwnedTags"/>
        /// </summary>
        public abstract TagList OwnedTags { get; }

        /// <summary>
        ///   See <see cref="ITag.OwnedText"/>
        /// </summary>
        public abstract string OwnedText { get; }

        /// <summary>
        ///   See <see cref="ITag.Visit(ITagVoidVisitor)"/>
        /// </summary>
        public abstract void Visit(ITagVoidVisitor visitor);

        /// <summary>
        ///   See <see cref="ITag.Visit{T}(ITagGenericVisitor{T})"/>
        /// </summary>
        public abstract T Visit<T>(ITagGenericVisitor<T> visitor);

        #endregion

        #region ITag implementations

        /// <summary>
        ///   Implements <see cref="ITag.Tag"/> using the <see cref="WalkerPlatform.ITagApi.Tag"/>
        /// </summary>
        public object Tag { get; }

        /// <summary>
        ///   Implements <see cref="ITag.Name"/> using the <see cref="WalkerPlatform.ITagApi.Name"/>
        /// </summary>
        public virtual string Name => Api.Name(Tag);

        public virtual ITag Owner { get => this.owner; internal set => this.owner = value; }

        /// <summary>
        ///   Implements <see cref="ITag.Attributes"/>
        /// </summary>
        public TagAttributes Attributes { get; }

        /// <summary>
        ///   Implements <see cref="ITag.Clone(WalkerPlatform.WalkerFactory, ITag)"/>
        /// </summary>
        public ITag Clone(WalkerPlatform.WalkerFactory factory, ITag owner)
        {
            var adapter = factory.CreateAdapter(null, factory.CloneTag(Tag), Name);

            foreach (var item in Attributes)
                adapter.Attributes[item.Key] = item.Value;

            if (owner?.OwnedTags != null)
                owner.OwnedTags.Add(adapter);

            if (TextValue != null)
                adapter.TextValue = TextValue;

            return adapter;
        }

        #endregion
    }
}
