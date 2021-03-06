﻿using HtmlWalker.Core;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;

namespace HtmlWalker.Visitor
{
    /// <summary>
    ///     This class provides a shortcut when you don't need
    ///     to override all or most of the Visit methods.
    ///     
    ///     Instead, you just need to override those where the
    ///     tag is replaced.
    /// </summary>
    public class EchoModifer : DocGeneratorWalker.IModifier
    {
        public virtual ITag Visit(DocumentTag adapter) => adapter;
        public virtual ITag Visit(Text adapter) => adapter;
        public virtual ITag Visit(Eol adapter) => adapter;
        public virtual ITag Visit(Entity adapter) => adapter;
        public virtual ITag Visit(Comment adapter) => adapter;
        public virtual ITag Visit(Skip adapter) => adapter;
        public virtual ITag Visit(Unknown adapter) => adapter;
        public virtual ITag Visit(TagA adapter) => adapter;
        public virtual ITag Visit(TagAbbr adapter) => adapter;
        public virtual ITag Visit(TagAcronym adapter) => adapter;
        public virtual ITag Visit(TagAddress adapter) => adapter;
        public virtual ITag Visit(TagArea adapter) => adapter;
        public virtual ITag Visit(TagArticle adapter) => adapter;
        public virtual ITag Visit(TagAside adapter) => adapter;
        public virtual ITag Visit(TagAudio adapter) => adapter;
        public virtual ITag Visit(TagB adapter) => adapter;
        public virtual ITag Visit(TagBase adapter) => adapter;
        public virtual ITag Visit(TagBdi adapter) => adapter;
        public virtual ITag Visit(TagBdo adapter) => adapter;
        public virtual ITag Visit(TagBig adapter) => adapter;
        public virtual ITag Visit(TagBlockquote adapter) => adapter;
        public virtual ITag Visit(TagBody adapter) => adapter;
        public virtual ITag Visit(TagBr adapter) => adapter;
        public virtual ITag Visit(TagButton adapter) => adapter;
        public virtual ITag Visit(TagCanvas adapter) => adapter;
        public virtual ITag Visit(TagCaption adapter) => adapter;
        public virtual ITag Visit(TagCenter adapter) => adapter;
        public virtual ITag Visit(TagCite adapter) => adapter;
        public virtual ITag Visit(TagCode adapter) => adapter;
        public virtual ITag Visit(TagCol adapter) => adapter;
        public virtual ITag Visit(TagColgroup adapter) => adapter;
        public virtual ITag Visit(TagCommand adapter) => adapter;
        public virtual ITag Visit(TagDatalist adapter) => adapter;
        public virtual ITag Visit(TagDd adapter) => adapter;
        public virtual ITag Visit(TagDel adapter) => adapter;
        public virtual ITag Visit(TagDetails adapter) => adapter;
        public virtual ITag Visit(TagDfn adapter) => adapter;
        public virtual ITag Visit(TagDialog adapter) => adapter;
        public virtual ITag Visit(TagDiv adapter) => adapter;
        public virtual ITag Visit(TagDl adapter) => adapter;
        public virtual ITag Visit(TagDt adapter) => adapter;
        public virtual ITag Visit(TagEm adapter) => adapter;
        public virtual ITag Visit(TagEmbed adapter) => adapter;
        public virtual ITag Visit(TagFieldset adapter) => adapter;
        public virtual ITag Visit(TagFigcaption adapter) => adapter;
        public virtual ITag Visit(TagFigure adapter) => adapter;
        public virtual ITag Visit(TagFont adapter) => adapter;
        public virtual ITag Visit(TagFooter adapter) => adapter;
        public virtual ITag Visit(TagForm adapter) => adapter;
        public virtual ITag Visit(TagH1 adapter) => adapter;
        public virtual ITag Visit(TagH2 adapter) => adapter;
        public virtual ITag Visit(TagH3 adapter) => adapter;
        public virtual ITag Visit(TagH4 adapter) => adapter;
        public virtual ITag Visit(TagH5 adapter) => adapter;
        public virtual ITag Visit(TagH6 adapter) => adapter;
        public virtual ITag Visit(TagHead adapter) => adapter;
        public virtual ITag Visit(TagHeader adapter) => adapter;
        public virtual ITag Visit(TagHgroup adapter) => adapter;
        public virtual ITag Visit(TagHr adapter) => adapter;
        public virtual ITag Visit(TagHtml adapter) => adapter;
        public virtual ITag Visit(TagI adapter) => adapter;
        public virtual ITag Visit(TagIframe adapter) => adapter;
        public virtual ITag Visit(TagImg adapter) => adapter;
        public virtual ITag Visit(TagInput adapter) => adapter;
        public virtual ITag Visit(TagIns adapter) => adapter;
        public virtual ITag Visit(TagKbd adapter) => adapter;
        public virtual ITag Visit(TagKeygen adapter) => adapter;
        public virtual ITag Visit(TagLabel adapter) => adapter;
        public virtual ITag Visit(TagLegend adapter) => adapter;
        public virtual ITag Visit(TagLi adapter) => adapter;
        public virtual ITag Visit(TagLink adapter) => adapter;
        public virtual ITag Visit(TagMain adapter) => adapter;
        public virtual ITag Visit(TagMap adapter) => adapter;
        public virtual ITag Visit(TagMark adapter) => adapter;
        public virtual ITag Visit(TagMenu adapter) => adapter;
        public virtual ITag Visit(TagMenuitem adapter) => adapter;
        public virtual ITag Visit(TagMeta adapter) => adapter;
        public virtual ITag Visit(TagMeter adapter) => adapter;
        public virtual ITag Visit(TagNav adapter) => adapter;
        public virtual ITag Visit(TagNoscript adapter) => adapter;
        public virtual ITag Visit(TagObject adapter) => adapter;
        public virtual ITag Visit(TagOl adapter) => adapter;
        public virtual ITag Visit(TagOptgroup adapter) => adapter;
        public virtual ITag Visit(TagOption adapter) => adapter;
        public virtual ITag Visit(TagOutput adapter) => adapter;
        public virtual ITag Visit(TagP adapter) => adapter;
        public virtual ITag Visit(TagParam adapter) => adapter;
        public virtual ITag Visit(TagPicture adapter) => adapter;
        public virtual ITag Visit(TagPre adapter) => adapter;
        public virtual ITag Visit(TagProgress adapter) => adapter;
        public virtual ITag Visit(TagQ adapter) => adapter;
        public virtual ITag Visit(TagRp adapter) => adapter;
        public virtual ITag Visit(TagRt adapter) => adapter;
        public virtual ITag Visit(TagRuby adapter) => adapter;
        public virtual ITag Visit(TagS adapter) => adapter;
        public virtual ITag Visit(TagSamp adapter) => adapter;
        public virtual ITag Visit(TagScript adapter) => adapter;
        public virtual ITag Visit(TagSection adapter) => adapter;
        public virtual ITag Visit(TagSelect adapter) => adapter;
        public virtual ITag Visit(TagSmall adapter) => adapter;
        public virtual ITag Visit(TagSource adapter) => adapter;
        public virtual ITag Visit(TagSpan adapter) => adapter;
        public virtual ITag Visit(TagStrike adapter) => adapter;
        public virtual ITag Visit(TagStrong adapter) => adapter;
        public virtual ITag Visit(TagStyle adapter) => adapter;
        public virtual ITag Visit(TagSub adapter) => adapter;
        public virtual ITag Visit(TagSummary adapter) => adapter;
        public virtual ITag Visit(TagSup adapter) => adapter;
        public virtual ITag Visit(TagTable adapter) => adapter;
        public virtual ITag Visit(TagTbody adapter) => adapter;
        public virtual ITag Visit(TagTd adapter) => adapter;
        public virtual ITag Visit(TagTextarea adapter) => adapter;
        public virtual ITag Visit(TagTfoot adapter) => adapter;
        public virtual ITag Visit(TagTh adapter) => adapter;
        public virtual ITag Visit(TagThead adapter) => adapter;
        public virtual ITag Visit(TagTime adapter) => adapter;
        public virtual ITag Visit(TagTitle adapter) => adapter;
        public virtual ITag Visit(TagTr adapter) => adapter;
        public virtual ITag Visit(TagTrack adapter) => adapter;
        public virtual ITag Visit(TagTt adapter) => adapter;
        public virtual ITag Visit(TagU adapter) => adapter;
        public virtual ITag Visit(TagUl adapter) => adapter;
        public virtual ITag Visit(TagVar adapter) => adapter;
        public virtual ITag Visit(TagVideo adapter) => adapter;
        public virtual ITag Visit(TagWbr adapter) => adapter;
    }
}
