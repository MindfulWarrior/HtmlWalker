using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;
using System;

namespace HtmlWalker.Core
{
    public class EventWalker : Walker
    {
        public EventWalker() : base() { }

        public EventHandler StartDocumentHandler;
        public EventHandler EndDocumentHandler;

        public EventHandler StartTagHandler;
        public EventHandler EndTagHandler;

        public EventHandler TagHandler;

        public class TagEventArgs : EventArgs
        {
            public readonly ITag Tag;

            public TagEventArgs(ITag tag) => Tag = tag;
        }

        private void OnStartDocument(DocumentTag adapter) => StartDocumentHandler?.Invoke(this, new TagEventArgs(adapter));

        private void OnEndDocument(DocumentTag adapter) => EndDocumentHandler?.Invoke(this, new TagEventArgs(adapter));

        private void OnStartTag(ITag adapter) => StartTagHandler?.Invoke(this, new TagEventArgs(adapter));

        private void OnEndTag(ITag adapter) => EndTagHandler?.Invoke(this, new TagEventArgs(adapter));

        private void OnTag(ITag adapter) => TagHandler?.Invoke(this, new TagEventArgs(adapter));

        #region Walker implementations

        #region Handle implementations for Unknown, Entity, and strings

        /// <summary>
        ///   Handles tags that cannot be recongized by throwing an exception
        ///   Implements <see cref="IWalker.Handle(Unknown)"/>
        /// </summary>
        public override void Handle(Unknown adapter) => throw new NotSupportedException("Unknown -> " + adapter.Name);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(Entity)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
        public override void Handle(Entity adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(Eol)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
        public override void Handle(Eol adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(Text)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
        public override void Handle(Text adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(Comment)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
        public override void Handle(Comment adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(Skip)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
        public override void Handle(Skip adapter) => OnTag(adapter);

        #endregion

        #region Start/End implemntations of docment, <html>, <head>, and <body>

        /// <summary>
        ///   Implements <see cref="IWalker.Start(DocumentTag)"/> with <see cref="OnStartDocument(DocumentTag)"/>
        /// </summary>
        public override void Start(DocumentTag adapter) => OnStartDocument(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(DocumentTag)"/> with <see cref="OnEndDocument(DocumentTag)"/>
        /// </summary>
        public override void End(DocumentTag adapter) => OnEndDocument(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagHtml)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
        public override void Start(TagHtml adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagHtml)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
        public override void End(TagHtml adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagHead)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
        public override void Start(TagHead adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagHead)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
        public override void End(TagHead adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagBody)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
        public override void Start(TagBody adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagBody)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagBody adapter) => OnEndTag(adapter);

        #endregion

        #region Handle implementations for other tags

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagArea)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
        public override void Handle(TagArea adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagBase)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
        public override void Handle(TagBase adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagBr)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
        public override void Handle(TagBr adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagEmbed)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
        public override void Handle(TagEmbed adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagHr)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagHr adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagImg)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagImg adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagInput)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagInput adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagLink)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagLink adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagMeta)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagMeta adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagOption)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagOption adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagParam)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagParam adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagProgress)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagProgress adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagScript)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagScript adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagSource)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagSource adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagStyle)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagStyle adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagTitle)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagTitle adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagTextarea)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagTextarea adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagTrack)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagTrack adapter) => OnTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagWbr)"/> with <see cref="OnTag(ITag)"/>
        /// </summary>
	    public override void Handle(TagWbr adapter) => OnTag(adapter);

        #endregion

        #region Start/End implementations for table tags

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCaption)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagCaption adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCaption)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagCaption adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCol)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagCol adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCol)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagCol adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagColgroup)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagColgroup adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagColgroup)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagColgroup adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTable)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagTable adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTable)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagTable adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTbody)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagTbody adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTbody)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagTbody adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTd)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagTd adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTd)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagTd adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTfoot)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagTfoot adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTfoot)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagTfoot adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTh)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagTh adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTh)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagTh adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagThead)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagThead adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagThead)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagThead adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTr)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagTr adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTr)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagTr adapter) => OnEndTag(adapter);

        #endregion

        #region Start/End implementations for list tags

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDd)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagDd adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDd)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagDd adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDl)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagDl adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDl)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagDl adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDt)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagDt adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDt)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagDt adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagLi)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagLi adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagLi)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
        public override void End(TagLi adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagOl)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagOl adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagOl)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagOl adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagUl)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagUl adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagUl)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagUl adapter) => OnEndTag(adapter);

        #endregion

        #region Start/End implementations for other tags

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagA)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
        public override void Start(TagA adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagA)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagA adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagAbbr)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagAbbr adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagAbbr)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
        public override void End(TagAbbr adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagAcronym)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagAcronym adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagAcronym)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
        public override void End(TagAcronym adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagAddress)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagAddress adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagAddress)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagAddress adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagArticle)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagArticle adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagArticle)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagArticle adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagAside)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagAside adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagAside)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagAside adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagAudio)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagAudio adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagAudio)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagAudio adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagB)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagB adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagB)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagB adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagBdi)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagBdi adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagBdi)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagBdi adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagBdo)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagBdo adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagBdo)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagBdo adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagBig)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
        public override void Start(TagBig adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagBig)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
        public override void End(TagBig adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagBlockquote)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagBlockquote adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagBlockquote)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagBlockquote adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagButton)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
        public override void Start(TagButton adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagButton)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagButton adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCanvas)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagCanvas adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCanvas)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagCanvas adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCenter)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagCenter adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCenter)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagCenter adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCite)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagCite adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCite)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagCite adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCode)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagCode adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCode)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagCode adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCommand)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagCommand adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCommand)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagCommand adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDatalist)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagDatalist adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDatalist)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagDatalist adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDel)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagDel adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDel)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagDel adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDetails)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagDetails adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDetails)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
        public override void End(TagDetails adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDfn)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagDfn adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDfn)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagDfn adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDialog)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagDialog adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDialog)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagDialog adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDiv)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagDiv adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDiv)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagDiv adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagEm)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagEm adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagEm)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagEm adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagFieldset)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagFieldset adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagFieldset)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagFieldset adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagFigcaption)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagFigcaption adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagFigcaption)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagFigcaption adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagFigure)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagFigure adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagFigure)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagFigure adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagFont)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagFont adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagFont)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagFont adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagFooter)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagFooter adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagFooter)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagFooter adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagForm)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagForm adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagForm)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagForm adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagHeader)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagHeader adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagHeader)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagHeader adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagHgroup)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagHgroup adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagHgroup)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagHgroup adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH1)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagH1 adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH1)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagH1 adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH2)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagH2 adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH2)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagH2 adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH3)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagH3 adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH3)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagH3 adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH4)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagH4 adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH4)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagH4 adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH5)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagH5 adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH5)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagH5 adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH6)"/>
        /// </summary>
	    public override void Start(TagH6 adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH6)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagH6 adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagI)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagI adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagI)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagI adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagIframe)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagIframe adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagIframe)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagIframe adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagIns)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagIns adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagIns)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagIns adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagKbd)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagKbd adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagKbd)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagKbd adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagKeygen)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagKeygen adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagKeygen)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagKeygen adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagLabel)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagLabel adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagLabel)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagLabel adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagLegend)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagLegend adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagLegend)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagLegend adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMain)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagMain adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMain)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagMain adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMap)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagMap adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMap)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagMap adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMark)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagMark adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMark)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagMark adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMenu)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagMenu adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMenu)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagMenu adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMenuitem)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagMenuitem adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMenuitem)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagMenuitem adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMeter)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagMeter adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMeter)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagMeter adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagNav)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagNav adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagNav)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagNav adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagNoscript)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagNoscript adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagNoscript)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagNoscript adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagObject)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagObject adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagObject)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagObject adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagOptgroup)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagOptgroup adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagOptgroup)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagOptgroup adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagOutput)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagOutput adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagOutput)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagOutput adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagP)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagP adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagP)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagP adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagPicture)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagPicture adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagPicture)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagPicture adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagPre)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagPre adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagPre)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagPre adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagQ)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagQ adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagQ)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagQ adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagRp)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagRp adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagRp)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagRp adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagRt)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagRt adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagRt)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagRt adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagRuby)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagRuby adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagRuby)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagRuby adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagS)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagS adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagS)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagS adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSamp)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagSamp adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSamp)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagSamp adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSection)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagSection adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSection)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagSection adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSelect)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagSelect adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSelect)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagSelect adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSmall)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagSmall adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSmall)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagSmall adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSpan)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagSpan adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSpan)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagSpan adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagStrike)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagStrike adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagStrike)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagStrike adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagStrong)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagStrong adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagStrong)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagStrong adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSub)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagSub adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSub)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagSub adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSummary)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagSummary adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSummary)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagSummary adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSup)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
        public override void Start(TagSup adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSup)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagSup adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTime)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagTime adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTime)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagTime adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTt)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagTt adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTt)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagTt adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagU)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagU adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagU)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagU adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagVar)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagVar adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagVar)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagVar adapter) => OnEndTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagVideo)"/> with <see cref="OnStartTag(ITag)"/>
        /// </summary>
	    public override void Start(TagVideo adapter) => OnStartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagVideo)"/> with <see cref="OnEndTag(ITag)"/>
        /// </summary>
	    public override void End(TagVideo adapter) => OnEndTag(adapter);

        #endregion

        #endregion
    }
}
