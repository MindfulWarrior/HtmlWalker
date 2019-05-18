package htmlwalker;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.tag.html.*;
import htmlwalker.tag.util.Comment;
import htmlwalker.tag.util.Entity;
import htmlwalker.tag.util.Eol;
import htmlwalker.tag.util.Text;
import htmlwalker.tag.util.Unknown;

public interface IWalker
{
    /// <summary>
    ///   This abstract method is called when HTML text is found
    /// </summary>
    /// <param name="adapter">the text adapter</param>
    void handle(Text adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when EOL characters are found
    /// </summary>
    /// <param name="adapter">the EOL adapter</param>
    void handle(Eol adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when and entity is found
    /// </summary>
    /// <param name="adapter">the entitiy adapter</param>
    void handle(Entity adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when a comment is found
    /// </summary>
    void handle(Comment adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when an unrecognized HTML tag is found
    /// </summary>
    /// <param name="adapter">the unknown tag</param>
    void handle(Unknown adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;area&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;area&gt;</b> tag adapter</param>
    void handle(TagArea adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;base&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;base&gt;</b> tag adapter</param>
    void handle(TagBase adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;br&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;br&gt;</b> tag adapter</param>
    void handle(TagBr adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;embed&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;embed&gt;</b> tag adapter</param>
    void handle(TagEmbed adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;hr&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;hr&gt;</b> tag adapter</param>
    void handle(TagHr adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;img&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;img&gt;</b> tag adapter</param>
    void handle(TagImg adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;input&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;input&gt;</b> tag adapter</param>
    void handle(TagInput adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;link&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;link&gt;</b> tag adapter</param>
    void handle(TagLink adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;meta&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;meta&gt;</b> tag adapter</param>
    void handle(TagMeta adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;option&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;option&gt;</b> tag adapter</param>
    void handle(TagOption adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;param&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;param&gt;</b> tag adapter</param>
    void handle(TagParam adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;progress&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;progress&gt;</b> tag adapter</param>
    void handle(TagProgress adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;scritp&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;script&gt;</b> tag adapter</param>
    void handle(TagScript adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;source&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;source&gt;</b> tag adapter</param>
    void handle(TagSource adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;style&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;style&gt;</b> tag adapter</param>
    void handle(TagStyle adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;textarea&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;textarea&gt;</b> tag adapter</param>
    void handle(TagTextarea adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;title&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;title&gt;</b> tag adapter</param>
    void handle(TagTitle adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;track&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;track&gt;</b> tag adapter</param>
    void handle(TagTrack adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;br&gt;</b> tag adapter
    /// </summary>
    /// <param name="adapter">the <b>&lt;br&gt;</b> tag adapter</param>
    void handle(TagWbr adapter) throws HtmlWalkerException;

    /// <summary>
    ///  This method is called before walking begins at the root document element
    /// </summary>
    /// <param name="adapter">the document root</param>
    void start(DocumentTag adapter) throws HtmlWalkerException;

    /// <summary>
    ///   Thsi abstract method is called at the end of visiting
    /// </summary>
    /// <param name="adapter">the document root</param>
    void end(DocumentTag adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;head&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;head&gt;</b> adapter</param>
    void start(TagHead adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;head&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;head&gt;</b> adapter</param>
    void end(TagHead adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;body&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;body&gt;</b> adapter</param>
    void start(TagBody adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;body&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;body&gt;</b> adapter</param>
    void end(TagBody adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;html&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;html&gt;</b> adapter</param>
    void start(TagHtml adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;html&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;html&gt;</b> adapter</param>
    void end(TagHtml adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;command&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;command&gt;</b> adapter</param>
    void start(TagCommand adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;command&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;command&gt;</b> adapter</param>
    void end(TagCommand adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;noscript&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;noscript&gt;</b> adapter</param>
    void start(TagNoscript adapter) throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;noscript&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;noscript&gt;</b> adapter</param>
    void end(TagNoscript adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;caption&gt;</b> adapter</param>
    void start(TagCaption adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;caption&gt;</b> adapter</param>
    void end(TagCaption adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;col&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;col&gt;</b> adapter</param>
    void start(TagCol adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;col&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;col&gt;</b> adapter</param>
    void end(TagCol adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;colgroup&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;colgroup&gt;</b> adapter</param>
    void start(TagColgroup adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;colgroup&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;colgroup&gt;</b> adapter</param>
    void end(TagColgroup adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;table&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;table&gt;</b> adapter</param>
    void start(TagTable adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;table&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;table&gt;</b> adapter</param>
    void end(TagTable adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;tbody&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;tbody&gt;</b> adapter</param>
    void start(TagTbody adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;tbody&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;tbody&gt;</b> adapter</param>
    void end(TagTbody adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;td&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;td&gt;</b> adapter</param>
    void start(TagTd adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;td&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;td&gt;</b> adapter</param>
    void end(TagTd adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;tfoot&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;tfoot&gt;</b> adapter</param>
    void start(TagTfoot adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;tfoot&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;tfoot&gt;</b> adapter</param>
    void end(TagTfoot adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;th&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;th&gt;</b> adapter</param>
    void start(TagTh adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;th&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;th&gt;</b> adapter</param>
    void end(TagTh adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;thead&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;thead&gt;</b> adapter</param>
    void start(TagThead adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;thead&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;thead&gt;</b> adapter</param>
    void end(TagThead adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;tr&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;tr&gt;</b> adapter</param>
    void start(TagTr adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;tr&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;tr&gt;</b> adapter</param>
    void end(TagTr adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;dd&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;dd&gt;</b> adapter</param>
    void start(TagDd adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;dd&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;dd&gt;</b> adapter</param>
    void end(TagDd adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;dl&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;dl&gt;</b> adapter</param>
    void start(TagDl adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;dl&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;dl&gt;</b> adapter</param>
    void end(TagDl adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;dt&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;dt&gt;</b> adapter</param>
    void start(TagDt adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;dt&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;dt&gt;</b> adapter</param>
    void end(TagDt adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;li&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;li&gt;</b> adapter</param>
    void start(TagLi adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;li&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;li&gt;</b> adapter</param>
    void end(TagLi adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;ol&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;ol&gt;</b> adapter</param>
    void start(TagOl adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;ol&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;ol&gt;</b> adapter</param>
    void end(TagOl adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;ul&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;ul&gt;</b> adapter</param>
    void start(TagUl adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;ul&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;ul&gt;</b> adapter</param>
    void end(TagUl adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;article&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;article&gt;</b> adapter</param>
    void start(TagArticle adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;article&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;article&gt;</b> adapter</param>
    void end(TagArticle adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;aside&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;aside&gt;</b> adapter</param>
    void start(TagAside adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;aside&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;aside&gt;</b> adapter</param>
    void end(TagAside adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;address&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;address&gt;</b> adapter</param>
    void start(TagAddress adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;address&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;address&gt;</b> adapter</param>
    void end(TagAddress adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;blockquote&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;blokquote&gt;</b> adapter</param>
    void start(TagBlockquote adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;blockquote&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;blockquote&gt;</b> adapter</param>
    void end(TagBlockquote adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;button&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;button&gt;</b> adapter</param>
    void start(TagButton adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;button&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;button&gt;</b> adapter</param>
    void end(TagButton adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;canvas&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;canvas&gt;</b> adapter</param>
    void start(TagCanvas adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;canvas&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;canvas&gt;</b> adapter</param>
    void end(TagCanvas adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;center&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;center&gt;</b> adapter</param>
    void start(TagCenter adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;center&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;center&gt;</b> adapter</param>
    void end(TagCenter adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;div&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;div&gt;</b> adapter</param>
    void start(TagDiv adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;div&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;div&gt;</b> adapter</param>
    void end(TagDiv adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;fieldset&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;fieldset&gt;</b> adapter</param>
    void start(TagFieldset adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;fieldset&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;fieldset&gt;</b> adapter</param>
    void end(TagFieldset adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;caption&gt;</b> adapter</param>
    void start(TagFigcaption adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;figcaption&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;figcaption&gt;</b> adapter</param>
    void end(TagFigcaption adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;figure&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;figure&gt;</b> adapter</param>
    void start(TagFigure adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;figure&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;figure&gt;</b> adapter</param>
    void end(TagFigure adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;footer&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;footer&gt;</b> adapter</param>
    void start(TagFooter adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;footer&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;footer&gt;</b> adapter</param>
    void end(TagFooter adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;form&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;form&gt;</b> adapter</param>
    void start(TagForm adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;form&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;form&gt;</b> adapter</param>
    void end(TagForm adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h1&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h1&gt;</b> adapter</param>
    void start(TagH1 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h1&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h2&gt;</b> adapter</param>
    void end(TagH1 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h2&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h2&gt;</b> adapter</param>
    void start(TagH2 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h2&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h2&gt;</b> adapter</param>
    void end(TagH2 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h3&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h3&gt;</b> adapter</param>
    void start(TagH3 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h3&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h3&gt;</b> adapter</param>
    void end(TagH3 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h4&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h4&gt;</b> adapter</param>
    void start(TagH4 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h4&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h4&gt;</b> adapter</param>
    void end(TagH4 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h5&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h5&gt;</b> adapter</param>
    void start(TagH5 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h5&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h5&gt;</b> adapter</param>
    void end(TagH5 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h6&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h6&gt;</b> adapter</param>
    void start(TagH6 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;h6&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;h6&gt;</b> adapter</param>
    void end(TagH6 adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;header&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;header&gt;</b> adapter</param>
    void start(TagHeader adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;header&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;header&gt;</b> adapter</param>
    void end(TagHeader adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;hgroup&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;hgroup&gt;</b> adapter</param>
    void start(TagHgroup adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;hgroup&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;hgroup&gt;</b> adapter</param>
    void end(TagHgroup adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;main&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;main&gt;</b> adapter</param>
    void start(TagMain adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;main&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;main&gt;</b> adapter</param>
    void end(TagMain adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;nav&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;nav&gt;</b> adapter</param>
    void start(TagNav adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;nav&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;nav&gt;</b> adapter</param>
    void end(TagNav adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;outpu&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;output&gt;</b> adapter</param>
    void start(TagOutput adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;outpu&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;output&gt;</b> adapter</param>
    void end(TagOutput adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;p&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;p&gt;</b> adapter</param>
    void start(TagP adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;p&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;p&gt;</b> adapter</param>
    void end(TagP adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;pre&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;pre&gt;</b> adapter</param>
    void start(TagPre adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;pre&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;pre&gt;</b> adapter</param>
    void end(TagPre adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;section&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;section&gt;</b> adapter</param>
    void start(TagSection adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;section&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;section&gt;</b> adapter</param>
    void end(TagSection adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;video&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;video&gt;</b> adapter</param>
    void start(TagVideo adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;video&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;video&gt;</b> adapter</param>
    void end(TagVideo adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;a&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;a&gt;</b> adapter</param>
    void start(TagA adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;a&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;a&gt;</b> adapter</param>
    void end(TagA adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;abbr&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;abbr&gt;</b> adapter</param>
    void start(TagAbbr adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;abbr&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;abbr&gt;</b> adapter</param>
    void end(TagAbbr adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;acronym&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;acronym&gt;</b> adapter</param>
    void start(TagAcronym adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;acronym&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;acronym&gt;</b> adapter</param>
    void end(TagAcronym adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;audio&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;audio&gt;</b> adapter</param>
    void start(TagAudio adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;audio&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;audio&gt;</b> adapter</param>
    void end(TagAudio adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;b&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;b&gt;</b> adapter</param>
    void start(TagB adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;b&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;b&gt;</b> adapter</param>
    void end(TagB adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;bdi&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;bdi&gt;</b> adapter</param>
    void start(TagBdi adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;bdi&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;bdi&gt;</b> adapter</param>
    void end(TagBdi adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;bdo&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;bdo&gt;</b> adapter</param>
    void start(TagBdo adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;bdo&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;bdo&gt;</b> adapter</param>
    void end(TagBdo adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;big&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;big&gt;</b> adapter</param>
    void start(TagBig adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;big&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;big&gt;</b> adapter</param>
    void end(TagBig adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;cite&gt;</b> tag adapter befoe
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;cite&gt;</b> adapter</param>
    void start(TagCite adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;cite&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;cite&gt;</b> adapter</param>
    void end(TagCite adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;code&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;code&gt;</b> adapter</param>
    void start(TagCode adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;code&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;code&gt;</b> adapter</param>
    void end(TagCode adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;datalist&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;datalist&gt;</b> adapter</param>
    void start(TagDatalist adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;datalist&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;datalist&gt;</b> adapter</param>
    void end(TagDatalist adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;del&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;del&gt;</b> adapter</param>
    void start(TagDel adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;del&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;del&gt;</b> adapter</param>
    void end(TagDel adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;details&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;details&gt;</b> adapter</param>
    void start(TagDetails adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;details&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;details&gt;</b> adapter</param>
    void end(TagDetails adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;dfn&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;dfn&gt;</b> adapter</param>
    void start(TagDfn adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;dfn&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;dfn&gt;</b> adapter</param>
    void end(TagDfn adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;em&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;em&gt;</b> adapter</param>
    void start(TagEm adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;em&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;em&gt;</b> adapter</param>
    void end(TagEm adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;font&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;font&gt;</b> adapter</param>
    void start(TagFont adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;font&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;font&gt;</b> adapter</param>
    void end(TagFont adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;i&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;i&gt;</b> adapter</param>
    void start(TagI adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;i&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;i&gt;</b> adapter</param>
    void end(TagI adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;iframe&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;iframe&gt;</b> adapter</param>
    void start(TagIframe adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;iframe&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;iframe&gt;</b> adapter</param>
    void end(TagIframe adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;ins&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;ins&gt;</b> adapter</param>
    void start(TagIns adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;ins&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;ins&gt;</b> adapter</param>
    void end(TagIns adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;kdb&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;kdb&gt;</b> adapter</param>
    void start(TagKbd adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;kdb&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;kdb&gt;</b> adapter</param>
    void end(TagKbd adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;label&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;label&gt;</b> adapter</param>
    void start(TagLabel adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;label&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;label&gt;</b> adapter</param>
    void end(TagLabel adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;legend&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;legend&gt;</b> adapter</param>
    void start(TagLegend adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;legend&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;legend&gt;</b> adapter</param>
    void end(TagLegend adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;mark&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;mark&gt;</b> adapter</param>
    void start(TagMark adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;mark&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;mark&gt;</b> adapter</param>
    void end(TagMark adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;map&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;map&gt;</b> adapter</param>
    void start(TagMap adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;map&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;map&gt;</b> adapter</param>
    void end(TagMap adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;meter&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;meter&gt;</b> adapter</param>
    void start(TagMeter adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;meter&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;meter&gt;</b> adapter</param>
    void end(TagMeter adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;object&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;object&gt;</b> adapter</param>
    void start(TagObject adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;object&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;object&gt;</b> adapter</param>
    void end(TagObject adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;optgroup&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;optgroup&gt;</b> adapter</param>
    void start(TagOptgroup adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;optgroup&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;optgroup&gt;</b> adapter</param>
    void end(TagOptgroup adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;q&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;q&gt;</b> adapter</param>
    void start(TagQ adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;q&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;q&gt;</b> adapter</param>
    void end(TagQ adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;s&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;s&gt;</b> adapter</param>
    void start(TagS adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;s&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;s&gt;</b> adapter</param>
    void end(TagS adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;samp&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;samp&gt;</b> adapter</param>
    void start(TagSamp adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;samp&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;samp&gt;</b> adapter</param>
    void end(TagSamp adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;select&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;select&gt;</b> adapter</param>
    void start(TagSelect adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;select&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;select&gt;</b> adapter</param>
    void end(TagSelect adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;small&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;small&gt;</b> adapter</param>
    void start(TagSmall adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;small&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;small&gt;</b> adapter</param>
    void end(TagSmall adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;span&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;span&gt;</b> adapter</param>
    void start(TagSpan adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;span&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;span&gt;</b> adapter</param>
    void end(TagSpan adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;strike&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;strike&gt;</b> adapter</param>
    void start(TagStrike adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;strike&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;strike&gt;</b> adapter</param>
    void end(TagStrike adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;strong&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;strong&gt;</b> adapter</param>
    void start(TagStrong adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;strong&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;strong&gt;</b> adapter</param>
    void end(TagStrong adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;sub&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;sub&gt;</b> adapter</param>
    void start(TagSub adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;sup&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;sup&gt;</b> adapter</param>
    void end(TagSup adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;summary&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;summary&gt;</b> adapter</param>
    void start(TagSummary adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;summary&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;summary&gt;</b> adapter</param>
    void end(TagSummary adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;sub&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;sub&gt;</b> adapter</param>
    void end(TagSub adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;sup&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;sup&gt;</b> adapter</param>
    void start(TagSup adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;time&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;time&gt;</b> adapter</param>
    void start(TagTime adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;time&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;time&gt;</b> adapter</param>
    void end(TagTime adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;tt&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;tt&gt;</b> adapter</param>
    void start(TagTt adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;tt&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;tt&gt;</b> adapter</param>
    void end(TagTt adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;u&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;&gt;</b> adapter</param>
    void start(TagU adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;u&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;&gt;</b> adapter</param>
    void end(TagU adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;var&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;var&gt;</b> adapter</param>
    void start(TagVar adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;var&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;var&gt;</b> adapter</param>
    void end(TagVar adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;dialog&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;dialog&gt;</b> adapter</param>
    void start(TagDialog adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;dialog&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;dialog&gt;</b> adapter</param>
    void end(TagDialog adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;keygen&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;keygen&gt;</b> adapter</param>
    void start(TagKeygen adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;keygen&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;keygen&gt;</b> adapter</param>
    void end(TagKeygen adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;menu&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
    void start(TagMenu adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;menu&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
    void end(TagMenu adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;menuitem&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
    void start(TagMenuitem adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;menuitem&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;menu&gt;</b> adapter</param>
    void end(TagMenuitem adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;picture&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;picture&gt;</b> adapter</param>
    void start(TagPicture adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;picture&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;picture&gt;</b> adapter</param>
    void end(TagPicture adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;rp&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;rp&gt;</b> adapter</param>
    void start(TagRp adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;rp&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;rp&gt;</b> adapter</param>
    void end(TagRp adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;rt&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;rt&gt;</b> adapter</param>
    void start(TagRt adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;rt&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;rt&gt;</b> adapter</param>
    void end(TagRt adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;ruby&gt;</b> tag adapter before
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;ruby&gt;</b> adapter</param>
    void start(TagRuby adapter)  throws HtmlWalkerException;

    /// <summary>
    ///   This abstract method is called when visiting a <b>&lt;ruby&gt;</b> tag adapter after
    ///   walking its child tags.
    /// </summary>
    /// <param name="adapter"><b>&lt;ruby&gt;</b> adapter</param>
    void end(TagRuby adapter)  throws HtmlWalkerException;
}
