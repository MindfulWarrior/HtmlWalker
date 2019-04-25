using HtmlWalker.Core;
using HtmlWalker.Tag.Base;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace HtmlWalker.Platform
{
    public abstract partial class WalkerPlatform
    {
        /// <summary>
        ///   This abstract class is overwritten to provide the factory that generates tag object specific to the platform
        /// </summary>
        /// <author>Robert R Flores</author>
        public abstract class WalkerFactory
        {
            private static readonly Type[] ctorArgs = new Type[] { typeof(WalkerPlatform.WalkerFactory), typeof(object) };

            private static readonly Dictionary<string, ConstructorInfo> Map = new Dictionary<string, ConstructorInfo>();

            static WalkerFactory()
            {
                Map.Add("a", typeof(TagA).GetConstructor(ctorArgs));
                Map.Add("abbr", typeof(TagAbbr).GetConstructor(ctorArgs));
                Map.Add("acronym", typeof(TagAcronym).GetConstructor(ctorArgs));
                Map.Add("address", typeof(TagAddress).GetConstructor(ctorArgs));
                Map.Add("area", typeof(TagArea).GetConstructor(ctorArgs));
                Map.Add("article", typeof(TagArticle).GetConstructor(ctorArgs));
                Map.Add("aside", typeof(TagAside).GetConstructor(ctorArgs));
                Map.Add("audio", typeof(TagAudio).GetConstructor(ctorArgs));
                Map.Add("b", typeof(TagB).GetConstructor(ctorArgs));
                Map.Add("base", typeof(TagBase).GetConstructor(ctorArgs));
                Map.Add("bdi", typeof(TagBdi).GetConstructor(ctorArgs));
                Map.Add("bdo", typeof(TagBdo).GetConstructor(ctorArgs));
                Map.Add("big", typeof(TagBig).GetConstructor(ctorArgs));
                Map.Add("blockquote", typeof(TagBlockquote).GetConstructor(ctorArgs));
                Map.Add("body", typeof(TagBody).GetConstructor(ctorArgs));
                Map.Add("br", typeof(TagBr).GetConstructor(ctorArgs));
                Map.Add("button", typeof(TagButton).GetConstructor(ctorArgs));
                Map.Add("canvas", typeof(TagCanvas).GetConstructor(ctorArgs));
                Map.Add("caption", typeof(TagCaption).GetConstructor(ctorArgs));
                Map.Add("center", typeof(TagCenter).GetConstructor(ctorArgs));
                Map.Add("cite", typeof(TagCite).GetConstructor(ctorArgs));
                Map.Add("code", typeof(TagCode).GetConstructor(ctorArgs));
                Map.Add("col", typeof(TagCol).GetConstructor(ctorArgs));
                Map.Add("colgroup", typeof(TagColgroup).GetConstructor(ctorArgs));
                Map.Add("command", typeof(TagCommand).GetConstructor(ctorArgs));
                Map.Add("datalist", typeof(TagDatalist).GetConstructor(ctorArgs));
                Map.Add("dd", typeof(TagDd).GetConstructor(ctorArgs));
                Map.Add("del", typeof(TagDel).GetConstructor(ctorArgs));
                Map.Add("details", typeof(TagDetails).GetConstructor(ctorArgs));
                Map.Add("dfn", typeof(TagDfn).GetConstructor(ctorArgs));
                Map.Add("dialog", typeof(TagDialog).GetConstructor(ctorArgs));
                Map.Add("div", typeof(TagDiv).GetConstructor(ctorArgs));
                Map.Add("dl", typeof(TagDl).GetConstructor(ctorArgs));
                Map.Add("dt", typeof(TagDt).GetConstructor(ctorArgs));
                Map.Add("em", typeof(TagEm).GetConstructor(ctorArgs));
                Map.Add("embed", typeof(TagEmbed).GetConstructor(ctorArgs));
                Map.Add("fieldset", typeof(TagFieldset).GetConstructor(ctorArgs));
                Map.Add("figcaption", typeof(TagFigcaption).GetConstructor(ctorArgs));
                Map.Add("figure", typeof(TagFigure).GetConstructor(ctorArgs));
                Map.Add("font", typeof(TagFont).GetConstructor(ctorArgs));
                Map.Add("footer", typeof(TagFooter).GetConstructor(ctorArgs));
                Map.Add("form", typeof(TagForm).GetConstructor(ctorArgs));
                Map.Add("h1", typeof(TagH1).GetConstructor(ctorArgs));
                Map.Add("h2", typeof(TagH2).GetConstructor(ctorArgs));
                Map.Add("h3", typeof(TagH3).GetConstructor(ctorArgs));
                Map.Add("h4", typeof(TagH4).GetConstructor(ctorArgs));
                Map.Add("h5", typeof(TagH5).GetConstructor(ctorArgs));
                Map.Add("h6", typeof(TagH6).GetConstructor(ctorArgs));
                Map.Add("head", typeof(TagHead).GetConstructor(ctorArgs));
                Map.Add("header", typeof(TagHeader).GetConstructor(ctorArgs));
                Map.Add("hgroup", typeof(TagHgroup).GetConstructor(ctorArgs));
                Map.Add("html", typeof(TagHtml).GetConstructor(ctorArgs));
                Map.Add("hr", typeof(TagHr).GetConstructor(ctorArgs));
                Map.Add("i", typeof(TagI).GetConstructor(ctorArgs));
                Map.Add("iframe", typeof(TagIframe).GetConstructor(ctorArgs));
                Map.Add("img", typeof(TagImg).GetConstructor(ctorArgs));
                Map.Add("input", typeof(TagInput).GetConstructor(ctorArgs));
                Map.Add("kbd", typeof(TagKbd).GetConstructor(ctorArgs));
                Map.Add("keygen", typeof(TagKeygen).GetConstructor(ctorArgs));
                Map.Add("ins", typeof(TagIns).GetConstructor(ctorArgs));
                Map.Add("label", typeof(TagLabel).GetConstructor(ctorArgs));
                Map.Add("legend", typeof(TagLegend).GetConstructor(ctorArgs));
                Map.Add("li", typeof(TagLi).GetConstructor(ctorArgs));
                Map.Add("link", typeof(TagLink).GetConstructor(ctorArgs));
                Map.Add("main", typeof(TagMain).GetConstructor(ctorArgs));
                Map.Add("map", typeof(TagMap).GetConstructor(ctorArgs));
                Map.Add("mark", typeof(TagMark).GetConstructor(ctorArgs));
                Map.Add("menu", typeof(TagMenu).GetConstructor(ctorArgs));
                Map.Add("menuitem", typeof(TagMenuitem).GetConstructor(ctorArgs));
                Map.Add("meta", typeof(TagMeta).GetConstructor(ctorArgs));
                Map.Add("meter", typeof(TagMeter).GetConstructor(ctorArgs));
                Map.Add("nav", typeof(TagNav).GetConstructor(ctorArgs));
                Map.Add("noscript", typeof(TagNoscript).GetConstructor(ctorArgs));
                Map.Add("object", typeof(TagObject).GetConstructor(ctorArgs));
                Map.Add("ol", typeof(TagOl).GetConstructor(ctorArgs));
                Map.Add("optgroup", typeof(TagOptgroup).GetConstructor(ctorArgs));
                Map.Add("option", typeof(TagOption).GetConstructor(ctorArgs));
                Map.Add("output", typeof(TagOutput).GetConstructor(ctorArgs));
                Map.Add("p", typeof(TagP).GetConstructor(ctorArgs));
                Map.Add("param", typeof(TagParam).GetConstructor(ctorArgs));
                Map.Add("picture", typeof(TagPicture).GetConstructor(ctorArgs));
                Map.Add("pre", typeof(TagPre).GetConstructor(ctorArgs));
                Map.Add("progress", typeof(TagProgress).GetConstructor(ctorArgs));
                Map.Add("q", typeof(TagQ).GetConstructor(ctorArgs));
                Map.Add("rp", typeof(TagRp).GetConstructor(ctorArgs));
                Map.Add("rt", typeof(TagRt).GetConstructor(ctorArgs));
                Map.Add("ruby", typeof(TagRuby).GetConstructor(ctorArgs));
                Map.Add("s", typeof(TagS).GetConstructor(ctorArgs));
                Map.Add("samp", typeof(TagSamp).GetConstructor(ctorArgs));
                Map.Add("script", typeof(TagScript).GetConstructor(ctorArgs));
                Map.Add("section", typeof(TagSection).GetConstructor(ctorArgs));
                Map.Add("select", typeof(TagSelect).GetConstructor(ctorArgs));
                Map.Add("small", typeof(TagSmall).GetConstructor(ctorArgs));
                Map.Add("source", typeof(TagSource).GetConstructor(ctorArgs));
                Map.Add("span", typeof(TagSpan).GetConstructor(ctorArgs));
                Map.Add("strike", typeof(TagStrike).GetConstructor(ctorArgs));
                Map.Add("strong", typeof(TagStrong).GetConstructor(ctorArgs));
                Map.Add("style", typeof(TagStyle).GetConstructor(ctorArgs));
                Map.Add("sub", typeof(TagSub).GetConstructor(ctorArgs));
                Map.Add("summary", typeof(TagSummary).GetConstructor(ctorArgs));
                Map.Add("sup", typeof(TagSup).GetConstructor(ctorArgs));
                Map.Add("table", typeof(TagTable).GetConstructor(ctorArgs));
                Map.Add("tbody", typeof(TagTbody).GetConstructor(ctorArgs));
                Map.Add("td", typeof(TagTd).GetConstructor(ctorArgs));
                Map.Add("textarea", typeof(TagTextarea).GetConstructor(ctorArgs));
                Map.Add("tfoot", typeof(TagTfoot).GetConstructor(ctorArgs));
                Map.Add("th", typeof(TagTh).GetConstructor(ctorArgs));
                Map.Add("thead", typeof(TagThead).GetConstructor(ctorArgs));
                Map.Add("time", typeof(TagTime).GetConstructor(ctorArgs));
                Map.Add("title", typeof(TagTitle).GetConstructor(ctorArgs));
                Map.Add("tr", typeof(TagTr).GetConstructor(ctorArgs));
                Map.Add("track", typeof(TagTrack).GetConstructor(ctorArgs));
                Map.Add("tt", typeof(TagTt).GetConstructor(ctorArgs));
                Map.Add("u", typeof(TagU).GetConstructor(ctorArgs));
                Map.Add("ul", typeof(TagUl).GetConstructor(ctorArgs));
                Map.Add("var", typeof(TagVar).GetConstructor(ctorArgs));
                Map.Add("video", typeof(TagVideo).GetConstructor(ctorArgs));
                Map.Add("wbr", typeof(TagWbr).GetConstructor(ctorArgs));

                Map.Add("#text", typeof(Text).GetConstructor(ctorArgs));
                Map.Add("#entity", typeof(Entity).GetConstructor(ctorArgs));
                Map.Add("#eol", typeof(Eol).GetConstructor(ctorArgs));
                Map.Add("#skip", typeof(Skip).GetConstructor(ctorArgs));
                Map.Add("#comment", typeof(Comment).GetConstructor(ctorArgs));
            }

            internal object CreateText(string text)
            {
                if (ConvertToEntities)
                    return CreateTextNode(EscHandler.Instance.Escape(text));
                return CreateTextNode(text);
            }

            /// <summary>
            ///   Default destructor defined to hide from <b>public</b>
            /// </summary>
            protected WalkerFactory() { }

            /// <summary>
            ///   If <b>true</b>, break text in to <see cref="Text"/> and <see cref="Eol"/> tags.
            /// </summary>
            internal bool ProvideEol = false;

            /// <summary>
            ///   Convert raw text to entities using <see cref="EscHandler.Escape(string)"/>
            ///   Unlike <see cref="WalkerPlatform.KeepEntities(bool)"/>, this is regardless of platform
            ///   and assumes enties already converted before becomming <see cref="Walker.Input"/>
            /// </summary>
            public bool ConvertToEntities = false;

            /// <summary>
            ///   The <see cref="WalkerPlatform"/> associated with this factory
            /// </summary>
            public abstract WalkerPlatform Platform { get; }

            internal protected abstract ITagApi Api { get; }

            /// <summary>
            ///   This method creates instances of tag adapters based on the tag object passed.
            ///   The <see cref="WalkerPlatform.ITagApi"/> is used to get the tag name and map it to the appropriate tag adapter constructor.
            /// </summary>
            /// <param name="owner">the owner of the tag object passed</param>
            /// <param name="obj">the tag object to be housed by the tag adapter</param>
            /// <param name="tagName">optional parameter to know which tag adaper to create</param>
            /// <returns>the new tag adapter</returns>
            internal virtual ITag CreateAdapter(ITag owner, object obj, string tagName = null)
            {
                if (tagName == null)
                    tagName = Api.Name(obj);

                if (tagName != null)
                {
                    BaseTag adapter;
                    if (Map.ContainsKey(tagName))
                        adapter = (BaseTag)Map[tagName].Invoke(new object[] { this, obj });
                    else
                        adapter = new Unknown(this, obj);
                    if (owner != null)
                        adapter.Owner = owner;
                    return adapter;
                }
                return null;
            }

            /// <summary>
            ///   Provides the platform specific way to make a shallow clone of an HTML tag
            /// </summary>
            /// <param name="tag"></param>
            /// <returns></returns>
            internal protected abstract object CloneTag(object tag);

            /// <summary>
            ///   This method is overwritten to provide the platform specific way of
            ///   creating a walker content object from a tag adapter.
            /// </summary>
            /// <param name="adapter">the tag adapter owning the content</param>
            /// <returns>the walker content</returns>
            internal protected abstract IList<object> CreateContent(ITag adapter);

            /// <summary>
            ///   Creates a new object represting a text within our outside fo a tag
            /// </summary>
            /// <param name="text">text to hold</param>
            /// <returns>the text object</returns>
            internal protected abstract object CreateTextNode(string text);

            /// <summary>
            ///   Creates a new object represting a text within our outside fo a tag
            /// </summary>
            /// <param name="entity">entity string to hold</param>
            /// <returns>the text object</returns>
            internal protected abstract object CreateEntityNode(string entity);

            #region abstract methods to create HTML tags

            /// <summary>
            ///   Creates a new <b>&lt;a&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;a&gt;</b> tag object</returns>
            internal protected abstract object CreateA();

            /// <summary>
            ///   Creates a new <b>&lt;abbr&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;abbr&gt;</b> tag object</returns>
            internal protected abstract object CreateAbbr();

            /// <summary>
            ///   Creates a new <b>&lt;acronym&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;acronym&gt;</b> tag object</returns>
            internal protected abstract object CreateAcronym();

            /// <summary>
            ///   Creates a new <b>&lt;address&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;address&gt;</b> tag object</returns>
            internal protected abstract object CreateAddress();

            /// <summary>
            ///   Creates a new <b>&lt;area&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;area&gt;</b> tag object</returns>
            internal protected abstract object CreateArea();

            /// <summary>
            ///   Creates a new <b>&lt;article&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;article&gt;</b> tag object</returns>
            internal protected abstract object CreateArticle();

            /// <summary>
            ///   Creates a new <b>&lt;aside&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;aside&gt;</b> tag object</returns>
            internal protected abstract object CreateAside();

            /// <summary>
            ///   Creates a new <b>&lt;audio&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;audio&gt;</b> tag object</returns>
            internal protected abstract object CreateAudio();

            /// <summary>
            ///   Creates a new <b>&lt;b&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;b&gt;</b> tag object</returns>
            internal protected abstract object CreateB();

            /// <summary>
            ///   Creates a new <b>&lt;base&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;base&gt;</b> tag object</returns>
            internal protected abstract object CreateBase();

            /// <summary>
            ///   Creates a new <b>&lt;bdi&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;bdi&gt;</b> tag object</returns>
            internal protected abstract object CreateBdi();

            /// <summary>
            ///   Creates a new <b>&lt;bdo&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;bdo&gt;</b> tag object</returns>
            internal protected abstract object CreateBdo();

            /// <summary>
            ///   Creates a new <b>&lt;big&gt;</b>
            /// </summary>
            /// <returns></returns>
            internal protected abstract object CreateBig();

            /// <summary>
            ///   Creates a new <b>&lt;blockquote&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;blockquote&gt;</b> tag object</returns>
            internal protected abstract object CreateBlockquote();

            /// <summary>
            ///   Creates a new <b>&lt;body&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;body&gt;</b> tag object</returns>
            internal protected abstract object CreateBody();

            /// <summary>
            ///   Creates a new <b>&lt;br&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;br&gt;</b> tag object</returns>
            internal protected abstract object CreateBr();

            /// <summary>
            ///   Creates a new <b>&lt;button&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;button&gt;</b> tag object</returns>
            internal protected abstract object CreateButton();

            /// <summary>
            ///   Creates a new <b>&lt;canvas&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;canvas&gt;</b> tag object</returns>
            internal protected abstract object CreateCanvas();

            /// <summary>
            ///   Creates a new <b>&lt;caption&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;caption&gt;</b> tag object</returns>
            internal protected abstract object CreateCaption();

            /// <summary>
            ///   Creates a new <b>&lt;center&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;center&gt;</b> tag object</returns>
            internal protected abstract object CreateCenter();

            /// <summary>
            ///   Creates a new <b>&lt;cite&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;cite&gt;</b> tag object</returns>
            internal protected abstract object CreateCite();

            /// <summary>
            ///   Creates a new <b>&lt;code&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;code&gt;</b> tag object</returns>
            internal protected abstract object CreateCode();

            /// <summary>
            ///   Creates a new <b>&lt;col&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;col&gt;</b> tag object</returns>
            internal protected abstract object CreateCol();

            /// <summary>
            ///   Creates a new <b>&lt;colgroup&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;colgroup&gt;</b> tag object</returns>
            internal protected abstract object CreateColgroup();

            /// <summary>
            ///   Creates a new <b>&lt;command&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;command&gt;</b> tag object</returns>
            internal protected abstract object CreateCommand();

            /// <summary>
            ///   Creates a new <b>&lt;datalist&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;datalist&gt;</b> tag object</returns>
            internal protected abstract object CreateDatalist();

            /// <summary>
            ///   Creates a new <b>&lt;dd&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;dd&gt;</b> tag object</returns>
            internal protected abstract object CreateDd();

            /// <summary>
            ///   Creates a new <b>&lt;del&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;del&gt;</b> tag object</returns>
            internal protected abstract object CreateDel();

            /// <summary>
            ///   Creates a new <b>&lt;details&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;details&gt;</b> tag object</returns>
            internal protected abstract object CreateDetails();

            /// <summary>
            ///   Creates a new <b>&lt;dfn&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;dfn&gt;</b> tag object</returns>
            internal protected abstract object CreateDfn();

            /// <summary>
            ///   Creates a new <b>&lt;dialog&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;dialog&gt;</b> tag object</returns>
            internal protected abstract object CreateDialog();

            /// <summary>
            ///   Creates a new <b>&lt;div&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;div&gt;</b> tag object</returns>
            internal protected abstract object CreateDiv();

            /// <summary>
            ///   Creates a new <b>&lt;dl&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;dl&gt;</b> tag object</returns>
            internal protected abstract object CreateDl();

            /// <summary>
            ///   Creates a new <b>&lt;dt&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;dt&gt;</b> tag object</returns>
            internal protected abstract object CreateDt();

            /// <summary>
            ///   Creates a new <b>&lt;em&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;em&gt;</b> tag object</returns>
            internal protected abstract object CreateEm();

            /// <summary>
            ///   Creates a new <b>&lt;&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;&gt;</b> tag object</returns>
            internal protected abstract object CreateEmbed();

            /// <summary>
            ///   Creates a new <b>&lt;fieldset&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;fieldset&gt;</b> tag object</returns>
            internal protected abstract object CreateFieldset();

            /// <summary>
            ///   Creates a new <b>&lt;figcaption&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;figcaption&gt;</b> tag object</returns>
            internal protected abstract object CreateFigcaption();

            /// <summary>
            ///   Creates a new <b>&lt;figure&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;figure&gt;</b> tag object</returns>
            internal protected abstract object CreateFigure();

            /// <summary>
            ///   Creates a new <b>&lt;font&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;font&gt;</b> tag object</returns>
            internal protected abstract object CreateFont();

            /// <summary>
            ///   Creates a new <b>&lt;footer&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;footer&gt;</b> tag object</returns>
            internal protected abstract object CreateFooter();

            /// <summary>
            ///   Creates a new <b>&lt;form&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;form&gt;</b> tag object</returns>
            internal protected abstract object CreateForm();

            /// <summary>
            ///   Creates a new <b>&lt;h1&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;h1&gt;</b> tag object</returns>
            internal protected abstract object CreateH1();

            /// <summary>
            ///   Creates a new <b>&lt;h2&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;h2&gt;</b> tag object</returns>
            internal protected abstract object CreateH2();

            /// <summary>
            ///   Creates a new <b>&lt;h3&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;h3&gt;</b> tag object</returns>
            internal protected abstract object CreateH3();

            /// <summary>
            ///   Creates a new <b>&lt;h4&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;h4&gt;</b> tag object</returns>
            internal protected abstract object CreateH4();

            /// <summary>
            ///   Creates a new <b>&lt;h5&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;h5&gt;</b> tag object</returns>
            internal protected abstract object CreateH5();

            /// <summary>
            ///   Creates a new <b>&lt;h6&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;h6&gt;</b> tag object</returns>
            internal protected abstract object CreateH6();

            /// <summary>
            ///   Creates a new <b>&lt;hr&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;hr&gt;</b> tag object</returns>
            internal protected abstract object CreateHr();

            /// <summary>
            ///   Creates a new <b>&lt;head&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;head&gt;</b> tag object</returns>
            internal protected abstract object CreateHead();

            /// <summary>
            ///   Creates a new <b>&lt;header&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;header&gt;</b> tag object</returns>
            internal protected abstract object CreateHeader();

            /// <summary>
            ///   Creates a new <b>&lt;hgroup&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;hgroup&gt;</b> tag object</returns>
            internal protected abstract object CreateHgroup();

            /// <summary>
            ///   Creates a new <b>&lt;html&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;html&gt;</b> tag object</returns>
            internal protected abstract object CreateHtml();

            /// <summary>
            ///   Creates a new <b>&lt;i&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;i&gt;</b> tag object</returns>
            internal protected abstract object CreateI();

            /// <summary>
            ///   Creates a new <b>&lt;iframe&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;iframe&gt;</b> tag object</returns>
            internal protected abstract object CreateIframe();

            /// <summary>
            ///   Creates a new <b>&lt;img&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;img&gt;</b> tag object</returns>
            internal protected abstract object CreateImg();

            /// <summary>
            ///   Creates a new <b>&lt;input&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;input&gt;</b> tag object</returns>
            internal protected abstract object CreateInput();

            /// <summary>
            ///   Creates a new <b>&lt;ins&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;ins&gt;</b> tag object</returns>
            internal protected abstract object CreateIns();

            /// <summary>
            ///   Creates a new <b>&lt;keygen&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;keygen&gt;</b> tag object</returns>
            internal protected abstract object CreateKeygen();

            /// <summary>
            ///   Creates a new <b>&lt;kbd&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;kbd&gt;</b> tag object</returns>
            internal protected abstract object CreateKbd();

            /// <summary>
            ///   Creates a new <b>&lt;label&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;label&gt;</b> tag object</returns>
            internal protected abstract object CreateLabel();

            /// <summary>
            ///   Creates a new <b>&lt;legend&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;legend&gt;</b> tag object</returns>
            internal protected abstract object CreateLegend();

            /// <summary>
            ///   Creates a new <b>&lt;li&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;li&gt;</b> tag object</returns>
            internal protected abstract object CreateLi();

            /// <summary>
            ///   Creates a new <b>&lt;link&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;link&gt;</b> tag object</returns>
            internal protected abstract object CreateLink();

            /// <summary>
            ///   Creates a new <b>&lt;main&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;main&gt;</b> tag object</returns>
            internal protected abstract object CreateMain();

            /// <summary>
            ///   Creates a new <b>&lt;map&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;map&gt;</b> tag object</returns>
            internal protected abstract object CreateMap();

            /// <summary>
            ///   Creates a new <b>&lt;mark&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;mark&gt;</b> tag object</returns>
            internal protected abstract object CreateMark();

            /// <summary>
            ///   Creates a new <b>&lt;menu&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;menu&gt;</b> tag object</returns>
            internal protected abstract object CreateMenu();

            /// <summary>
            ///   Creates a new <b>&lt;menuitem&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;menuitem&gt;</b> tag object</returns>
            internal protected abstract object CreateMenuitem();

            /// <summary>
            ///   Creates a new <b>&lt;meta&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;meta&gt;</b> tag object</returns>
            internal protected abstract object CreateMeta();

            /// <summary>
            ///   Creates a new <b>&lt;meter&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;meter&gt;</b> tag object</returns>
            internal protected abstract object CreateMeter();

            /// <summary>
            ///   Creates a new <b>&lt;nav&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;nav&gt;</b> tag object</returns>
            internal protected abstract object CreateNav();

            /// <summary>
            ///   Creates a new <b>&lt;noscript&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;noscript&gt;</b> tag object</returns>
            internal protected abstract object CreateNoscript();

            /// <summary>
            ///   Creates a new <b>&lt;object&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;object&gt;</b> tag object</returns>
            internal protected abstract object CreateObject();

            /// <summary>
            ///   Creates a new <b>&lt;ol&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;ol&gt;</b> tag object</returns>
            internal protected abstract object CreateOl();

            /// <summary>
            ///   Creates a new <b>&lt;optgroup&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;optgroup&gt;</b> tag object</returns>
            internal protected abstract object CreateOptgroup();

            /// <summary>
            ///   Creates a new <b>&lt;option&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;option&gt;</b> tag object</returns>
            internal protected abstract object CreateOption();

            /// <summary>
            ///   Creates a new <b>&lt;output&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;output&gt;</b> tag object</returns>
            internal protected abstract object CreateOutput();

            /// <summary>
            ///   Creates a new <b>&lt;p&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;p&gt;</b> tag object</returns>
            internal protected abstract object CreateP();

            /// <summary>
            ///   Creates a new <b>&lt;param&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;param&gt;</b> tag object</returns>
            internal protected abstract object CreateParam();

            /// <summary>
            ///   Creates a new <b>&lt;picture&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;picture&gt;</b> tag object</returns>
            internal protected abstract object CreatePicture();

            /// <summary>
            ///   Creates a new <b>&lt;pre&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;pre&gt;</b> tag object</returns>
            internal protected abstract object CreatePre();

            /// <summary>
            ///   Creates a new <b>&lt;progress&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;progress&gt;</b> tag object</returns>
            internal protected abstract object CreateProgress();

            /// <summary>
            ///   Creates a new <b>&lt;q&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;q&gt;</b> tag object</returns>
            internal protected abstract object CreateQ();

            /// <summary>
            ///   Creates a new <b>&lt;rp&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;rp&gt;</b> tag object</returns>
            internal protected abstract object CreateRp();

            /// <summary>
            ///   Creates a new <b>&lt;rt&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;rt&gt;</b> tag object</returns>
            internal protected abstract object CreateRt();

            /// <summary>
            ///   Creates a new <b>&lt;ruby&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;ruby&gt;</b> tag object</returns>
            internal protected abstract object CreateRuby();

            /// <summary>
            ///   Creates a new <b>&lt;s&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;s&gt;</b> tag object</returns>
            internal protected abstract object CreateS();

            /// <summary>
            ///   Creates a new <b>&lt;samp&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;samp&gt;</b> tag object</returns>
            internal protected abstract object CreateSamp();

            /// <summary>
            ///   Creates a new <b>&lt;script&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;script&gt;</b> tag object</returns>
            internal protected abstract object CreateScript();

            /// <summary>
            ///   Creates a new <b>&lt;section&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;section&gt;</b> tag object</returns>
            internal protected abstract object CreateSection();

            /// <summary>
            ///   Creates a new <b>&lt;select&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;select&gt;</b> tag object</returns>
            internal protected abstract object CreateSelect();

            /// <summary>
            ///   Creates a new <b>&lt;small&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;small&gt;</b> tag object</returns>
            internal protected abstract object CreateSmall();

            /// <summary>
            ///   Creates a new <b>&lt;source&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;source&gt;</b> tag object</returns>
            internal protected abstract object CreateSource();

            /// <summary>
            ///   Creates a new <b>&lt;span&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;span&gt;</b> tag object</returns>
            internal protected abstract object CreateSpan();

            /// <summary>
            ///   Creates a new <b>&lt;strike&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;strike&gt;</b> tag object</returns>
            internal protected abstract object CreateStrike();

            /// <summary>
            ///   Creates a new <b>&lt;strong&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;strong&gt;</b> tag object</returns>
            internal protected abstract object CreateStrong();

            /// <summary>
            ///   Creates a new <b>&lt;style&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;style&gt;</b> tag object</returns>
            internal protected abstract object CreateStyle();

            /// <summary>
            ///   Creates a new <b>&lt;sub&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;sub&gt;</b> tag object</returns>
            internal protected abstract object CreateSub();

            /// <summary>
            ///   Creates a new <b>&lt;summary&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;summary&gt;</b> tag object</returns>
            internal protected abstract object CreateSummary();

            /// <summary>
            ///   Creates a new <b>&lt;sup&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;sup&gt;</b> tag object</returns>
            internal protected abstract object CreateSup();

            /// <summary>
            ///   Creates a new <b>&lt;table&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;table&gt;</b> tag object</returns>
            internal protected abstract object CreateTable();

            /// <summary>
            ///   Creates a new <b>&lt;tbody&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;tbody&gt;</b> tag object</returns>
            internal protected abstract object CreateTbody();

            /// <summary>
            ///   Creates a new <b>&lt;td&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;td&gt;</b> tag object</returns>
            internal protected abstract object CreateTd();

            /// <summary>
            ///   Creates a new <b>&lt;textarea&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;textarea&gt;</b> tag object</returns>
            internal protected abstract object CreateTextarea();

            /// <summary>
            ///   Creates a new <b>&lt;tfoot&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;tfoot&gt;</b> tag object</returns>
            internal protected abstract object CreateTfoot();

            /// <summary>
            ///   Creates a new <b>&lt;th&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;th&gt;</b> tag object</returns>
            internal protected abstract object CreateTh();

            /// <summary>
            ///   Creates a new <b>&lt;thead&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;thead&gt;</b> tag object</returns>
            internal protected abstract object CreateThead();

            /// <summary>
            ///   Creates a new <b>&lt;time&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;time&gt;</b> tag object</returns>
            internal protected abstract object CreateTime();

            /// <summary>
            ///   Creates a new <b>&lt;title&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;title&gt;</b> tag object</returns>
            internal protected abstract object CreateTitle();

            /// <summary>
            ///   Creates a new <b>&lt;tr&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;tr&gt;</b> tag object</returns>
            internal protected abstract object CreateTr();

            /// <summary>
            ///   Creates a new <b>&lt;track&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;track&gt;</b> tag object</returns>
            internal protected abstract object CreateTrack();

            /// <summary>
            ///   Creates a new <b>&lt;tt&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;tt&gt;</b> tag object</returns>
            internal protected abstract object CreateTt();

            /// <summary>
            ///   Creates a new <b>&lt;u&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;u&gt;</b> tag object</returns>
            internal protected abstract object CreateU();

            /// <summary>
            ///   Creates a new <b>&lt;ul&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;ul&gt;</b> tag object</returns>
            internal protected abstract object CreateUl();

            /// <summary>
            ///   Creates a new <b>&lt;var&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;var&gt;</b> tag object</returns>
            internal protected abstract object CreateVar();

            /// <summary>
            ///   Creates a new <b>&lt;video&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;video&gt;</b> tag object</returns>
            internal protected abstract object CreateVideo();

            /// <summary>
            ///   Creates a new <b>&lt;wbr&gt;</b> tag object
            /// </summary>
            /// <returns>the <b>&lt;wbr&gt;</b> tag object</returns>
            internal protected abstract object CreateWbr();

            #endregion
        }
    }
}
