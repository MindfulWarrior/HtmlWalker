using System;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;
using HtmlWalker.Exception;
using HtmlWalker.Core;

namespace HtmlWalker.Visitor
{
    public abstract class StrictHtml5GenericVisitor<T> : ITagGenericVisitor<T>
    {
        // TODO: Convert deprecated -> Html5 when possible

        #region deprecated tags

        /// <summary>
        ///   Implements <see cref="Visit(TagAcronym)"/> as deprecated
        /// </summary>
        public T Visit(TagAcronym adapter) => throw new TagDeprecatedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagBig)"/> as deprecated
        /// </summary>
        public T Visit(TagBig adapter) => throw new TagDeprecatedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagCenter)"/> as deprecated
        /// </summary>
        public T Visit(TagCenter adapter) => throw new TagDeprecatedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagCommand)"/> as deprecated
        /// </summary>
        public T Visit(TagCommand adapter) => throw new TagDeprecatedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagFont)"/> as deprecated
        /// </summary>
        public T Visit(TagFont adapter) => throw new TagDeprecatedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagHgroup)"/> as deprecated
        /// </summary>
        public T Visit(TagHgroup adapter) => throw new TagDeprecatedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagStrike)"/> as deprecated
        /// </summary>
        public T Visit(TagStrike adapter) => throw new TagDeprecatedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagTt)"/> as deprecated
        /// </summary>
        public T Visit(TagTt adapter) => throw new TagDeprecatedException(adapter);

        #endregion

        #region utility tags

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(Text)"/> as an abstract method
        /// </summary>
        public abstract T Visit(Text adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(Eol)"/> as an abstract method
        /// </summary>
        public abstract T Visit(Eol adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(Entity)"/> as an abstract method
        /// </summary>
        public abstract T Visit(Entity adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(Comment)"/> as an abstract method
        /// </summary>
        public abstract T Visit(Comment adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(Skip)"/> as an abstract method
        /// </summary>
        public abstract T Visit(Skip adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(Unknown)"/> as an abstract method
        /// </summary>
        public abstract T Visit(Unknown adapter);

        #endregion

        #region document, <html>, <head>, and <body> tags

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(DocumentTag)"/> as an abstract method
        /// </summary>
        public abstract T Visit(DocumentTag document);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagHtml)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagHtml adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagHtml)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagHead adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagHtml)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagBody adapter);

        #endregion

        #region metadata tag

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagBase)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagBase adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagLink)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagLink adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagMeta)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagMeta adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagNoscript)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagNoscript adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagScript)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagScript adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagStyle)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagStyle adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTitle)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTitle adapter);

        #endregion

        #region table tags

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagCaption)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagCaption adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagCol)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagCol adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagColgroup)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagColgroup adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTable)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTable adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTbody)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTbody adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTd)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTd adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTfoot)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTfoot adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTh)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTh adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagThead)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagThead adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTr)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTr adapter);

        #endregion

        #region list tags

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDd)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDd adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDl)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDl adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDt)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDt adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagLi)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagLi adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagOl)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagOl adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagUl)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagUl adapter);

        #endregion

        #region block level tags

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagArticle)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagArticle adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagAside)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagAside adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagBlockquote)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagBlockquote adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagBr)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagBr adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagButton)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagButton adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagCanvas)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagCanvas adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDiv)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDiv adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagEmbed)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagEmbed adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagFieldset)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagFieldset adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagFigcaption)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagFigcaption adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagFigure)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagFigure adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagFooter)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagFooter adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagForm)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagForm adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagH1)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagH1 adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagH2)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagH2 adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagH3)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagH3 adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagH4)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagH4 adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagH5)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagH5 adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagH6)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagH6 adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagHeader)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagHeader adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagHr)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagHr adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagMain)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagMain adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagMap)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagMap adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagObject)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagObject adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagOutput)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagOutput adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagP)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagP adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagPre)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagPre adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagProgress)"/> as an abstract method
        /// </summary>
	    public abstract T Visit(TagProgress adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSection)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSection adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTextarea)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTextarea adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagEmbed)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagVideo adapter);

        #endregion

        #region inline level tags

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagA)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagA adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagAbbr)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagAbbr adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagAddress)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagAddress adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagArea)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagArea adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagAudio)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagAudio adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagB)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagB adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagBdi)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagBdi adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagBdo)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagBdo adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagCite)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagCite adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagCode)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagCode adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDatalist)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDatalist adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDel)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDel adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDetails)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDetails adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDfn)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDfn adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagEm)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagEm adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagI)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagI adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagIframe)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagIframe adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagImg)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagImg adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagInput)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagInput adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagIns)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagIns adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagKbd)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagKbd adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagLabel)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagLabel adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagLegend)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagLegend adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagMark)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagMark adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagMeter)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagMeter adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagNav)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagNav adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagOptgroup)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagOptgroup adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagOption)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagOption adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagQ)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagQ adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagS)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagS adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSamp)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSamp adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSmall)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSmall adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSelect)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSelect adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSpan)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSpan adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSource)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSource adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagStrong)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagStrong adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSub)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSub adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSummary)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSummary adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSup)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSup adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTime)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTime adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagU)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagU adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagVar)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagVar adapter);

        #endregion

        #region other tags

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDialog)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDialog adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagKeygen)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagKeygen adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagMenu)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagMenu adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagMenuitem)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagMenuitem adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagParam)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagParam adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagPicture)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagPicture adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagRp)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagRp adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagRt)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagRt adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagRuby)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagRuby adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTrack)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTrack adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagWbr)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagWbr adapter);

        #endregion
    }
}
