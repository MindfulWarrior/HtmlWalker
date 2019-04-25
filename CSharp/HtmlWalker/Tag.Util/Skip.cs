using System;
using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Visitor;
using HtmlWalker.Core;

namespace HtmlWalker.Tag.Util
{
    /// <summary>
    ///   This class exist to house a tag object meant to not be process or 'skipped'
    /// </summary>
    /// <author>Robert R Flores</author>
    public class Skip : ContentUtilTag
    {
        private TagList tags = null;

        private readonly BaseTag NodeOwner;

        public readonly BaseTag SkippedTag;

        // TODO: need to make this readonly/final
        public bool SkipTree;

        /// <summary>
        ///   Constructor for housing a existing text
        /// </summary>
        /// <param name="factory">used to produce objects as per the specific platform</param>
        /// <param name="adapter">tag to be skipped</param>
        public Skip(WalkerPlatform.WalkerFactory factory, BaseTag adapter) : base(factory, adapter.Tag)
        {
            SkippedTag = adapter;

            var nodeOwner = adapter.Owner;
            while (nodeOwner != null && nodeOwner.ContentType == ContentType.SKIP)
                nodeOwner = nodeOwner.Owner;
            NodeOwner = nodeOwner as BaseTag;

            if (NodeOwner != null &&adapter.OwnedTags != null)
            {
                foreach (var tag in adapter.OwnedTags)
                    OwnedTags.Add(tag);
            }

            if (Owner != null)
            {
                Owner.OwnedTags.Tags.Add(this);
                Owner.OwnedTags.Tags.Remove(adapter);
                NodeOwner.Api.Remove(NodeOwner.Tag, adapter);
            }
        }

        public override ContentType ContentType => ContentType.SKIP;

        public override ITag Owner => SkippedTag.Owner;

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
        public override string Name => "#skip";

        /// <summary>
        ///   Implements <see cref="ITag.TextValue"/>
        /// </summary>
        public override string TextValue { get => Tag.ToString(); set { } }

        /// <summary>
        ///   Impleents <see cref="ITag.OwnedTags"/>
        /// </summary>
        public override TagList OwnedTags
        {
            get
            {
                if (this.tags == null)
                    this.tags = new TagList(this, SkipTree ? SkippedTag : NodeOwner).Initialize(Factory);
                return this.tags;
            }
        }

        /// <summary>
        ///   Implement <see cref="ITag.OwnedText"/>
        /// </summary>
        public override string OwnedText => SkippedTag.OwnedText;
    }
}