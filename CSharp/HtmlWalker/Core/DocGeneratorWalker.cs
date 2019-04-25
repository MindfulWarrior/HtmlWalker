using HtmlWalker.Platform;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;
using HtmlWalker.Exception;
using HtmlWalker.Visitor;
using System.Collections.Generic;
using System;

namespace HtmlWalker.Core
{
    /// <summary>
    ///   This is bace class for <see cref="Walker"/> implementations that generate new documents.
    ///   
    ///   If the goal is only to modify or replace a tag, use a <see cref="ITagGenericVisitor{ITag}"/> and add to
    ///   <see cref="DocGeneratorWalker.Modifiers"/>. Here the <see cref="Skip"/> tag can also be used to remove the
    ///   the tag, but not its children and keep it for futher processing.
    /// </summary>
    /// <author>Robert R Flores</author>
    public abstract class DocGeneratorWalker : GenericWalker
    {
        protected ITag currentTag = null;

        protected WalkerPlatform.WalkerDocument Output { get; }

        public interface IModifier : ITagGenericVisitor<ITag> { }

        public readonly List<IModifier> Modifiers = new List<IModifier>();

        public DocGeneratorWalker(WalkerPlatform.WalkerDocument document) : base() { Output = document; }

        protected abstract ITag GenerateTag<T>(T adapter) where T : ITag;

        protected ITag Generate<T>(T adapter) where T : ITag
        {
            var tag = GenerateTag(adapter);
            foreach (var vistitor in Modifiers)
            {
                tag = tag.Visit(vistitor);
                if (tag == null)
                    throw new InvalidVisitorException();
            }
            return tag;
        }

        protected override void StartDocument(DocumentTag adapter) => currentTag = Output.DocumentTag;

        protected override void EndDocument(DocumentTag adapter) { }

        protected override void HandleTag<T>(T adapter) => Generate(adapter);

        protected override void StartTag<T>(T adapter) => currentTag = Generate(adapter);

        protected override void EndTag() => currentTag = currentTag.Owner;
    }
}
