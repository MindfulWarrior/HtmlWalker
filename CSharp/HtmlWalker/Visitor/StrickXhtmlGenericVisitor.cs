using HtmlWalker.Exception;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;

namespace HtmlWalker.Visitor
{
    public abstract class StrickXhtmlGenericVisitor<T> : ITagGenericVisitor<T>
    {
        // TODO: Convert deprecated -> Xhtml when possible

        #region not supported in XHTML

        /// <summary>
        ///   Implements <see cref="Visit(TagArticle)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagArticle adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagAside)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagAside adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagAudio)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagAudio adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagBdi)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagBdi adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagCanvas)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagCanvas adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagDatalist)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagDatalist adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagDetails)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagDetails adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagDialog)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagDialog adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagEmbed)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagEmbed adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagFigcaption)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagFigcaption adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagFigure)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagFigure adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagFooter)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagFooter adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagHeader)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagHeader adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagKeygen)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagKeygen adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagMain)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagMain adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagMark)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagMark adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagMenuitem)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagMenuitem adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagMeter)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagMeter adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagNav)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagNav adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagOutput)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagOutput adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagPicture)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagPicture adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagProgress)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagProgress adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagRp)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagRp adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagRt)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagRt adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagRuby)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagRuby adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagSection)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagSection adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagSource)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagSource adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagSummary)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagSummary adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagTime)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagTime adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagTrack)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagTrack adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagVideo)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagVideo adapter) => throw new TagNotSupportedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagWbr)"/> as not supported by XHTML
        /// </summary>
        public T Visit(TagWbr adapter) => throw new TagNotSupportedException(adapter);

        #endregion

        #region deprecated tags

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
        ///   Implements <see cref="Visit(TagMenu)"/> as deprecated
        /// </summary>
        public T Visit(TagMenu adapter) => throw new TagDeprecatedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagS)"/> as deprecated
        /// </summary>
        public T Visit(TagS adapter) => throw new TagDeprecatedException(adapter);

        /// <summary>
        ///   Implements <see cref="Visit(TagU)"/> as deprecated
        /// </summary>
        public T Visit(TagU adapter) => throw new TagDeprecatedException(adapter);

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
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDiv)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDiv adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagFieldset)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagFieldset adapter);

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
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagHr)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagHr adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagMap)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagMap adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagObject)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagObject adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagP)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagP adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagPre)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagPre adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTextarea)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTextarea adapter);

        #endregion

        #region inline tags

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagA)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagA adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagAbbr)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagAbbr adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagAcronym)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagAcronym adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagAddress)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagAddress adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagArea)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagArea adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagB)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagB adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagBdo)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagBdo adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagBig)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagBig adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagCite)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagCite adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagCode)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagCode adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagDel)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagDel adapter);

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
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagStrike)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagStrike adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagStrong)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagStrong adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSub)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSub adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagSup)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagSup adapter);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagTt)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagTt adpater);

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagVar)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagVar adapter);

        #endregion

        #region other tags

        /// <summary>
        ///   Tag is supported, so implement <see cref="ITagGenericVisitor{T}.Visit(TagParam)"/> as an abstract method
        /// </summary>
        public abstract T Visit(TagParam adapter);

        #endregion
    }
}
