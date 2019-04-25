using HtmlWalker.Platform;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;
using System.Collections.Generic;

namespace HtmlWalker
{
    /// <summary>
    ///   The <see cref="JoinedWalker"/> provides a way to run <see cref="IWalker"/>'s in effect parrallel,
    ///   while walking the HTML rather than having to run seperately.
    ///   
    ///   <b>Start</b> and <b>Handle</b> methods are done first to last. <b>End</b> methods are done last to first.
    ///   
    ///   NOTE: Consider adding a way to run as a series
    /// </summary>
    /// <author>Robert R Flores</author>
    public class JoinedWalker : Walker
    {
        public readonly List<IWalker> Walkers = new List<IWalker>();

        public JoinedWalker() : base() { }

        #region Walker implementation
 
        #region End methods

        #region document, <html>, <head>, and <body>

        public override void End(DocumentTag adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagHead adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagBody adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagHtml adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        #endregion

        #region table tags

        public override void End(TagCaption adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagCol adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagColgroup adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagTable adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagTbody adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagTd adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagTfoot adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagTh adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagThead adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagTr adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        #endregion

        #region block tags

        public override void End(TagArticle adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagAside adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagAddress adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagBlockquote adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagCanvas adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagDd adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagDiv adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagDl adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagDt adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagFieldset adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagFigcaption adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagFigure adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagFooter adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagForm adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagH1 adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagH2 adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagH3 adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagH4 adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagH5 adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagH6 adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagHeader adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagHgroup adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagLi adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagMain adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagNav adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagNoscript adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagOl adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagOutput adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagP adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagPre adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagSection adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagUl adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagVideo adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        #endregion

        #region inline tags

        public override void End(TagA adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagAbbr adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagAcronym adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagB adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagBdo adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagBig adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagButton adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagCite adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagCode adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagDfn adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagEm adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagI adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagKbd adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagLabel adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagMap adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagObject adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagQ adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagS adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagSamp adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagSelect adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagSmall adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagSpan adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagStrong adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagSub adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagSup adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagTime adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagTt adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagU adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagVar adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        #endregion

        #region other tags

        public override void End(TagAudio adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagBdi adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagCenter adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagCommand adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagDatalist adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagDetails adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagDel adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagDialog adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagFont adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagIframe adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagIns adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagKeygen adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagLegend adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagMark adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagMenu adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagMenuitem adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagMeter adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagOptgroup adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagPicture adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagRp adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagRt adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagRuby adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagStrike adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        public override void End(TagSummary adapter)
        {
            for (int n = Walkers.Count - 1; n >= 0; n--)
                Walkers[n].End(adapter);
        }

        #endregion

        #endregion

        #region Handle methods

        #region Utility tag Handle Methods

        public override void Handle(Text adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(Eol adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(Entity adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(Comment adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(Skip adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(Unknown adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        #endregion

        #region HTML tag Handle methods

        public override void Handle(TagArea adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagBase adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagBr adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagEmbed adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagHr adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagImg adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagInput adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagLink adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagMeta adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagOption adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagParam adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagProgress adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagScript adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagSource adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagStyle adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagTextarea adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagTitle adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagTrack adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        public override void Handle(TagWbr adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Handle(adapter);
        }

        #endregion

        #endregion

        #region Start methods

        #region document, <html>, <head>, and <body>

        public override void Start(DocumentTag adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagHead adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagBody adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagHtml adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        #endregion

        #region table tags

        public override void Start(TagCaption adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagCol adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagColgroup adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagTable adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagTbody adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagTd adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagTfoot adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagTh adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagThead adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagTr adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        #endregion

        #region block tags

        public override void Start(TagArticle adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagAside adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagAddress adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagBlockquote adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagCanvas adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagDd adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagDiv adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagDl adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagDt adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagFieldset adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagFigcaption adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagFigure adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagFooter adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagForm adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagH1 adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagH2 adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagH3 adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagH4 adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagH5 adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagH6 adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagHeader adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagHgroup adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagLi adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagMain adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagNav adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagNoscript adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagOl adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagOutput adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagP adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagPre adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagSection adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagUl adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagVideo adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        #endregion

        #region inline tags

        public override void Start(TagA adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagAbbr adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagAcronym adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagB adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagBdo adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagBig adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagButton adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagCite adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagCode adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagDfn adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagEm adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagI adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagKbd adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagLabel adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagMap adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagObject adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagQ adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagS adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagSamp adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagSelect adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagSmall adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagSpan adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagStrong adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagSub adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagSup adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagTime adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagTt adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagU adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagVar adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        #endregion

        #region other tags

        public override void Start(TagAudio adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagBdi adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagCenter adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagCommand adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagDatalist adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagDetails adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagDel adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagDialog adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagFont adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagIframe adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagIns adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagKeygen adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagLegend adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagMark adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagMenu adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagMenuitem adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagMeter adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagOptgroup adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagPicture adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagRp adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagRt adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagRuby adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagStrike adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        public override void Start(TagSummary adapter)
        {
            for (int n = 0; n < Walkers.Count; n++)
                Walkers[n].Start(adapter);
        }

        #endregion

        #endregion

        #endregion
    }
}
