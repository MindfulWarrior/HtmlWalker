using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;

namespace HtmlWalker.Visitor
{
    /// <summary>
    ///   This an HTML tag visitor used to define <see cref="Walker"/> and any other case were
    ///   a return value is not required.
    ///   
    ///   The set of HTML tags is the intersection of HTML5 and XHTML. These tags are not
    ///   included as they conform to neither:
    ///    
    ///   &lt;applet&gt;
    ///   &lt;basefont&gt;
    ///   &lt;bgsound&gt;
    ///   &lt;dir&gt;
    ///   &lt;frame&gt;
    ///   &lt;frameset&gt;
    ///   &lt;isindex&gt;
    ///   &lt;noframes&gt;
    /// 
    /// </summary>
    /// <author>Robert R Flores</author>
    public interface ITagVoidVisitor
    {
        /// <summary>
        ///  Visit the root element of the document
        /// </summary>
        /// <param name="adapter">document root adapter</param>
        void Visit(DocumentTag adapter);

        /// <summary>
        ///   Visitor pattern method for <see cref="Text"/>
        /// </summary>
        /// <param name="adapter">the text adapter</param>
        void Visit(Text adapter);

        /// <summary>
        ///   Visitor pattern method for <see cref="Eol"/>
        /// </summary>
        /// <param name="adapter">the eol adapter</param>
        void Visit(Eol adapter);

        /// <summary>
        ///   Vistior pattern method for <see cref="Entity"/>
        /// </summary>
        /// <param name="adapter">the entity adapter</param>
        void Visit(Entity adapter);

        /// <summary>
        ///   Vistior pattern method for <b>comment</b> adapter
        /// </summary>
        /// <param name="adapter">the comment adapter</param>
        void Visit(Comment adapter);

        /// <summary>
        ///   Vistior pattern method for <b>skip</b> adapter
        /// </summary>
        /// <param name="adapter">the skip adapter</param>
        void Visit(Skip adapter);

        /// <summary>
        ///   Vistior pattern method for <see cref="Unknown"/>
        /// </summary>
        /// <param name="adapter">the uknown adapter</param>
        void Visit(Unknown adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;a&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;a&gt;</b> tag adapter</param>
        void Visit(TagA adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;acronym&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;acronym&gt;</b> tag adapter</param>
        void Visit(TagAcronym adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;abbr&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;abbr&gt;</b> tag adapter</param>
        void Visit(TagAbbr adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;address&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;address&gt;</b> tag adapter</param>
        void Visit(TagAddress adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;area&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;area&gt;</b> tag adapter</param>
        void Visit(TagArea adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;article&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;article&gt;</b> tag adapter</param>
        void Visit(TagArticle adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;aside&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;aside&gt;</b> tag adapter</param>
        void Visit(TagAside adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;audio&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;audio&gt;</b> tag adapter</param>
        void Visit(TagAudio adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;b&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;b&gt;</b> tag adapter</param>
        void Visit(TagB adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;base&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;base&gt;</b> tag adapter</param>
        void Visit(TagBase adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;bdi&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;bdi&gt;</b> tag adapter</param>
        void Visit(TagBdi adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;bdo&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;bdo&gt;</b> tag adapter</param>
        void Visit(TagBdo adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;big&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;big&gt;</b> tag adapter</param>
        void Visit(TagBig adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;blockquote&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;blockquote&gt;</b> tag adapter</param>
        void Visit(TagBlockquote adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;&gt;</b> tag adapter</param>
        void Visit(TagBody adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;br&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;br&gt;</b> tag adapter</param>
        void Visit(TagBr adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;button&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;button&gt;</b> tag adapter</param>
        void Visit(TagButton adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;canvas&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;canvas&gt;</b> tag adapter</param>
        void Visit(TagCanvas adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;caption&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;caption&gt;</b> tag adapter</param>
        void Visit(TagCaption adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;center&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;center&gt;</b> tag adapter</param>
        void Visit(TagCenter adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;cite&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;cite&gt;</b> tag adapter</param>
        void Visit(TagCite adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;code&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;code&gt;</b> tag adapter</param>
        void Visit(TagCode adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;col&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;col&gt;</b> tag adapter</param>
        void Visit(TagCol adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;colgroup&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;colgroup&gt;</b> tag adapter</param>
        void Visit(TagColgroup adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;command&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;command;&gt;</b> tag adapter</param>
        void Visit(TagCommand adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;datalist&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;datalist&gt;</b> tag adapter</param>
        void Visit(TagDatalist adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;dd&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;dd&gt;</b> tag adapter</param>
        void Visit(TagDd adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;del&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;del&gt;</b> tag adapter</param>
        void Visit(TagDel adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;details&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;details&gt;</b> tag adapter</param>
        void Visit(TagDetails adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;dfn&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;dfn&gt;</b> tag adapter</param>
        void Visit(TagDfn adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;dialog&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;dialong&gt;</b> tag adapter</param>
        void Visit(TagDialog adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;div&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;div&gt;</b> tag adapter</param>
        void Visit(TagDiv adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;dl&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;dl&gt;</b> tag adapter</param>
        void Visit(TagDl adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;dt&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;dt&gt;</b> tag adapter</param>
        void Visit(TagDt adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;em</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;em&gt;</b> tag adapter</param>
        void Visit(TagEm adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;embed&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;embed&gt;</b> tag adapter</param>
        void Visit(TagEmbed adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;fieldset&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;fieldset&gt;</b> tag adapter</param>
        void Visit(TagFieldset adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;figcaption&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;figcaption&gt;</b> tag adapter</param>
        void Visit(TagFigcaption adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;figure&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;figure&gt;</b> tag adapter</param>
        void Visit(TagFigure adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;font&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;font&gt;</b> tag adapter</param>
        void Visit(TagFont adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;footer&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;footer&gt;</b> tag adapter</param>
        void Visit(TagFooter adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;form&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;form&gt;</b> tag adapter</param>
        void Visit(TagForm adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;h1&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;h1&gt;</b> tag adapter</param>
        void Visit(TagH1 adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;h2&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;h2&gt;</b> tag adapter</param>
        void Visit(TagH2 adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;h3&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;h3&gt;</b> tag adapter</param>
        void Visit(TagH3 adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;h4&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;h4&gt;</b> tag adapter</param>
        void Visit(TagH4 adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;h5&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;h5&gt;</b> tag adapter</param>
        void Visit(TagH5 adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;h6&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;h6&gt;</b> tag adapter</param>
        void Visit(TagH6 adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;head&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>head&gt;</b> tag adapter</param>
        void Visit(TagHead adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;header&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;header&gt;</b> tag adapter</param>
        void Visit(TagHeader adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;hgroup&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;hgroup&gt;</b> tag adapter</param>
        void Visit(TagHgroup adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;hr&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;hr&gt;</b> tag adapter</param>
        void Visit(TagHr adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;html&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;html&gt;</b> tag adapter</param>
        void Visit(TagHtml adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;i&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;i&gt;</b> tag adapter</param>
        void Visit(TagI adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;iframe&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;iframe&gt;</b> tag adapter</param>
        void Visit(TagIframe adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;img&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;img&gt;</b> tag adapter</param>
        void Visit(TagImg adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;input&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;input&gt;</b> tag adapter</param>
        void Visit(TagInput adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;ins&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;ins&gt;</b> tag adapter</param>
        void Visit(TagIns adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;kbd&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;kbd&gt;</b> tag adapter</param>
        void Visit(TagKbd adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;keygen&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;keygen&gt;</b> tag adapter</param>
        void Visit(TagKeygen adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;label&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;label&gt;</b> tag adapter</param>
        void Visit(TagLabel adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;legend&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;legend&gt;</b> tag adapter</param>
        void Visit(TagLegend adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;li&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;li&gt;</b> tag adapter</param>
        void Visit(TagLi adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;link&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;link&gt;</b> tag adapter</param>
        void Visit(TagLink adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;main&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;main&gt;</b> tag adapter</param>
        void Visit(TagMain adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;map&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;map&gt;</b> tag adapter</param>
        void Visit(TagMap adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;mark&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;mark&gt;</b> tag adapter</param>
        void Visit(TagMark adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;menu&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;menu&gt;</b> tag adapter</param>
        void Visit(TagMenu adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;menuitem&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;menuitem&gt;</b> tag adapter</param>
        void Visit(TagMenuitem adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;meta&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;meta&gt;</b> tag adapter</param>
        void Visit(TagMeta adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;meter&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;meter&gt;</b> tag adapter</param>
        void Visit(TagMeter adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;nav&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;nav&gt;</b> tag adapter</param>
        void Visit(TagNav adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;noscript&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;noscript&gt;</b> tag adapter</param>
        void Visit(TagNoscript adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;object&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;object&gt;</b> tag adapter</param>
        void Visit(TagObject adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;ol&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;ol&gt;</b> tag adapter</param>
        void Visit(TagOl adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;optgroup&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;optgroup&gt;</b> tag adapter</param>
        void Visit(TagOptgroup adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;option&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;option&gt;</b> tag adapter</param>
        void Visit(TagOption adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;output&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;output&gt;</b> tag adapter</param>
        void Visit(TagOutput adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;p&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;p&gt;</b> tag adapter</param>
        void Visit(TagP adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;param&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;param&gt;</b> tag adapter</param>
        void Visit(TagParam adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;picture&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;picture&gt;</b> tag adapter</param>
        void Visit(TagPicture adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;pre&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;pre&gt;</b> tag adapter</param>
        void Visit(TagPre adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;progress&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;progress&gt;</b> tag adapter</param>
        void Visit(TagProgress adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;q&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;q&gt;</b> tag adapter</param>
        void Visit(TagQ adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;rp&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;rp&gt;</b> tag adapter</param>
        void Visit(TagRp adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;rt&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;rt&gt;</b> tag adapter</param>
        void Visit(TagRt adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;ruby&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;ruby&gt;</b> tag adapter</param>
        void Visit(TagRuby adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;s&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;s&gt;</b> tag adapter</param>
        void Visit(TagS adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;samp&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;samp&gt;</b> tag adapter</param>
        void Visit(TagSamp adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;script&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;script&gt;</b> tag adapter</param>
        void Visit(TagScript adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;section&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;section&gt;</b> tag adapter</param>
        void Visit(TagSection adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;select&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;select&gt;</b> tag adapter</param>
        void Visit(TagSelect adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;small&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;small&gt;</b> tag adapter</param>
        void Visit(TagSmall adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;source&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;source&gt;</b> tag adapter</param>
        void Visit(TagSource adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;span&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;span&gt;</b> tag adapter</param>
        void Visit(TagSpan adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;strike&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;strike&gt;</b> tag adapter</param>
        void Visit(TagStrike adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;strong&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;strong&gt;</b> tag adapter</param>
        void Visit(TagStrong adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;style&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;style&gt;</b> tag adapter</param>
        void Visit(TagStyle adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;sub&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;sub&gt;</b> tag adapter</param>
        void Visit(TagSub adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;summary&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;summary&gt;</b> tag adapter</param>
        void Visit(TagSummary adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;sup&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;sup&gt;</b> tag adapter</param>
        void Visit(TagSup adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;table&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;table&gt;</b> tag adapter</param>
        void Visit(TagTable adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;tbody&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;tbody&gt;</b> tag adapter</param>
        void Visit(TagTbody adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;td&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;td&gt;</b> tag adapter</param>
        void Visit(TagTd adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;textarea&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;textarea&gt;</b> tag adapter</param>
        void Visit(TagTextarea adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;tfoot&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;tfoot&gt;</b> tag adapter</param>
        void Visit(TagTfoot adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;th&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;th&gt;</b> tag adapter</param>
        void Visit(TagTh adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;thead&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;thead&gt;</b> tag adapter</param>
        void Visit(TagThead adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;time&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;time&gt;</b> tag adapter</param>
        void Visit(TagTime adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;title&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;title&gt;</b> tag adapter</param>
        void Visit(TagTitle adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;tr&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;tr&gt;</b> tag adapter</param>
        void Visit(TagTr adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;track&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;track&gt;</b> tag adapter</param>
        void Visit(TagTrack adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;tt&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;tt&gt;</b> tag adapter</param>
        void Visit(TagTt adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;u&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;u&gt;</b> tag adapter</param>
        void Visit(TagU adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;ul&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;ul&gt;</b> tag adapter</param>
        void Visit(TagUl adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;var&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;var&gt;</b> tag adapter</param>
        void Visit(TagVar adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;video&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;video&gt;</b> tag adapter</param>
        void Visit(TagVideo adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>&lt;wbr&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;wbr&gt;</b> tag adapter</param>
        void Visit(TagWbr adapter);
    }
}