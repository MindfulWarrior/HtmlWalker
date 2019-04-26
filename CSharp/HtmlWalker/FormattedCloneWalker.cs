﻿using HtmlWalker.Platform;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;

namespace HtmlWalker
{
    public class FormattedCloneWalker : CloneWalker
    {
        // TODO: Make <!DOCTYPE html> a new type instead of comment

        private ITag CurrentOwner()
        {
            var owner = currentTag;
            while (owner != null && owner.Name == "#skip")
                owner = owner.Owner;
            return owner;
        }

        public FormattedCloneWalker(WalkerPlatform.WalkerDocument document) : base(document) { }

        protected override void HandleTag<T>(T adapter)
        {
            base.HandleTag(adapter);
            var owner = CurrentOwner();
            if (owner != null)
            {
                if (owner.Name == "body")
                    owner.OwnedTags.Add(new Eol(Output.Factory, 2));
                else if (owner.Name == "head")
                    owner.OwnedTags.Add(new Eol(Output.Factory));
            }
        }

        protected override void EndTag()
        {
            bool skipped = (currentTag.Name == "#skip");
            base.EndTag();
            if (!skipped)
            {
                var owner = CurrentOwner();
                if (owner != null)
                {
                    if (owner.Name == "body")
                        owner.OwnedTags.Add(new Eol(Output.Factory, 2));
                    else if (owner.Name == "head")
                        owner.OwnedTags.Add(new Eol(Output.Factory));
                }
            }
        }

        public override void Start(TagHtml adapter)
        {
            base.Start(adapter);
            currentTag.OwnedTags.Add(new Eol(Output.Factory));
        }

        public override void Start(TagHead adapter)
        {
            base.Start(adapter);
            currentTag.OwnedTags.Add(new Eol(Output.Factory));
        }

        public override void End(TagHead adapter)
        {
            base.End(adapter);
            currentTag.OwnedTags.Add(new Eol(Output.Factory));
        }

        public override void Start(TagBody adapter)
        {
            base.Start(adapter);
            currentTag.OwnedTags.Add(new Eol(Output.Factory, 2));
        }

        public override void End(TagBody adapter)
        {
            base.End(adapter);
            currentTag.OwnedTags.Add(new Eol(Output.Factory));
        }

        public override void Handle(Eol adapter)
        {
            var owner = CurrentOwner();
            if (
                owner != null &&
                owner.Name != "#skip" &&
                owner.Name != "body" &&
                owner.Name != "head" &&
                owner.Name != "html"
            )
                base.Handle(adapter);
        }
    }
}