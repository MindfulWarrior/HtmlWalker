using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;

namespace HtmlWalker
{
    public interface IWalker
    {
        #region abstract Handle methods for tags with no inner tags

        #region abstract Handle methods for utility adapters

        /// <summary>
        ///   This abstract method is called when HTML text is found
        /// </summary>
        /// <param name="adapter">the text adapter</param>
        void Handle(Text adapter);

        /// <summary>
        ///   This abstract method is called when EOL characters are found
        /// </summary>
        /// <param name="adapter">the EOL adapter</param>
        void Handle(Eol adapter);

        /// <summary>
        ///   This abstract method is called when and entity is found
        /// </summary>
        /// <param name="adapter">the entitiy adapter</param>
        void Handle(Entity adapter);

        /// <summary>
        ///   This abstract method is called when a comment is found
        /// </summary>
        void Handle(Comment adapter);

        /// <summary>
        ///   This abstract method is called when a skipped tag is found
        /// </summary>
        void Handle(Skip adapter);

        /// <summary>
        ///   This abstract method is called when an unrecognized HTML tag is found
        /// </summary>
        /// <param name="adapter">the unknown tag</param>
        void Handle(Unknown adapter);

        #endregion

        #region abstract Handle methods for HTML tag adapters

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;area&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;area&gt;</b> tag adapter</param>
        void Handle(TagArea adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;base&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;base&gt;</b> tag adapter</param>
        void Handle(TagBase adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;br&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;br&gt;</b> tag adapter</param>
        void Handle(TagBr adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;embed&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;embed&gt;</b> tag adapter</param>
        void Handle(TagEmbed adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;hr&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;hr&gt;</b> tag adapter</param>
        void Handle(TagHr adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;img&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;img&gt;</b> tag adapter</param>
        void Handle(TagImg adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;input&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;input&gt;</b> tag adapter</param>
        void Handle(TagInput adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;link&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;link&gt;</b> tag adapter</param>
        void Handle(TagLink adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;meta&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;meta&gt;</b> tag adapter</param>
        void Handle(TagMeta adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;option&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;option&gt;</b> tag adapter</param>
        void Handle(TagOption adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;param&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;param&gt;</b> tag adapter</param>
        void Handle(TagParam adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;progress&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;progress&gt;</b> tag adapter</param>
	    void Handle(TagProgress adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;scritp&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;script&gt;</b> tag adapter</param>
        void Handle(TagScript adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;source&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;source&gt;</b> tag adapter</param>
        void Handle(TagSource adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;style&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;style&gt;</b> tag adapter</param>
        void Handle(TagStyle adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;textarea&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;textarea&gt;</b> tag adapter</param>
        void Handle(TagTextarea adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;title&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;title&gt;</b> tag adapter</param>
        void Handle(TagTitle adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;track&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;track&gt;</b> tag adapter</param>
	    void Handle(TagTrack adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;br&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;br&gt;</b> tag adapter</param>
	    void Handle(TagWbr adapter);

        #endregion

        #endregion

        #region abstract Start/End methods

        #region document, <html>, <head>, and <body> tags

        /// <summary>
        ///  This method is called before walking begins at the root document element
        /// </summary>
        /// <param name="adapter">the document root</param>
        void Start(DocumentTag adapter);

        /// <summary>
        ///   Thsi abstract method is called at the end of visiting
        /// </summary>
        /// <param name="adapter">the document root</param>
        void End(DocumentTag adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;head&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;head&gt;</b> adapter</param>
        void Start(TagHead adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;head&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;head&gt;</b> adapter</param>
        void End(TagHead adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;body&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;body&gt;</b> adapter</param>
        void Start(TagBody adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;body&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;body&gt;</b> adapter</param>
        void End(TagBody adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;html&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;html&gt;</b> adapter</param>
        void Start(TagHtml adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;html&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;html&gt;</b> adapter</param>
        void End(TagHtml adapter);

        #endregion

        #region metadata tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;command&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;command&gt;</b> adapter</param>
	    void Start(TagCommand adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;command&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;command&gt;</b> adapter</param>
	    void End(TagCommand adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;noscript&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;noscript&gt;</b> adapter</param>
        void Start(TagNoscript adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;noscript&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;noscript&gt;</b> adapter</param>
        void End(TagNoscript adapter);

        #endregion

        #region table tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;caption&gt;</b> adapter</param>
        void Start(TagCaption adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;caption&gt;</b> adapter</param>
        void End(TagCaption adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;col&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;col&gt;</b> adapter</param>
        void Start(TagCol adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;col&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;col&gt;</b> adapter</param>
        void End(TagCol adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;colgroup&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;colgroup&gt;</b> adapter</param>
        void Start(TagColgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;colgroup&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;colgroup&gt;</b> adapter</param>
        void End(TagColgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;table&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;table&gt;</b> adapter</param>
        void Start(TagTable adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;table&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;table&gt;</b> adapter</param>
        void End(TagTable adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tbody&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tbody&gt;</b> adapter</param>
        void Start(TagTbody adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tbody&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tbody&gt;</b> adapter</param>
        void End(TagTbody adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;td&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;td&gt;</b> adapter</param>
        void Start(TagTd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;td&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;td&gt;</b> adapter</param>
        void End(TagTd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tfoot&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tfoot&gt;</b> adapter</param>
        void Start(TagTfoot adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tfoot&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tfoot&gt;</b> adapter</param>
        void End(TagTfoot adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;th&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;th&gt;</b> adapter</param>
        void Start(TagTh adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;th&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;th&gt;</b> adapter</param>
        void End(TagTh adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;thead&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;thead&gt;</b> adapter</param>
        void Start(TagThead adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;thead&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;thead&gt;</b> adapter</param>
        void End(TagThead adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tr&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tr&gt;</b> adapter</param>
        void Start(TagTr adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tr&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tr&gt;</b> adapter</param>
        void End(TagTr adapter);

        #endregion

        #region list tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dd&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dd&gt;</b> adapter</param>
        void Start(TagDd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dd&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dd&gt;</b> adapter</param>
        void End(TagDd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dl&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dl&gt;</b> adapter</param>
        void Start(TagDl adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dl&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dl&gt;</b> adapter</param>
        void End(TagDl adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dt&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dt&gt;</b> adapter</param>
        void Start(TagDt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dt&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dt&gt;</b> adapter</param>
        void End(TagDt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;li&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;li&gt;</b> adapter</param>
        void Start(TagLi adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;li&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;li&gt;</b> adapter</param>
        void End(TagLi adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ol&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ol&gt;</b> adapter</param>
        void Start(TagOl adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ol&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ol&gt;</b> adapter</param>
        void End(TagOl adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ul&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ul&gt;</b> adapter</param>
        void Start(TagUl adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ul&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ul&gt;</b> adapter</param>
        void End(TagUl adapter);

        #endregion

        #region other block level tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;article&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;article&gt;</b> adapter</param>
        void Start(TagArticle adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;article&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;article&gt;</b> adapter</param>
	    void End(TagArticle adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;aside&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;aside&gt;</b> adapter</param>
	    void Start(TagAside adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;aside&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;aside&gt;</b> adapter</param>
	    void End(TagAside adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;address&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;address&gt;</b> adapter</param>
        void Start(TagAddress adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;address&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;address&gt;</b> adapter</param>
        void End(TagAddress adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;blockquote&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;blokquote&gt;</b> adapter</param>
        void Start(TagBlockquote adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;blockquote&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;blockquote&gt;</b> adapter</param>
        void End(TagBlockquote adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;button&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;button&gt;</b> adapter</param>
        void Start(TagButton adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;button&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;button&gt;</b> adapter</param>
        void End(TagButton adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;canvas&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;canvas&gt;</b> adapter</param>
	    void Start(TagCanvas adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;canvas&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;canvas&gt;</b> adapter</param>
	    void End(TagCanvas adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;center&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;center&gt;</b> adapter</param>
        void Start(TagCenter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;center&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;center&gt;</b> adapter</param>
        void End(TagCenter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;div&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;div&gt;</b> adapter</param>
        void Start(TagDiv adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;div&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;div&gt;</b> adapter</param>
        void End(TagDiv adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;fieldset&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;fieldset&gt;</b> adapter</param>
        void Start(TagFieldset adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;fieldset&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;fieldset&gt;</b> adapter</param>
        void End(TagFieldset adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;caption&gt;</b> adapter</param>
        void Start(TagFigcaption adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;figcaption&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;figcaption&gt;</b> adapter</param>
	    void End(TagFigcaption adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;figure&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;figure&gt;</b> adapter</param>
	    void Start(TagFigure adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;figure&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;figure&gt;</b> adapter</param>
	    void End(TagFigure adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;footer&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;footer&gt;</b> adapter</param>
	    void Start(TagFooter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;footer&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;footer&gt;</b> adapter</param>
	    void End(TagFooter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;form&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;form&gt;</b> adapter</param>
        void Start(TagForm adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;form&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;form&gt;</b> adapter</param>
        void End(TagForm adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h1&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h1&gt;</b> adapter</param>
        void Start(TagH1 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h1&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h2&gt;</b> adapter</param>
        void End(TagH1 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h2&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h2&gt;</b> adapter</param>
        void Start(TagH2 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h2&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h2&gt;</b> adapter</param>
        void End(TagH2 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h3&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h3&gt;</b> adapter</param>
        void Start(TagH3 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h3&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h3&gt;</b> adapter</param>
        void End(TagH3 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h4&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h4&gt;</b> adapter</param>
        void Start(TagH4 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h4&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h4&gt;</b> adapter</param>
        void End(TagH4 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h5&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h5&gt;</b> adapter</param>
        void Start(TagH5 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h5&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h5&gt;</b> adapter</param>
        void End(TagH5 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h6&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h6&gt;</b> adapter</param>
        void Start(TagH6 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h6&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h6&gt;</b> adapter</param>
        void End(TagH6 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;header&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;header&gt;</b> adapter</param>
        void Start(TagHeader adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;header&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;header&gt;</b> adapter</param>
	    void End(TagHeader adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;hgroup&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;hgroup&gt;</b> adapter</param>
	    void Start(TagHgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;hgroup&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;hgroup&gt;</b> adapter</param>
	    void End(TagHgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;main&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;main&gt;</b> adapter</param>
        void Start(TagMain adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;main&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;main&gt;</b> adapter</param>
	    void End(TagMain adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;nav&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;nav&gt;</b> adapter</param>
	    void Start(TagNav adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;nav&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;nav&gt;</b> adapter</param>
	    void End(TagNav adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;outpu&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;output&gt;</b> adapter</param>
        void Start(TagOutput adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;outpu&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;output&gt;</b> adapter</param>
	    void End(TagOutput adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;p&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;p&gt;</b> adapter</param>
        void Start(TagP adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;p&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;p&gt;</b> adapter</param>
        void End(TagP adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;pre&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;pre&gt;</b> adapter</param>
        void Start(TagPre adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;pre&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;pre&gt;</b> adapter</param>
        void End(TagPre adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;section&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;section&gt;</b> adapter</param>
	    void Start(TagSection adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;section&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;section&gt;</b> adapter</param>
	    void End(TagSection adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;video&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;video&gt;</b> adapter</param>
        void Start(TagVideo adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;video&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;video&gt;</b> adapter</param>
        void End(TagVideo adapter);

        #endregion

        #region other inline level tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;a&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;a&gt;</b> adapter</param>
        void Start(TagA adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;a&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;a&gt;</b> adapter</param>
        void End(TagA adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;abbr&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;abbr&gt;</b> adapter</param>
        void Start(TagAbbr adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;abbr&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;abbr&gt;</b> adapter</param>
        void End(TagAbbr adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;acronym&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;acronym&gt;</b> adapter</param>
        void Start(TagAcronym adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;acronym&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;acronym&gt;</b> adapter</param>
        void End(TagAcronym adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;audio&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;audio&gt;</b> adapter</param>
        void Start(TagAudio adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;audio&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;audio&gt;</b> adapter</param>
	    void End(TagAudio adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;b&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;b&gt;</b> adapter</param>
        void Start(TagB adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;b&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;b&gt;</b> adapter</param>
        void End(TagB adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;bdi&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;bdi&gt;</b> adapter</param>
	    void Start(TagBdi adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;bdi&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;bdi&gt;</b> adapter</param>
	    void End(TagBdi adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;bdo&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;bdo&gt;</b> adapter</param>
        void Start(TagBdo adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;bdo&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;bdo&gt;</b> adapter</param>
        void End(TagBdo adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;big&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;big&gt;</b> adapter</param>
        void Start(TagBig adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;big&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;big&gt;</b> adapter</param>
        void End(TagBig adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;cite&gt;</b> tag adapter befoe
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;cite&gt;</b> adapter</param>
        void Start(TagCite adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;cite&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;cite&gt;</b> adapter</param>
        void End(TagCite adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;code&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;code&gt;</b> adapter</param>
        void Start(TagCode adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;code&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;code&gt;</b> adapter</param>
        void End(TagCode adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;datalist&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;datalist&gt;</b> adapter</param>
	    void Start(TagDatalist adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;datalist&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;datalist&gt;</b> adapter</param>
	    void End(TagDatalist adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;del&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;del&gt;</b> adapter</param>
        void Start(TagDel adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;del&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;del&gt;</b> adapter</param>
        void End(TagDel adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;details&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;details&gt;</b> adapter</param>
	    void Start(TagDetails adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;details&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;details&gt;</b> adapter</param>
	    void End(TagDetails adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dfn&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dfn&gt;</b> adapter</param>
        void Start(TagDfn adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dfn&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dfn&gt;</b> adapter</param>
        void End(TagDfn adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;em&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;em&gt;</b> adapter</param>
        void Start(TagEm adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;em&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;em&gt;</b> adapter</param>
        void End(TagEm adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;font&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;font&gt;</b> adapter</param>
        void Start(TagFont adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;font&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;font&gt;</b> adapter</param>
        void End(TagFont adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;i&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;i&gt;</b> adapter</param>
        void Start(TagI adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;i&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;i&gt;</b> adapter</param>
        void End(TagI adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;iframe&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;iframe&gt;</b> adapter</param>
        void Start(TagIframe adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;iframe&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;iframe&gt;</b> adapter</param>
        void End(TagIframe adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ins&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ins&gt;</b> adapter</param>
        void Start(TagIns adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ins&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ins&gt;</b> adapter</param>
        void End(TagIns adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;kdb&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;kdb&gt;</b> adapter</param>
        void Start(TagKbd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;kdb&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;kdb&gt;</b> adapter</param>
        void End(TagKbd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;label&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;label&gt;</b> adapter</param>
        void Start(TagLabel adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;label&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;label&gt;</b> adapter</param>
        void End(TagLabel adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;legend&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;legend&gt;</b> adapter</param>
        void Start(TagLegend adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;legend&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;legend&gt;</b> adapter</param>
        void End(TagLegend adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;mark&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;mark&gt;</b> adapter</param>
        void Start(TagMark adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;mark&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;mark&gt;</b> adapter</param>
	    void End(TagMark adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;map&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;map&gt;</b> adapter</param>
        void Start(TagMap adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;map&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;map&gt;</b> adapter</param>
        void End(TagMap adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;meter&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;meter&gt;</b> adapter</param>
        void Start(TagMeter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;meter&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;meter&gt;</b> adapter</param>
	    void End(TagMeter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;object&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;object&gt;</b> adapter</param>
        void Start(TagObject adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;object&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;object&gt;</b> adapter</param>
        void End(TagObject adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;optgroup&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;optgroup&gt;</b> adapter</param>
        void Start(TagOptgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;optgroup&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;optgroup&gt;</b> adapter</param>
        void End(TagOptgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;q&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;q&gt;</b> adapter</param>
        void Start(TagQ adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;q&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;q&gt;</b> adapter</param>
        void End(TagQ adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;s&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;s&gt;</b> adapter</param>
        void Start(TagS adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;s&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;s&gt;</b> adapter</param>
        void End(TagS adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;samp&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;samp&gt;</b> adapter</param>
        void Start(TagSamp adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;samp&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;samp&gt;</b> adapter</param>
        void End(TagSamp adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;select&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;select&gt;</b> adapter</param>
        void Start(TagSelect adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;select&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;select&gt;</b> adapter</param>
        void End(TagSelect adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;small&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;small&gt;</b> adapter</param>
        void Start(TagSmall adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;small&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;small&gt;</b> adapter</param>
        void End(TagSmall adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;span&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;span&gt;</b> adapter</param>
        void Start(TagSpan adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;span&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;span&gt;</b> adapter</param>
        void End(TagSpan adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;strike&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;strike&gt;</b> adapter</param>
        void Start(TagStrike adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;strike&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;strike&gt;</b> adapter</param>
        void End(TagStrike adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;strong&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;strong&gt;</b> adapter</param>
        void Start(TagStrong adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;strong&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;strong&gt;</b> adapter</param>
        void End(TagStrong adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;sub&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;sub&gt;</b> adapter</param>
        void Start(TagSub adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;sup&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;sup&gt;</b> adapter</param>
        void End(TagSup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;summary&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;summary&gt;</b> adapter</param>
        void Start(TagSummary adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;summary&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;summary&gt;</b> adapter</param>
	    void End(TagSummary adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;sub&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;sub&gt;</b> adapter</param>
        void End(TagSub adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;sup&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;sup&gt;</b> adapter</param>
        void Start(TagSup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;time&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;time&gt;</b> adapter</param>
	    void Start(TagTime adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;time&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;time&gt;</b> adapter</param>
	    void End(TagTime adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tt&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tt&gt;</b> adapter</param>
        void Start(TagTt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tt&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tt&gt;</b> adapter</param>
        void End(TagTt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;u&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;&gt;</b> adapter</param>
        void Start(TagU adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;u&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;&gt;</b> adapter</param>
        void End(TagU adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;var&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;var&gt;</b> adapter</param>
        void Start(TagVar adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;var&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;var&gt;</b> adapter</param>
        void End(TagVar adapter);

        #endregion

        #region other tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dialog&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dialog&gt;</b> adapter</param>
	    void Start(TagDialog adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dialog&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dialog&gt;</b> adapter</param>
	    void End(TagDialog adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;keygen&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;keygen&gt;</b> adapter</param>
	    void Start(TagKeygen adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;keygen&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;keygen&gt;</b> adapter</param>
	    void End(TagKeygen adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;menu&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
        void Start(TagMenu adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;menu&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
        void End(TagMenu adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;menuitem&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
        void Start(TagMenuitem adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;menuitem&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
        void End(TagMenuitem adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;picture&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;picture&gt;</b> adapter</param>
        void Start(TagPicture adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;picture&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;picture&gt;</b> adapter</param>
        void End(TagPicture adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;rp&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;rp&gt;</b> adapter</param>
	    void Start(TagRp adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;rp&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;rp&gt;</b> adapter</param>
	    void End(TagRp adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;rt&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;rt&gt;</b> adapter</param>
	    void Start(TagRt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;rt&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;rt&gt;</b> adapter</param>
	    void End(TagRt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ruby&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ruby&gt;</b> adapter</param>
	    void Start(TagRuby adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ruby&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ruby&gt;</b> adapter</param>
	    void End(TagRuby adapter);

        #endregion

        #endregion
    }
}