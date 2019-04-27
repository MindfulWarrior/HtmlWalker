using HtmlWalker.Platform;
using HtmlWalker.Tag.Base;
using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;
using HtmlWalker.Visitor;

namespace HtmlWalker
{
    /// <summary>
    ///   This abstract class uses the visitor pattern to do a depth-first walk
    ///   of a well-formed HTML document.
    ///
    ///   How the HTML document is implemented is managed through the
    ///   <see cref="WalkerPlatform"/> and <see cref="WalkerPlatform.WalkerDocument"/> abstract classes,
    ///   as well as the interface <see cref="WalkerPlatform.ITagApi"/>.
    ///
    ///   Each HTML tag is visited through a tag adapter. If the tag has children tags,
    ///   then an abstract <b><i>start</i></b> and <b><i>end</i></b> method is called
    ///   before and after walking the child tags. Otherwise an abstract <b><i>handle</i></b>
    ///   is called. 
    ///
    ///   Implements <see cref="ITagVoidVisitor"/>
    /// </summary>
    /// <author>Robert R Flores</author>
    public abstract class Walker : ITagVoidVisitor, IWalker
    {
        /// <summary>
        ///   Instantiates a new walker for the given platform implementation
        /// </summary>
        public Walker() { }

        #region abstract Handle methods for tags with no inner tags

        #region abstract Handle methods for utility adapters

        /// <summary>
        ///   This abstract method is called when HTML text is found
        /// </summary>
        /// <param name="adapter">the text adapter</param>
        public abstract void Handle(Text adapter);

        /// <summary>
        ///   This abstract method is called when EOL characters are found
        /// </summary>
        /// <param name="adapter">the EOL adapter</param>
        public abstract void Handle(Eol adapter);

        /// <summary>
        ///   This abstract method is called when and entity is found
        /// </summary>
        /// <param name="adapter">the entitiy adapter</param>
        public abstract void Handle(Entity adapter);

        /// <summary>
        ///   This abstract method is called when a comment is found
        /// </summary>
        public abstract void Handle(Comment adapter);

        /// <summary>
        ///   This abstract method is called when a skipped tag is found
        /// </summary>
        public abstract void Handle(Skip adapter);

        /// <summary>
        ///   This abstract method is called when an unrecognized HTML tag is found
        /// </summary>
        /// <param name="adapter">the unknown tag</param>
        public abstract void Handle(Unknown adapter);

        #endregion

        #region abstract Handle methods for HTML tag adapters

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;area&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;area&gt;</b> tag adapter</param>
        public abstract void Handle(TagArea adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;base&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;base&gt;</b> tag adapter</param>
        public abstract void Handle(TagBase adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;br&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;br&gt;</b> tag adapter</param>
        public abstract void Handle(TagBr adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;embed&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;embed&gt;</b> tag adapter</param>
        public abstract void Handle(TagEmbed adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;hr&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;hr&gt;</b> tag adapter</param>
        public abstract void Handle(TagHr adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;img&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;img&gt;</b> tag adapter</param>
        public abstract void Handle(TagImg adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;input&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;input&gt;</b> tag adapter</param>
        public abstract void Handle(TagInput adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;link&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;link&gt;</b> tag adapter</param>
        public abstract void Handle(TagLink adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;meta&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;meta&gt;</b> tag adapter</param>
        public abstract void Handle(TagMeta adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;option&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;option&gt;</b> tag adapter</param>
        public abstract void Handle(TagOption adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;param&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;param&gt;</b> tag adapter</param>
        public abstract void Handle(TagParam adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;progress&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;progress&gt;</b> tag adapter</param>
	    public abstract void Handle(TagProgress adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;scritp&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;script&gt;</b> tag adapter</param>
        public abstract void Handle(TagScript adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;source&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;source&gt;</b> tag adapter</param>
        public abstract void Handle(TagSource adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;style&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;style&gt;</b> tag adapter</param>
        public abstract void Handle(TagStyle adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;textarea&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;textarea&gt;</b> tag adapter</param>
        public abstract void Handle(TagTextarea adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;title&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;title&gt;</b> tag adapter</param>
        public abstract void Handle(TagTitle adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;track&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;track&gt;</b> tag adapter</param>
	    public abstract void Handle(TagTrack adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;br&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;br&gt;</b> tag adapter</param>
	    public abstract void Handle(TagWbr adapter);

        #endregion

        #endregion

        #region abstract Start/End methods

        #region document, <html>, <head>, and <body> tags

        /// <summary>
        ///  This method is called before walking begins at the root document element
        /// </summary>
        /// <param name="adapter">the document root</param>
        public abstract void Start(DocumentTag adapter);

        /// <summary>
        ///   Thsi abstract method is called at the end of visiting
        /// </summary>
        /// <param name="adapter">the document root</param>
        public abstract void End(DocumentTag adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;head&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;head&gt;</b> adapter</param>
        public abstract void Start(TagHead adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;head&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;head&gt;</b> adapter</param>
        public abstract void End(TagHead adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;body&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;body&gt;</b> adapter</param>
        public abstract void Start(TagBody adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;body&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;body&gt;</b> adapter</param>
        public abstract void End(TagBody adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;html&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;html&gt;</b> adapter</param>
        public abstract void Start(TagHtml adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;html&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;html&gt;</b> adapter</param>
        public abstract void End(TagHtml adapter);

        #endregion

        #region metadata tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;command&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;command&gt;</b> adapter</param>
	    public abstract void Start(TagCommand adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;command&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;command&gt;</b> adapter</param>
	    public abstract void End(TagCommand adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;noscript&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;noscript&gt;</b> adapter</param>
        public abstract void Start(TagNoscript adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;noscript&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;noscript&gt;</b> adapter</param>
        public abstract void End(TagNoscript adapter);

        #endregion

        #region table tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;caption&gt;</b> adapter</param>
        public abstract void Start(TagCaption adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;caption&gt;</b> adapter</param>
        public abstract void End(TagCaption adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;col&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;col&gt;</b> adapter</param>
        public abstract void Start(TagCol adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;col&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;col&gt;</b> adapter</param>
        public abstract void End(TagCol adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;colgroup&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;colgroup&gt;</b> adapter</param>
        public abstract void Start(TagColgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;colgroup&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;colgroup&gt;</b> adapter</param>
        public abstract void End(TagColgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;table&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;table&gt;</b> adapter</param>
        public abstract void Start(TagTable adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;table&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;table&gt;</b> adapter</param>
        public abstract void End(TagTable adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tbody&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tbody&gt;</b> adapter</param>
        public abstract void Start(TagTbody adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tbody&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tbody&gt;</b> adapter</param>
        public abstract void End(TagTbody adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;td&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;td&gt;</b> adapter</param>
        public abstract void Start(TagTd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;td&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;td&gt;</b> adapter</param>
        public abstract void End(TagTd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tfoot&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tfoot&gt;</b> adapter</param>
        public abstract void Start(TagTfoot adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tfoot&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tfoot&gt;</b> adapter</param>
        public abstract void End(TagTfoot adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;th&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;th&gt;</b> adapter</param>
        public abstract void Start(TagTh adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;th&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;th&gt;</b> adapter</param>
        public abstract void End(TagTh adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;thead&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;thead&gt;</b> adapter</param>
        public abstract void Start(TagThead adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;thead&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;thead&gt;</b> adapter</param>
        public abstract void End(TagThead adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tr&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tr&gt;</b> adapter</param>
        public abstract void Start(TagTr adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tr&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tr&gt;</b> adapter</param>
        public abstract void End(TagTr adapter);

        #endregion

        #region list tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dd&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dd&gt;</b> adapter</param>
        public abstract void Start(TagDd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dd&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dd&gt;</b> adapter</param>
        public abstract void End(TagDd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dl&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dl&gt;</b> adapter</param>
        public abstract void Start(TagDl adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dl&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dl&gt;</b> adapter</param>
        public abstract void End(TagDl adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dt&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dt&gt;</b> adapter</param>
        public abstract void Start(TagDt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dt&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dt&gt;</b> adapter</param>
        public abstract void End(TagDt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;li&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;li&gt;</b> adapter</param>
        public abstract void Start(TagLi adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;li&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;li&gt;</b> adapter</param>
        public abstract void End(TagLi adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ol&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ol&gt;</b> adapter</param>
        public abstract void Start(TagOl adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ol&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ol&gt;</b> adapter</param>
        public abstract void End(TagOl adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ul&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ul&gt;</b> adapter</param>
        public abstract void Start(TagUl adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ul&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ul&gt;</b> adapter</param>
        public abstract void End(TagUl adapter);

        #endregion

        #region other block level tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;article&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;article&gt;</b> adapter</param>
        public abstract void Start(TagArticle adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;article&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;article&gt;</b> adapter</param>
	    public abstract void End(TagArticle adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;aside&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;aside&gt;</b> adapter</param>
	    public abstract void Start(TagAside adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;aside&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;aside&gt;</b> adapter</param>
	    public abstract void End(TagAside adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;address&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;address&gt;</b> adapter</param>
        public abstract void Start(TagAddress adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;address&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;address&gt;</b> adapter</param>
        public abstract void End(TagAddress adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;blockquote&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;blokquote&gt;</b> adapter</param>
        public abstract void Start(TagBlockquote adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;blockquote&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;blockquote&gt;</b> adapter</param>
        public abstract void End(TagBlockquote adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;canvas&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;canvas&gt;</b> adapter</param>
	    public abstract void Start(TagCanvas adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;canvas&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;canvas&gt;</b> adapter</param>
	    public abstract void End(TagCanvas adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;center&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;center&gt;</b> adapter</param>
        public abstract void Start(TagCenter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;center&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;center&gt;</b> adapter</param>
        public abstract void End(TagCenter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;div&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;div&gt;</b> adapter</param>
        public abstract void Start(TagDiv adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;div&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;div&gt;</b> adapter</param>
        public abstract void End(TagDiv adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;fieldset&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;fieldset&gt;</b> adapter</param>
        public abstract void Start(TagFieldset adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;fieldset&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;fieldset&gt;</b> adapter</param>
        public abstract void End(TagFieldset adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;caption&gt;</b> adapter</param>
        public abstract void Start(TagFigcaption adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;figcaption&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;figcaption&gt;</b> adapter</param>
	    public abstract void End(TagFigcaption adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;figure&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;figure&gt;</b> adapter</param>
	    public abstract void Start(TagFigure adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;figure&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;figure&gt;</b> adapter</param>
	    public abstract void End(TagFigure adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;footer&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;footer&gt;</b> adapter</param>
	    public abstract void Start(TagFooter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;footer&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;footer&gt;</b> adapter</param>
	    public abstract void End(TagFooter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;form&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;form&gt;</b> adapter</param>
        public abstract void Start(TagForm adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;form&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;form&gt;</b> adapter</param>
        public abstract void End(TagForm adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h1&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h1&gt;</b> adapter</param>
        public abstract void Start(TagH1 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h1&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h2&gt;</b> adapter</param>
        public abstract void End(TagH1 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h2&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h2&gt;</b> adapter</param>
        public abstract void Start(TagH2 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h2&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h2&gt;</b> adapter</param>
        public abstract void End(TagH2 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h3&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h3&gt;</b> adapter</param>
        public abstract void Start(TagH3 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h3&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h3&gt;</b> adapter</param>
        public abstract void End(TagH3 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h4&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h4&gt;</b> adapter</param>
        public abstract void Start(TagH4 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h4&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h4&gt;</b> adapter</param>
        public abstract void End(TagH4 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h5&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h5&gt;</b> adapter</param>
        public abstract void Start(TagH5 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h5&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h5&gt;</b> adapter</param>
        public abstract void End(TagH5 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h6&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h6&gt;</b> adapter</param>
        public abstract void Start(TagH6 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;h6&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;h6&gt;</b> adapter</param>
        public abstract void End(TagH6 adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;header&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;header&gt;</b> adapter</param>
        public abstract void Start(TagHeader adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;header&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;header&gt;</b> adapter</param>
	    public abstract void End(TagHeader adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;hgroup&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;hgroup&gt;</b> adapter</param>
	    public abstract void Start(TagHgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;hgroup&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;hgroup&gt;</b> adapter</param>
	    public abstract void End(TagHgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;main&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;main&gt;</b> adapter</param>
        public abstract void Start(TagMain adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;main&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;main&gt;</b> adapter</param>
	    public abstract void End(TagMain adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;nav&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;nav&gt;</b> adapter</param>
	    public abstract void Start(TagNav adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;nav&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;nav&gt;</b> adapter</param>
	    public abstract void End(TagNav adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;outpu&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;output&gt;</b> adapter</param>
        public abstract void Start(TagOutput adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;outpu&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;output&gt;</b> adapter</param>
	    public abstract void End(TagOutput adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;p&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;p&gt;</b> adapter</param>
        public abstract void Start(TagP adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;p&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;p&gt;</b> adapter</param>
        public abstract void End(TagP adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;pre&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;pre&gt;</b> adapter</param>
        public abstract void Start(TagPre adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;pre&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;pre&gt;</b> adapter</param>
        public abstract void End(TagPre adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;section&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;section&gt;</b> adapter</param>
	    public abstract void Start(TagSection adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;section&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;section&gt;</b> adapter</param>
	    public abstract void End(TagSection adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;video&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;video&gt;</b> adapter</param>
        public abstract void Start(TagVideo adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;video&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;video&gt;</b> adapter</param>
        public abstract void End(TagVideo adapter);

        #endregion

        #region other inline level tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;a&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;a&gt;</b> adapter</param>
        public abstract void Start(TagA adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;a&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;a&gt;</b> adapter</param>
        public abstract void End(TagA adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;abbr&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;abbr&gt;</b> adapter</param>
        public abstract void Start(TagAbbr adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;abbr&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;abbr&gt;</b> adapter</param>
        public abstract void End(TagAbbr adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;acronym&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;acronym&gt;</b> adapter</param>
        public abstract void Start(TagAcronym adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;acronym&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;acronym&gt;</b> adapter</param>
        public abstract void End(TagAcronym adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;audio&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;audio&gt;</b> adapter</param>
        public abstract void Start(TagAudio adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;audio&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;audio&gt;</b> adapter</param>
	    public abstract void End(TagAudio adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;b&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;b&gt;</b> adapter</param>
        public abstract void Start(TagB adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;b&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;b&gt;</b> adapter</param>
        public abstract void End(TagB adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;bdi&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;bdi&gt;</b> adapter</param>
	    public abstract void Start(TagBdi adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;bdi&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;bdi&gt;</b> adapter</param>
	    public abstract void End(TagBdi adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;bdo&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;bdo&gt;</b> adapter</param>
        public abstract void Start(TagBdo adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;bdo&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;bdo&gt;</b> adapter</param>
        public abstract void End(TagBdo adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;big&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;big&gt;</b> adapter</param>
        public abstract void Start(TagBig adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;big&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;big&gt;</b> adapter</param>
        public abstract void End(TagBig adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;button&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;button&gt;</b> adapter</param>
        public abstract void Start(TagButton adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;button&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;button&gt;</b> adapter</param>
        public abstract void End(TagButton adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;cite&gt;</b> tag adapter befoe
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;cite&gt;</b> adapter</param>
        public abstract void Start(TagCite adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;cite&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;cite&gt;</b> adapter</param>
        public abstract void End(TagCite adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;code&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;code&gt;</b> adapter</param>
        public abstract void Start(TagCode adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;code&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;code&gt;</b> adapter</param>
        public abstract void End(TagCode adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;datalist&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;datalist&gt;</b> adapter</param>
	    public abstract void Start(TagDatalist adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;datalist&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;datalist&gt;</b> adapter</param>
	    public abstract void End(TagDatalist adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;details&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;details&gt;</b> adapter</param>
	    public abstract void Start(TagDetails adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;details&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;details&gt;</b> adapter</param>
	    public abstract void End(TagDetails adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;del&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;del&gt;</b> adapter</param>
        public abstract void Start(TagDel adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;del&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;del&gt;</b> adapter</param>
        public abstract void End(TagDel adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dfn&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dfn&gt;</b> adapter</param>
        public abstract void Start(TagDfn adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dfn&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dfn&gt;</b> adapter</param>
        public abstract void End(TagDfn adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;em&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;em&gt;</b> adapter</param>
        public abstract void Start(TagEm adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;em&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;em&gt;</b> adapter</param>
        public abstract void End(TagEm adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;font&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;font&gt;</b> adapter</param>
        public abstract void Start(TagFont adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;font&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;font&gt;</b> adapter</param>
        public abstract void End(TagFont adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;i&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;i&gt;</b> adapter</param>
        public abstract void Start(TagI adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;i&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;i&gt;</b> adapter</param>
        public abstract void End(TagI adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;iframe&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;iframe&gt;</b> adapter</param>
        public abstract void Start(TagIframe adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;iframe&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;iframe&gt;</b> adapter</param>
        public abstract void End(TagIframe adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ins&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ins&gt;</b> adapter</param>
        public abstract void Start(TagIns adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ins&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ins&gt;</b> adapter</param>
        public abstract void End(TagIns adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;kdb&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;kdb&gt;</b> adapter</param>
        public abstract void Start(TagKbd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;kdb&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;kdb&gt;</b> adapter</param>
        public abstract void End(TagKbd adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;label&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;label&gt;</b> adapter</param>
        public abstract void Start(TagLabel adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;label&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;label&gt;</b> adapter</param>
        public abstract void End(TagLabel adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;legend&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;legend&gt;</b> adapter</param>
        public abstract void Start(TagLegend adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;legend&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;legend&gt;</b> adapter</param>
        public abstract void End(TagLegend adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;map&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;map&gt;</b> adapter</param>
        public abstract void Start(TagMap adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;map&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;map&gt;</b> adapter</param>
        public abstract void End(TagMap adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;mark&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;mark&gt;</b> adapter</param>
        public abstract void Start(TagMark adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;mark&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;mark&gt;</b> adapter</param>
	    public abstract void End(TagMark adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;meter&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;meter&gt;</b> adapter</param>
        public abstract void Start(TagMeter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;meter&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;meter&gt;</b> adapter</param>
	    public abstract void End(TagMeter adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;object&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;object&gt;</b> adapter</param>
        public abstract void Start(TagObject adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;object&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;object&gt;</b> adapter</param>
        public abstract void End(TagObject adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;optgroup&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;optgroup&gt;</b> adapter</param>
        public abstract void Start(TagOptgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;optgroup&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;optgroup&gt;</b> adapter</param>
        public abstract void End(TagOptgroup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;q&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;q&gt;</b> adapter</param>
        public abstract void Start(TagQ adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;q&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;q&gt;</b> adapter</param>
        public abstract void End(TagQ adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;s&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;s&gt;</b> adapter</param>
        public abstract void Start(TagS adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;s&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;s&gt;</b> adapter</param>
        public abstract void End(TagS adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;samp&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;samp&gt;</b> adapter</param>
        public abstract void Start(TagSamp adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;samp&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;samp&gt;</b> adapter</param>
        public abstract void End(TagSamp adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;select&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;select&gt;</b> adapter</param>
        public abstract void Start(TagSelect adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;select&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;select&gt;</b> adapter</param>
        public abstract void End(TagSelect adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;small&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;small&gt;</b> adapter</param>
        public abstract void Start(TagSmall adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;small&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;small&gt;</b> adapter</param>
        public abstract void End(TagSmall adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;span&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;span&gt;</b> adapter</param>
        public abstract void Start(TagSpan adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;span&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;span&gt;</b> adapter</param>
        public abstract void End(TagSpan adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;strike&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;strike&gt;</b> adapter</param>
        public abstract void Start(TagStrike adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;strike&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;strike&gt;</b> adapter</param>
        public abstract void End(TagStrike adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;strong&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;strong&gt;</b> adapter</param>
        public abstract void Start(TagStrong adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;strong&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;strong&gt;</b> adapter</param>
        public abstract void End(TagStrong adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;sub&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;sub&gt;</b> adapter</param>
        public abstract void Start(TagSub adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;sub&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;sub&gt;</b> adapter</param>
        public abstract void End(TagSub adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;summary&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;summary&gt;</b> adapter</param>
        public abstract void Start(TagSummary adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;summary&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;summary&gt;</b> adapter</param>
	    public abstract void End(TagSummary adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;sup&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;sup&gt;</b> adapter</param>
        public abstract void Start(TagSup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;sup&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;sup&gt;</b> adapter</param>
        public abstract void End(TagSup adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;time&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;time&gt;</b> adapter</param>
	    public abstract void Start(TagTime adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;time&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;time&gt;</b> adapter</param>
	    public abstract void End(TagTime adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tt&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tt&gt;</b> adapter</param>
        public abstract void Start(TagTt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;tt&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;tt&gt;</b> adapter</param>
        public abstract void End(TagTt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;u&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;&gt;</b> adapter</param>
        public abstract void Start(TagU adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;u&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;&gt;</b> adapter</param>
        public abstract void End(TagU adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;var&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;var&gt;</b> adapter</param>
        public abstract void Start(TagVar adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;var&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;var&gt;</b> adapter</param>
        public abstract void End(TagVar adapter);

        #endregion

        #region other tags

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dialog&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dialog&gt;</b> adapter</param>
	    public abstract void Start(TagDialog adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;dialog&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;dialog&gt;</b> adapter</param>
	    public abstract void End(TagDialog adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;keygen&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;keygen&gt;</b> adapter</param>
	    public abstract void Start(TagKeygen adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;keygen&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;keygen&gt;</b> adapter</param>
	    public abstract void End(TagKeygen adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;menu&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
        public abstract void Start(TagMenu adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;menu&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
        public abstract void End(TagMenu adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;menuitem&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
        public abstract void Start(TagMenuitem adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;menuitem&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
        public abstract void End(TagMenuitem adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;picture&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;picture&gt;</b> adapter</param>
        public abstract void Start(TagPicture adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;picture&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;picture&gt;</b> adapter</param>
        public abstract void End(TagPicture adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;rp&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;rp&gt;</b> adapter</param>
	    public abstract void Start(TagRp adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;rp&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;rp&gt;</b> adapter</param>
	    public abstract void End(TagRp adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;rt&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;rt&gt;</b> adapter</param>
	    public abstract void Start(TagRt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;rt&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;rt&gt;</b> adapter</param>
	    public abstract void End(TagRt adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ruby&gt;</b> tag adapter before
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ruby&gt;</b> adapter</param>
	    public abstract void Start(TagRuby adapter);

        /// <summary>
        ///   This abstract method is called when visiting a <b>&lt;ruby&gt;</b> tag adapter after
        ///   walking its child tags.
        /// </summary>
        /// <param name="adapter"><b>&lt;ruby&gt;</b> adapter</param>
	    public abstract void End(TagRuby adapter);

        #endregion

        #endregion

        private void Walk(BaseTag owner)
        {
            foreach (var adapter in owner.OwnedTags)
                adapter.Visit(this);
        }

        #region Vistor implementatons

        /// <summary>
        ///   Visit the root document node
        ///   Implement <see cref="ITagVoidVisitor.Visit(DocumentTag)"/>
        /// </summary>
        /// <param name="adapter">document node adapter</param>
        public virtual void Visit(DocumentTag adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit a text tag adapter
        ///   Implements <see cref="ITagVoidVisitor.Visit(Text)"/>
        /// </summary>
        /// <param name="adapter">text to be processed</param>
        public virtual void Visit(Text adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit an eol tag adapter
        ///   Implements <see cref="ITagVoidVisitor.Visit(Eol)"/>
        /// </summary>
        /// <param name="adapter">eols to be processed</param>
        public virtual void Visit(Eol adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit an enity adapter
        ///   Implements <see cref="ITagVoidVisitor.Visit(Entity)"/>
        /// </summary>
        /// <param name="adapter">entity to be processed</param>
        public virtual void Visit(Entity adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit a comment adapter
        ///   Implements <see cref="ITagVoidVisitor.Visit(Comment)"/>
        /// </summary>
        /// <param name="adapter">comment to be processed</param>
        public virtual void Visit(Comment adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit a skipped tag adapter
        ///   Implements <see cref="ITagVoidVisitor.Visit(Skip)"/>
        /// </summary>
        /// <param name="adapter">skipped tag to be processed</param>
        public virtual void Visit(Skip adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit an unknown tag adapter
        ///   Implements <see cref="ITagVoidVisitor.Visit(Unknown)"/>
        /// </summary>
        /// <param name="adapter">unknown tag to be processed</param>
        public virtual void Visit(Unknown adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;html&gt;</b> and then visit <b>&lt;head&gt;</b> and
        ///   <b>&lt;body&gt;</b> tag.
        ///   
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagHtml)"/>
        /// </summary>
        public virtual void Visit(TagHtml adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;table&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTable)"/>
        /// </summary>
        public virtual void Visit(TagTable adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;a&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagA)"/>
        /// </summary>
        public virtual void Visit(TagA adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;abbr&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagAbbr)"/>
        /// </summary>
        public virtual void Visit(TagAbbr adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;acronym&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagAcronym)"/>
        /// </summary>
        public virtual void Visit(TagAcronym adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;address&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagAddress)"/>
        /// </summary>
        public virtual void Visit(TagAddress adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;area&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagArea)"/>
        /// </summary>
        public virtual void Visit(TagArea adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;article&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagArticle)"/>
        /// </summary>
        public virtual void Visit(TagArticle adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;aside&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagAside)"/>
        /// </summary>
        public virtual void Visit(TagAside adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;audio&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagAudio)"/>
        /// </summary>
	    public virtual void Visit(TagAudio adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;b&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagB)"/>
        /// </summary>
        public virtual void Visit(TagB adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;base&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagBase)"/>
        /// </summary>
        public virtual void Visit(TagBase adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;bdi&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagBdi)"/>
        /// </summary>
        public virtual void Visit(TagBdi adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;bdo&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagBdo)"/>
        /// </summary>
        public virtual void Visit(TagBdo adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;big&gt;</b> tag and all its child tags
        ///   Implement <see cref="ITagVoidVisitor.Visit(TagBig)"/>
        /// </summary>
        /// <param name="adapter"></param>
        public virtual void Visit(TagBig adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;blockquote&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagBlockquote)"/>
        /// </summary>
        public virtual void Visit(TagBlockquote adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;bodyl&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagBody)"/>
        /// </summary>
        public virtual void Visit(TagBody body)
        {
            Start(body);
            Walk(body);
            End(body);
        }

        /// <summary>
        ///   Visit the <b>&lt;br&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagBr)"/>
        /// </summary>
        public virtual void Visit(TagBr adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;button&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagButton)"/>
        /// </summary>
        public virtual void Visit(TagButton adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;canvas&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagCanvas)"/>
        /// </summary>
        public virtual void Visit(TagCanvas adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;command&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagCommand)"/>
        /// </summary>
        public virtual void Visit(TagCommand adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;caption&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagCaption)"/>
        /// </summary>
	    public virtual void Visit(TagCaption adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;center&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagCenter)"/>
        /// </summary>
        public virtual void Visit(TagCenter adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;cite&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagCite)"/>
        /// </summary>
        public virtual void Visit(TagCite adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;code&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagCode)"/>
        /// </summary>
        public virtual void Visit(TagCode adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;col&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagCol)"/>
        /// </summary>
        public virtual void Visit(TagCol adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;colgroup&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagColgroup)"/>
        /// </summary>
        public virtual void Visit(TagColgroup adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;datalist&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagDatalist)"/>
        /// </summary>
        public virtual void Visit(TagDatalist adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;dd&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagDd)"/>
        /// </summary>
	    public virtual void Visit(TagDd adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;del&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagDel)"/>
        /// </summary>
        public virtual void Visit(TagDel adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;details&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagDetails)"/>
        /// </summary>
        public virtual void Visit(TagDetails adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;dfn&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagDfn)"/>
        /// </summary>
	    public virtual void Visit(TagDfn adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;dialong&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagDialog)"/>
        /// </summary>
        public virtual void Visit(TagDialog adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;div&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagDiv)"/>
        /// </summary>
	    public virtual void Visit(TagDiv adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;dl&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagDl)"/>
        /// </summary>
        public virtual void Visit(TagDl adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;dt&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagDt)"/>
        /// </summary>
        public virtual void Visit(TagDt adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;em&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagEm)"/>
        /// </summary>
        public virtual void Visit(TagEm adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;embed&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagEmbed)"/>
        /// </summary>
        public virtual void Visit(TagEmbed adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;fieldset&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagFieldset)"/>
        /// </summary>
        public virtual void Visit(TagFieldset adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;figcaption&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagFigcaption)"/>
        /// </summary>
        public virtual void Visit(TagFigcaption adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;figure&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagFigure)"/>
        /// </summary>
        public virtual void Visit(TagFigure adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;font&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagFont)"/>
        /// </summary>
	    public virtual void Visit(TagFont adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;footer&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagFooter)"/>
        /// </summary>
        public virtual void Visit(TagFooter adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;form&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagForm)"/>
        /// </summary>
	    public virtual void Visit(TagForm adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;h1&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagH1)"/>
        /// </summary>
        public virtual void Visit(TagH1 adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;h2&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagH2)"/>
        /// </summary>
        public virtual void Visit(TagH2 adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;h3&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagH3)"/>
        /// </summary>
        public virtual void Visit(TagH3 adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;h4&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagH4)"/>
        /// </summary>
        public virtual void Visit(TagH4 adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;h5&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagH5)"/>
        /// </summary>
        public virtual void Visit(TagH5 adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;h6&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagH6)"/>
        /// </summary>
        public virtual void Visit(TagH6 adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;head&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagHead)"/>
        /// </summary>
        public virtual void Visit(TagHead adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;header&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagHeader)"/>
        /// </summary>
        public virtual void Visit(TagHeader adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;hgroup&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagHgroup)"/>
        /// </summary>
        public virtual void Visit(TagHgroup adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;hr&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagHr)"/>
        /// </summary>
	    public virtual void Visit(TagHr adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;i&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagI)"/>
        /// </summary>
        public virtual void Visit(TagI adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;iframe&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagIframe)"/>
        /// </summary>
        public virtual void Visit(TagIframe adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;img&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagImg)"/>
        /// </summary>
        public virtual void Visit(TagImg adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;input&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagInput)"/>
        /// </summary>
        public virtual void Visit(TagInput adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;ins&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagIns)"/>
        /// </summary>
        public virtual void Visit(TagIns adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;kbd&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagKbd)"/>
        /// </summary>
        public virtual void Visit(TagKbd adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;keygen&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagKeygen)"/>
        /// </summary>
        public virtual void Visit(TagKeygen adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;label&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagLabel)"/>
        /// </summary>
	    public virtual void Visit(TagLabel adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;legend&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagLegend)"/>
        /// </summary>
        public virtual void Visit(TagLegend adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;li&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagLi)"/>
        /// </summary>
        public virtual void Visit(TagLi adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;link&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagLink)"/>
        /// </summary>
        public virtual void Visit(TagLink adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;main&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagMain)"/>
        /// </summary>
        public virtual void Visit(TagMain adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;map&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagMap)"/>
        /// </summary>
	    public virtual void Visit(TagMap adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;mark&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagMark)"/>
        /// </summary>
        public virtual void Visit(TagMark adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;menu&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagMenu)"/>
        /// </summary>
	    public virtual void Visit(TagMenu adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;menuitem&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagMenuitem)"/>
        /// </summary>
	    public virtual void Visit(TagMenuitem adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;meta&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagMeta)"/>
        /// </summary>
        public virtual void Visit(TagMeta adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;meter&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagMeter)"/>
        /// </summary>
        public virtual void Visit(TagMeter adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;nav&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagNav)"/>
        /// </summary>
        public virtual void Visit(TagNav adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;noscript&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagNoscript)"/>
        /// </summary>
	    public virtual void Visit(TagNoscript adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;object&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagObject)"/>
        /// </summary>
        public virtual void Visit(TagObject adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;ol&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagOl)"/>
        /// </summary>
        public virtual void Visit(TagOl adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;optgroup&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagOptgroup)"/>
        /// </summary>
        public virtual void Visit(TagOptgroup adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;option&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagOption)"/>
        /// </summary>
        public virtual void Visit(TagOption adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;output&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagOutput)"/>
        /// </summary>
        public virtual void Visit(TagOutput adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;p&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagP)"/>
        /// </summary>
        public virtual void Visit(TagP adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;param&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagParam)"/>
        /// </summary>
        public virtual void Visit(TagParam adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;picture&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagPicture)"/>
        /// </summary>
        public virtual void Visit(TagPicture adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;pre&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagPre)"/>
        /// </summary>
        public virtual void Visit(TagPre adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;progress&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagProgress)"/>
        /// </summary>
        public virtual void Visit(TagProgress adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;q&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagQ)"/>
        /// </summary>
	    public virtual void Visit(TagQ adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;rp&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagRp)"/>
        /// </summary>
        public virtual void Visit(TagRp adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;rt&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagRt)"/>
        /// </summary>
        public virtual void Visit(TagRt adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;ruby&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagRuby)"/>
        /// </summary>
        public virtual void Visit(TagRuby adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;title&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTitle)"/>
        /// </summary>
        public virtual void Visit(TagTitle adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;s&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagS)"/>
        /// </summary>
        public virtual void Visit(TagS adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;samp&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagSamp)"/>
        /// </summary>
        public virtual void Visit(TagSamp adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;script&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagScript)"/>
        /// </summary>
        public virtual void Visit(TagScript adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;section&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagSection)"/>
        /// </summary>
        public virtual void Visit(TagSection adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;select&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagSelect)"/>
        /// </summary>
        public virtual void Visit(TagSelect adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;small&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagSmall)"/>
        /// </summary>
        public virtual void Visit(TagSmall adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;source&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagSource)"/>
        /// </summary>
        public virtual void Visit(TagSource adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;span&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagSpan)"/>
        /// </summary>
        public virtual void Visit(TagSpan adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;strike&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagStrike)"/>
        /// </summary>
        public virtual void Visit(TagStrike adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;strong&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagStrong)"/>
        /// </summary>
        public virtual void Visit(TagStrong adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;style&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagStyle)"/>
        /// </summary>
        public virtual void Visit(TagStyle adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;sub&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagSub)"/>
        /// </summary>
        public virtual void Visit(TagSub adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;summary&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagSummary)"/>
        /// </summary>
        public virtual void Visit(TagSummary adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;sup&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagSup)"/>
        /// </summary>
        public virtual void Visit(TagSup adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;tbody&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTbody)"/>
        /// </summary>
        public virtual void Visit(TagTbody adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;td&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTd)"/>
        /// </summary>
        public virtual void Visit(TagTd adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;textarea&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTextarea)"/>
        /// </summary>
        public virtual void Visit(TagTextarea adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;tfoot&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTfoot)"/>
        /// </summary>
	    public virtual void Visit(TagTfoot adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;th&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTh)"/>
        /// </summary>
        public virtual void Visit(TagTh adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;thead&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagThead)"/>
        /// </summary>
        public virtual void Visit(TagThead adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;time&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTime)"/>
        /// </summary>
        public virtual void Visit(TagTime adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;tr&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTr)"/>
        /// </summary>
        public virtual void Visit(TagTr adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;track&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTrack)"/>
        /// </summary>
        public virtual void Visit(TagTrack adapter)
        {
            Handle(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;tt&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagTt)"/>
        /// </summary>
        public virtual void Visit(TagTt adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;u&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagU)"/>
        /// </summary>
        public virtual void Visit(TagU adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;ul&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagUl)"/>
        /// </summary>
        public virtual void Visit(TagUl adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;var&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagVar)"/>
        /// </summary>
        public virtual void Visit(TagVar adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;video&gt;</b> tag and all its child tags
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagVideo)"/>
        /// </summary>
        public virtual void Visit(TagVideo adapter)
        {
            Start(adapter);
            Walk(adapter);
            End(adapter);
        }

        /// <summary>
        ///   Visit the <b>&lt;wbr&gt;</b> tag
        ///   Implements <see cref="ITagVoidVisitor.Visit(TagWbr)"/>
        /// </summary>
        public virtual void Visit(TagWbr adapter)
        {
            Handle(adapter);
        }

        #endregion
    }
}