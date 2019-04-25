using HtmlWalker.Platform;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;

namespace HtmlWalker
{
    public interface IWalkerStream
    {
        DocumentTag DocumentTag { get; }

        void Open(WalkerPlatform.WalkerDocument input);
        void Close();
        void Dispose();

        #region Utility tags

        Comment Handle(Comment adapter);
        Entity Handle(Entity adapter);
        Eol Handle(Eol adapter);
        Text Handle(Text adapter);
        Unknown Handle(Unknown adapter);

        #endregion

        #region Handle methods for HTML tags not needing Start/End

        TagArea Handle(TagArea adapter);
        TagBase Handle(TagBase adapter);
        TagBr Handle(TagBr adapter);
        TagEmbed Handle(TagEmbed adapter);
        TagHr Handle(TagHr adapter);
        TagImg Handle(TagImg adapter);
        TagInput Handle(TagInput adapter);
        TagLink Handle(TagLink adapter);
        TagMeta Handle(TagMeta adapter);
        TagOption Handle(TagOption adapter);
        TagParam Handle(TagParam adapter);
        TagProgress Handle(TagProgress adapter);
        TagScript Handle(TagScript adapter);
        TagSource Handle(TagSource adapter);
        TagStyle Handle(TagStyle adapter);
        TagTextarea Handle(TagTextarea adapter);
        TagTitle Handle(TagTitle adapter);
        TagTrack Handle(TagTrack adapter);
        TagWbr Handle(TagWbr adapter);

        #endregion

        #region document, <html>, <head>, and <body> tag Start/End methods

        DocumentTag Start(DocumentTag adapter);
        DocumentTag End(DocumentTag adapter);

        TagHtml Start(TagHtml adapter);
        TagHtml End(TagHtml adapter);

        TagHead Start(TagHead adapter);
        TagHead End(TagHead adapter);

        TagBody Start(TagBody adapter);
        TagBody End(TagBody adapter);

        #endregion

        #region block level tags

        TagAddress Start(TagAddress adapter);
        TagAddress End(TagAddress adapter);

        TagArticle Start(TagArticle adapter);
        TagArticle End(TagArticle adapter);

        TagAside Start(TagAside adapter);
        TagAside End(TagAside adapter);

        TagBlockquote Start(TagBlockquote adapter);
        TagBlockquote End(TagBlockquote adapter);

        TagCanvas Start(TagCanvas adapter);
        TagCanvas End(TagCanvas adapter);

        TagDd Start(TagDd adapter);
        TagDd End(TagDd adapter);

        TagDiv Start(TagDiv adapter);
        TagDiv End(TagDiv adapter);

        TagDl Start(TagDl adapter);
        TagDl End(TagDl adapter);

        TagFieldset Start(TagFieldset adapter);
        TagFieldset End(TagFieldset adapter);

        TagFigcaption Start(TagFigcaption adapter);
        TagFigcaption End(TagFigcaption adapter);

        TagFigure Start(TagFigure adapter);
        TagFigure End(TagFigure adapter);

        TagFooter Start(TagFooter adapter);
        TagFooter End(TagFooter adapter);

        TagForm Start(TagForm adapter);
        TagForm End(TagForm adapter);

        TagH1 Start(TagH1 adapter);
        TagH1 End(TagH1 adapter);

        TagH2 Start(TagH2 adapter);
        TagH2 End(TagH2 adapter);

        TagH3 Start(TagH3 adapter);
        TagH3 End(TagH3 adapter);

        TagH4 Start(TagH4 adapter);
        TagH4 End(TagH4 adapter);

        TagH5 Start(TagH5 adapter);
        TagH5 End(TagH5 adapter);

        TagH6 Start(TagH6 adapter);
        TagH6 End(TagH6 adapter);

        TagHeader Start(TagHeader adapter);
        TagHeader End(TagHeader adapter);

        TagHgroup Start(TagHgroup adapter);
        TagHgroup End(TagHgroup adapter);

        TagLi Start(TagLi adapter);
        TagLi End(TagLi adapter);

        TagMain Start(TagMain adapter);
        TagMain End(TagMain adapter);

        TagNav Start(TagNav adapter);
        TagNav End(TagNav adapter);

        TagNoscript Start(TagNoscript adapter);
        TagNoscript End(TagNoscript adapter);

        TagOl Start(TagOl adapter);
        TagOl End(TagOl adapter);

        TagOutput Start(TagOutput adapter);
        TagOutput End(TagOutput adapter);

        TagP Start(TagP adapter);
        TagP End(TagP adapter);

        TagPre Start(TagPre adapter);
        TagPre End(TagPre adapter);

        TagSection Start(TagSection adapter);
        TagSection End(TagSection adapter);

        TagTable Start(TagTable adapter);
        TagTable End(TagTable adapter);

        TagTfoot Start(TagTfoot adapter);
        TagTfoot End(TagTfoot adapter);

        TagUl Start(TagUl adapter);
        TagUl End(TagUl adapter);

        TagVideo Start(TagVideo adapter);
        TagVideo End(TagVideo adapter);

        #endregion

        #region inline level tags

        TagA Start(TagA adapter);
        TagA End(TagA adapter);

        TagAbbr Start(TagAbbr adapter);
        TagAbbr End(TagAbbr adapter);

        TagAcronym Start(TagAcronym adapter);
        TagAcronym End(TagAcronym adapter);

        TagB Start(TagB adapter);
        TagB End(TagB adapter);

        TagBdo Start(TagBdo adapter);
        TagBdo End(TagBdo adapter);

        TagBig Start(TagBig adapter);
        TagBig End(TagBig adapter);

        TagButton Start(TagButton adapter);
        TagButton End(TagButton adapter);

        TagCite Start(TagCite adapter);
        TagCite End(TagCite adapter);

        TagCode Start(TagCode adapter);
        TagCode End(TagCode adapter);

        TagDfn Start(TagDfn adapter);
        TagDfn End(TagDfn adapter);

        TagEm Start(TagEm adapter);
        TagEm End(TagEm adapter);

        TagI Start(TagI adapter);
        TagI End(TagI adapter);

        TagKbd Start(TagKbd adapter);
        TagKbd End(TagKbd adapter);

        TagLabel Start(TagLabel adapter);
        TagLabel End(TagLabel adapter);

        TagMap Start(TagMap adapter);
        TagMap End(TagMap adapter);

        TagObject Start(TagObject adapter);
        TagObject End(TagObject adapter);

        TagQ Start(TagQ adapter);
        TagQ End(TagQ adapter);

        TagSamp Start(TagSamp adapter);
        TagSamp End(TagSamp adapter);

        TagSelect Start(TagSelect adapter);
        TagSelect End(TagSelect adapter);

        TagSmall Start(TagSmall adapter);
        TagSmall End(TagSmall adapter);

        TagSpan Start(TagSpan adapter);
        TagSpan End(TagSpan adapter);

        TagStrong Start(TagStrong adapter);
        TagStrong End(TagStrong adapter);

        TagSub Start(TagSub adapter);
        TagSub End(TagSub adapter);

        TagSup Start(TagSup adapter);
        TagSup End(TagSup adapter);

        TagTt Start(TagTt adapter);
        TagTt End(TagTt adapter);

        TagVar Start(TagVar adapter);
        TagVar End(TagVar adapter);

        #endregion

        TagAudio Start(TagAudio adapter);
        TagAudio End(TagAudio adapter);

        TagBdi Start(TagBdi adapter);
        TagBdi End(TagBdi adapter);

        void Start(TagCaption adapter);
        void End(TagCaption adapter);

        void Start(TagCenter adapter);
        void End(TagCenter adapter);

        void Start(TagCol adapter);
        void End(TagCol adapter);

        void Start(TagColgroup adapter);
        void End(TagColgroup adapter);

        void Start(TagCommand adapter);
        void End(TagCommand adapter);

        void Start(TagDatalist adapter);
        void End(TagDatalist adapter);

        void Start(TagDel adapter);
        void End(TagDel adapter);

        void Start(TagDetails adapter);
        void End(TagDetails adapter);

        void Start(TagDialog adapter);
        void End(TagDialog adapter);

        void Start(TagDt adapter);
        void End(TagDt adapter);

        void Start(TagFont adapter);
        void End(TagFont adapter);

        void Start(TagIframe adapter);
        void End(TagIframe adapter);

        void Start(TagIns adapter);
        void End(TagIns adapter);

        void Start(TagKeygen adapter);
        void End(TagKeygen adapter);

        void Start(TagLegend adapter);
        void End(TagLegend adapter);

        void Start(TagMark adapter);
        void End(TagMark adapter);

        void Start(TagMenu adapter);
        void End(TagMenu adapter);

        void Start(TagMenuitem adapter);
        void End(TagMenuitem adapter);

        void Start(TagMeter adapter);
        void End(TagMeter adapter);

        void Start(TagOptgroup adapter);
        void End(TagOptgroup adapter);

        void Start(TagPicture adapter);
        void End(TagPicture adapter);

        void Start(TagRp adapter);
        void Start(TagRt adapter);
        void Start(TagRuby adapter);
        void End(TagRp adapter);
        void End(TagRt adapter);
        void End(TagRuby adapter);

        void Start(TagS adapter);
        void End(TagS adapter);

        void Start(TagStrike adapter);
        void End(TagStrike adapter);

        void Start(TagSummary adapter);
        void End(TagSummary adapter);

        TagTbody Start(TagTbody adapter);
        TagTbody End(TagTbody adapter);

        void Start(TagTd adapter);
        void End(TagTd adapter);

        void Start(TagTh adapter);
        void End(TagTh adapter);

        void Start(TagThead adapter);
        void End(TagThead adapter);

        void Start(TagTime adapter);
        void End(TagTime adapter);

        void Start(TagTr adapter);
        void End(TagTr adapter);

        void Start(TagU adapter);
        void End(TagU adapter);
    }
}