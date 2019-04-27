using HtmlWalker;
using HtmlWalker.Platform;
using System.Collections.Generic;

namespace DomWalker
{
    public abstract class DomFactory<A, D> : WalkerPlatform.WalkerFactory where A : DomApi<D>
    {
        internal protected DomFactory(A api, D dom, WalkerPlatform platform)
        {
            DApi = api;
            Dom = dom;
            Platform = platform;
        }

        public abstract void Close();

        internal A DApi { get; }

        internal protected D Dom { get; set; }

        public override WalkerPlatform Platform { get; }

        protected override IList<object> CreateContent(ITag adapter)
            => DApi.GetContent(Dom, adapter);

        protected override object CreateTextNode(string text) => DApi.CreateTextNode(Dom, text);

        protected override object CreateEntityNode(string entity)
            => DApi.CreateEntityNode(Dom, entity);

        #region abstract methods to create HTML tags

        protected override object CreateA() => DApi.CreateElement(Dom, "a");
        protected override object CreateAbbr() => DApi.CreateElement(Dom, "abbr");
        protected override object CreateAcronym() => DApi.CreateElement(Dom, "acronym");
        protected override object CreateAddress() => DApi.CreateElement(Dom, "address");
        protected override object CreateArea() => DApi.CreateElement(Dom, "area");
        protected override object CreateArticle() => DApi.CreateElement(Dom, "article");
        protected override object CreateAside() => DApi.CreateElement(Dom, "aside");
        protected override object CreateAudio() => DApi.CreateElement(Dom, "audio");
        protected override object CreateB() => DApi.CreateElement(Dom, "b");
        protected override object CreateBase() => DApi.CreateElement(Dom, "base");
        protected override object CreateBdi() => DApi.CreateElement(Dom, "bdi");
        protected override object CreateBdo() => DApi.CreateElement(Dom, "bdo");
        protected override object CreateBig() => DApi.CreateElement(Dom, "big");
        protected override object CreateBlockquote() => DApi.CreateElement(Dom, "blockquote");
        protected override object CreateBody() => DApi.CreateElement(Dom, "body");
        protected override object CreateBr() => DApi.CreateElement(Dom, "br");
        protected override object CreateButton() => DApi.CreateElement(Dom, "button");
        protected override object CreateCanvas() => DApi.CreateElement(Dom, "canvas");
        protected override object CreateCaption() => DApi.CreateElement(Dom, "caption");
        protected override object CreateCenter() => DApi.CreateElement(Dom, "center");
        protected override object CreateCite() => DApi.CreateElement(Dom, "cite");
        protected override object CreateCode() => DApi.CreateElement(Dom, "code");
        protected override object CreateCol() => DApi.CreateElement(Dom, "col");
        protected override object CreateColgroup() => DApi.CreateElement(Dom, "colgroup");
        protected override object CreateCommand() => DApi.CreateElement(Dom, "command");
        protected override object CreateDatalist() => DApi.CreateElement(Dom, "datalist");
        protected override object CreateDd() => DApi.CreateElement(Dom, "dd");
        protected override object CreateDel() => DApi.CreateElement(Dom, "del");
        protected override object CreateDetails() => DApi.CreateElement(Dom, "details");
        protected override object CreateDialog() => DApi.CreateElement(Dom, "dialog");
        protected override object CreateDiv() => DApi.CreateElement(Dom, "div");
        protected override object CreateDfn() => DApi.CreateElement(Dom, "dfn");
        protected override object CreateDl() => DApi.CreateElement(Dom, "dl");
        protected override object CreateDt() => DApi.CreateElement(Dom, "dt");
        protected override object CreateEm() => DApi.CreateElement(Dom, "em");
        protected override object CreateEmbed() => DApi.CreateElement(Dom, "embed");
        protected override object CreateFigcaption() => DApi.CreateElement(Dom, "figcaption");
        protected override object CreateFigure() => DApi.CreateElement(Dom, "figure");
        protected override object CreateFieldset() => DApi.CreateElement(Dom, "fieldset");
        protected override object CreateFooter() => DApi.CreateElement(Dom, "footer");
        protected override object CreateFont() => DApi.CreateElement(Dom, "font");
        protected override object CreateForm() => DApi.CreateElement(Dom, "form");
        protected override object CreateH1() => DApi.CreateElement(Dom, "h1");
        protected override object CreateH2() => DApi.CreateElement(Dom, "h2");
        protected override object CreateH3() => DApi.CreateElement(Dom, "h3");
        protected override object CreateH4() => DApi.CreateElement(Dom, "h4");
        protected override object CreateH5() => DApi.CreateElement(Dom, "h5");
        protected override object CreateH6() => DApi.CreateElement(Dom, "h6");
        protected override object CreateHead() => DApi.CreateElement(Dom, "head");
        protected override object CreateHeader() => DApi.CreateElement(Dom, "header");
        protected override object CreateHgroup() => DApi.CreateElement(Dom, "hgroup");
        protected override object CreateHtml()
        {
            var tag = DApi.HtmlElement(Dom);
            if (tag == null)
                tag = DApi.CreateElement(Dom, "html");
            return tag;
        }
        protected override object CreateHr() => DApi.CreateElement(Dom, "hr");
        protected override object CreateI() => DApi.CreateElement(Dom, "i");
        protected override object CreateIframe() => DApi.CreateElement(Dom, "iframe");
        protected override object CreateImg() => DApi.CreateElement(Dom, "img");
        protected override object CreateInput() => DApi.CreateElement(Dom, "input");
        protected override object CreateIns() => DApi.CreateElement(Dom, "ins");
        protected override object CreateKbd() => DApi.CreateElement(Dom, "kbd");
        protected override object CreateKeygen() => DApi.CreateElement(Dom, "keygen");
        protected override object CreateLabel() => DApi.CreateElement(Dom, "label");
        protected override object CreateLegend() => DApi.CreateElement(Dom, "legend");
        protected override object CreateLi() => DApi.CreateElement(Dom, "li");
        protected override object CreateLink() => DApi.CreateElement(Dom, "link");
        protected override object CreateMain() => DApi.CreateElement(Dom, "main");
        protected override object CreateMap() => DApi.CreateElement(Dom, "map");
        protected override object CreateMark() => DApi.CreateElement(Dom, "mark");
        protected override object CreateMenu() => DApi.CreateElement(Dom, "menu");
        protected override object CreateMenuitem() => DApi.CreateElement(Dom, "menuitem");
        protected override object CreateMeta() => DApi.CreateElement(Dom, "meta");
        protected override object CreateMeter() => DApi.CreateElement(Dom, "meter");
        protected override object CreateNav() => DApi.CreateElement(Dom, "nav");
        protected override object CreateNoscript() => DApi.CreateElement(Dom, "noscript");
        protected override object CreateObject() => DApi.CreateElement(Dom, "object");
        protected override object CreateOl() => DApi.CreateElement(Dom, "ol");
        protected override object CreateOptgroup() => DApi.CreateElement(Dom, "optgroup");
        protected override object CreateOption() => DApi.CreateElement(Dom, "option");
        protected override object CreateOutput() => DApi.CreateElement(Dom, "output");
        protected override object CreateP() => DApi.CreateElement(Dom, "p");
        protected override object CreateParam() => DApi.CreateElement(Dom, "param");
        protected override object CreatePicture() => DApi.CreateElement(Dom, "picture");
        protected override object CreatePre() => DApi.CreateElement(Dom, "pre");
        protected override object CreateProgress() => DApi.CreateElement(Dom, "progress");
        protected override object CreateQ() => DApi.CreateElement(Dom, "q");
        protected override object CreateRp() => DApi.CreateElement(Dom, "rp");
        protected override object CreateRt() => DApi.CreateElement(Dom, "rt");
        protected override object CreateRuby() => DApi.CreateElement(Dom, "ruby");
        protected override object CreateS() => DApi.CreateElement(Dom, "s");
        protected override object CreateSamp() => DApi.CreateElement(Dom, "samp");
        protected override object CreateScript() => DApi.CreateElement(Dom, "script");
        protected override object CreateSection() => DApi.CreateElement(Dom, "section");
        protected override object CreateSelect() => DApi.CreateElement(Dom, "select");
        protected override object CreateSmall() => DApi.CreateElement(Dom, "small");
        protected override object CreateSource() => DApi.CreateElement(Dom, "source");
        protected override object CreateSpan() => DApi.CreateElement(Dom, "span");
        protected override object CreateStrike() => DApi.CreateElement(Dom, "strike");
        protected override object CreateStrong() => DApi.CreateElement(Dom, "strong");
        protected override object CreateStyle() => DApi.CreateElement(Dom, "style");
        protected override object CreateSub() => DApi.CreateElement(Dom, "sub");
        protected override object CreateSummary() => DApi.CreateElement(Dom, "summary");
        protected override object CreateSup() => DApi.CreateElement(Dom, "sup");
        protected override object CreateTable() => DApi.CreateElement(Dom, "table");
        protected override object CreateTbody() => DApi.CreateElement(Dom, "tbody");
        protected override object CreateTd() => DApi.CreateElement(Dom, "td");
        protected override object CreateTextarea() => DApi.CreateElement(Dom, "textarea");
        protected override object CreateTfoot() => DApi.CreateElement(Dom, "tfoot");
        protected override object CreateTh() => DApi.CreateElement(Dom, "th");
        protected override object CreateThead() => DApi.CreateElement(Dom, "thead");
        protected override object CreateTime() => DApi.CreateElement(Dom, "time");
        protected override object CreateTitle() => DApi.CreateElement(Dom, "title");
        protected override object CreateTr() => DApi.CreateElement(Dom, "tr");
        protected override object CreateTrack() => DApi.CreateElement(Dom, "track");
        protected override object CreateTt() => DApi.CreateElement(Dom, "tt");
        protected override object CreateU() => DApi.CreateElement(Dom, "u");
        protected override object CreateUl() => DApi.CreateElement(Dom, "ul");
        protected override object CreateVar() => DApi.CreateElement(Dom, "var");
        protected override object CreateVideo() => DApi.CreateElement(Dom, "video");
        protected override object CreateWbr() => DApi.CreateElement(Dom, "wbr");

        #endregion
    }
}
