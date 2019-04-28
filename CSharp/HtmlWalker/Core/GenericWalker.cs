using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;
using System;

namespace HtmlWalker.Core
{
    /// <summary>
    ///     This abstract class provides a short cut when you need to override
    ///     all more most of the tag Vist methods.
    ///     
    ///     Instead, the class routes all Visits to 5 abstract methods. Then
    ///     only these need to be overridden.
    /// </summary>
    public abstract class GenericWalker : Walker
    {
        public GenericWalker() : base() { }

        /// <summary>
        ///     Called with the first visit to the <see cref="DocumentTag"/>,
        ///     effectively the beginning of the walk.
        /// </summary>
        /// <param name="adapter">document tag</param>
        protected abstract void StartDocument(DocumentTag adapter);

        /// <summary>
        ///     Called on the close of the <see cref="DocumentTag"/>,
        ///     effectively at the end of the walk.
        /// </summary>
        /// <param name="adapter"></param>
        protected abstract void EndDocument(DocumentTag adapter);

        /// <summary>
        ///     Called with tag adapters which do not contain tags.
        /// </summary>
        /// <typeparam name="T">tag adapter class</typeparam>
        /// <param name="adapter">tag</param>
        /// <returns>tag adapter in the event that it was modified</returns>
        protected abstract ITag HandleTag<T>(T adapter) where T : ITag;

        /// <summary>
        ///     Called on the opening of a tag adapters
        /// </summary>
        /// <typeparam name="T">tag adapter call</typeparam>
        /// <param name="adapter">tag</param>
        /// <returns>tag adapter in the event that it was modified</returns>
        protected abstract ITag StartTag<T>(T adapter) where T : ITag;

        /// <summary>
        ///     Called on the closing of tag adapters
        /// </summary>
        protected abstract void EndTag();

        #region Walker implementations

        #region Handle implementations for utility tags

        /// <summary>
        ///   Handles tags that cannot be recongized by throwing an exception
        ///   Implements <see cref="IWalker.Handle(Unknown)"/>
        /// </summary>
        public override void Handle(Unknown adapter) => throw new NotSupportedException("Unknown -> " + adapter.Name);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(Entity)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
        public override void Handle(Entity adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(Eol)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
        public override void Handle(Eol adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(Text)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
        public override void Handle(Text adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(Comment)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
        public override void Handle(Comment adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(Skip)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
        public override void Handle(Skip adapter) => HandleTag(adapter);

        #endregion

        #region Start/End implemntations of docment, <html>, <head>, and <body>

        /// <summary>
        ///   Implements <see cref="IWalker.Start(DocumentTag)"/> with <see cref="StartDocument(DocumentTag)"/>
        /// </summary>
        public override void Start(DocumentTag adapter) => StartDocument(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(DocumentTag)"/> with <see cref="EndDocument(DocumentTag)"/>
        /// </summary>
        public override void End(DocumentTag adapter) => EndDocument(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagHtml)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
        public override void Start(TagHtml adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagHtml)"/> with <see cref="EndTag()"/>
        /// </summary>
        public override void End(TagHtml adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagHead)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
        public override void Start(TagHead adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagHead)"/> with <see cref="EndTag()"/>
        /// </summary>
        public override void End(TagHead adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagBody)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
        public override void Start(TagBody adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagBody)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagBody adapter) => EndTag();

        #endregion

        #region Handle implementations for other tags

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagArea)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
        public override void Handle(TagArea adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagBase)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
        public override void Handle(TagBase adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagBr)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
        public override void Handle(TagBr adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagEmbed)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
        public override void Handle(TagEmbed adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagHr)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagHr adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagImg)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagImg adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagInput)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagInput adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagLink)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagLink adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagMeta)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagMeta adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagOption)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagOption adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagParam)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagParam adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagProgress)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagProgress adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagScript)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagScript adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagSource)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagSource adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagStyle)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagStyle adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagTitle)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagTitle adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagTextarea)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagTextarea adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagTrack)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagTrack adapter) => HandleTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.Handle(TagWbr)"/> with <see cref="HandleTag{T}(T)"/>
        /// </summary>
	    public override void Handle(TagWbr adapter) => HandleTag(adapter);

        #endregion

        #region Start/End implementations for table tags

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCaption)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagCaption adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCaption)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagCaption adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCol)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagCol adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCol)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagCol adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagColgroup)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagColgroup adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagColgroup)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagColgroup adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTable)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagTable adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTable)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagTable adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTbody)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagTbody adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTbody)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagTbody adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTd)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagTd adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTd)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagTd adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTfoot)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagTfoot adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTfoot)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagTfoot adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTh)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagTh adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTh)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagTh adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagThead)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagThead adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagThead)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagThead adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTr)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagTr adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTr)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagTr adapter) => EndTag();

        #endregion

        #region Start/End implementations for list tags

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDd)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagDd adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDd)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagDd adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDl)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagDl adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDl)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagDl adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDt)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagDt adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDt)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagDt adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagLi)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagLi adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagLi)"/> with <see cref="EndTag()"/>
        /// </summary>
        public override void End(TagLi adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagOl)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagOl adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagOl)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagOl adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagUl)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagUl adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagUl)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagUl adapter) => EndTag();

        #endregion

        #region Start/End implementations for other tags

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagA)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
        public override void Start(TagA adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagA)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagA adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagAbbr)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagAbbr adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagAbbr)"/> with <see cref="EndTag()"/>
        /// </summary>
        public override void End(TagAbbr adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagAcronym)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagAcronym adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagAcronym)"/> with <see cref="EndTag()"/>
        /// </summary>
        public override void End(TagAcronym adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagAddress)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagAddress adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagAddress)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagAddress adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagArticle)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagArticle adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagArticle)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagArticle adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagAside)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagAside adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagAside)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagAside adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagAudio)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagAudio adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagAudio)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagAudio adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagB)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagB adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagB)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagB adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagBdi)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagBdi adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagBdi)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagBdi adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagBdo)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagBdo adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagBdo)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagBdo adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagBig)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
        public override void Start(TagBig adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagBig)"/> with <see cref="EndTag()"/>
        /// </summary>
        public override void End(TagBig adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagBlockquote)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagBlockquote adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagBlockquote)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagBlockquote adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagButton)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
        public override void Start(TagButton adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagButton)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagButton adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCanvas)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagCanvas adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCanvas)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagCanvas adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCenter)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagCenter adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCenter)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagCenter adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCite)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagCite adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCite)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagCite adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCode)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagCode adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCode)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagCode adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagCommand)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagCommand adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagCommand)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagCommand adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDatalist)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagDatalist adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDatalist)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagDatalist adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDel)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagDel adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDel)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagDel adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDetails)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagDetails adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDetails)"/> with <see cref="EndTag()"/>
        /// </summary>
        public override void End(TagDetails adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDfn)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagDfn adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDfn)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagDfn adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDialog)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagDialog adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDialog)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagDialog adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagDiv)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagDiv adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagDiv)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagDiv adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagEm)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagEm adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagEm)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagEm adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagFieldset)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagFieldset adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagFieldset)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagFieldset adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagFigcaption)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagFigcaption adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagFigcaption)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagFigcaption adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagFigure)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagFigure adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagFigure)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagFigure adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagFont)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagFont adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagFont)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagFont adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagFooter)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagFooter adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagFooter)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagFooter adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagForm)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagForm adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagForm)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagForm adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagHeader)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagHeader adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagHeader)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagHeader adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagHgroup)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagHgroup adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagHgroup)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagHgroup adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH1)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagH1 adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH1)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagH1 adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH2)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagH2 adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH2)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagH2 adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH3)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagH3 adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH3)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagH3 adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH4)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagH4 adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH4)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagH4 adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH5)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagH5 adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH5)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagH5 adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagH6)"/>
        /// </summary>
	    public override void Start(TagH6 adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagH6)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagH6 adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagI)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagI adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagI)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagI adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagIframe)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagIframe adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagIframe)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagIframe adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagIns)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagIns adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagIns)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagIns adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagKbd)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagKbd adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagKbd)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagKbd adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagKeygen)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagKeygen adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagKeygen)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagKeygen adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagLabel)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagLabel adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagLabel)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagLabel adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagLegend)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagLegend adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagLegend)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagLegend adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMain)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagMain adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMain)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagMain adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMap)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagMap adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMap)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagMap adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMark)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagMark adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMark)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagMark adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMenu)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagMenu adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMenu)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagMenu adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMenuitem)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagMenuitem adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMenuitem)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagMenuitem adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagMeter)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagMeter adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagMeter)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagMeter adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagNav)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagNav adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagNav)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagNav adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagNoscript)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagNoscript adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagNoscript)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagNoscript adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagObject)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagObject adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagObject)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagObject adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagOptgroup)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagOptgroup adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagOptgroup)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagOptgroup adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagOutput)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagOutput adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagOutput)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagOutput adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagP)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagP adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagP)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagP adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagPicture)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagPicture adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagPicture)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagPicture adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagPre)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagPre adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagPre)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagPre adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagQ)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagQ adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagQ)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagQ adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagRp)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagRp adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagRp)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagRp adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagRt)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagRt adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagRt)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagRt adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagRuby)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagRuby adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagRuby)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagRuby adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagS)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagS adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagS)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagS adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSamp)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagSamp adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSamp)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagSamp adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSection)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagSection adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSection)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagSection adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSelect)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagSelect adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSelect)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagSelect adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSmall)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagSmall adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSmall)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagSmall adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSpan)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagSpan adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSpan)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagSpan adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagStrike)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagStrike adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagStrike)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagStrike adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagStrong)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagStrong adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagStrong)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagStrong adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSub)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagSub adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSub)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagSub adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSummary)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagSummary adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSummary)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagSummary adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagSup)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
        public override void Start(TagSup adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagSup)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagSup adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTime)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagTime adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTime)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagTime adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagTt)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagTt adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagTt)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagTt adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagU)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagU adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagU)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagU adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagVar)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagVar adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagVar)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagVar adapter) => EndTag();

        /// <summary>
        ///   Implements <see cref="IWalker.Start(TagVideo)"/> with <see cref="StartTag{T}(T)"/>
        /// </summary>
	    public override void Start(TagVideo adapter) => StartTag(adapter);

        /// <summary>
        ///   Implements <see cref="IWalker.End(TagVideo)"/> with <see cref="EndTag()"/>
        /// </summary>
	    public override void End(TagVideo adapter) => EndTag();

        #endregion

        #endregion
    }
}
