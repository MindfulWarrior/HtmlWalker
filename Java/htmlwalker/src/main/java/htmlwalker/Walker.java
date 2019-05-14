/*
 * 
 */
package htmlwalker;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.tag.base.BaseTag;
import htmlwalker.tag.html.*;
import htmlwalker.tag.util.Comment;
import htmlwalker.tag.util.Entity;
import htmlwalker.tag.util.Eol;
import htmlwalker.tag.util.Text;
import htmlwalker.tag.util.Unknown;
import htmlwalker.visitor.ITagVoidVisitor;

/**
 * This abstract class uses the visitor pattern to do a depth-first walk
 * of a well-formed HTML document.
 * 
 * How the HTML document is implemented is managed through the
 * <b>WalkerPlatform</b>, <b>WalkerDocument</b>, and <b>WalkerContent</b>
 * abstract classes.
 * 
 * Each HTML tag is visited through a tag adapter. If the tag has children tags,
 * then an abstract <b><i>start</i></b> and <b><i>end</i></b> method is called
 * before and after walking the child tags. Otherwise an abstract <b><i>handle</i></b>
 * is called. 
 * 
 * @see HtmlWalker.ITagVoidVisitor
 * @see HtmlWalker.WalkerPlatform
 * @see ITagDocument.WalkerDocument
 * @see HtmlWalker.WalkerContent
 * 
 * @author Robert Flores
 */
public abstract class Walker implements ITagVoidVisitor, IWalker
{

	/**
	 * Instantiates a new walker for the given platform implementation.
	 */
	public Walker() { }
		
	/**
	 * This abstract method is called when HTML text is found.
	 *
	 * @param owner - the tag adapter owning the text content
	 * @param content - the text content
	 * @throws HtmlWalkerException 
	 */
	public abstract void handle(Text adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when HTML eol's are found.
	 *
	 * @param owner - the tag adapter owning the eol's
	 * @param count - the number of eol's
	 * @throws HtmlWalkerException 
	 */
	public abstract void handle(Eol adapter) throws HtmlWalkerException;
	
	public abstract void handle(Comment adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when HTML eol's are found.
	 *
	 * @param owner - the tag adapter owning the entity
	 * @param value - the entity object
	 * @throws HtmlWalkerException 
	 */
	public abstract void handle(Entity adapter) throws HtmlWalkerException;

	// TODO: Make start/end
	public abstract void handle(Unknown adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;area&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;area&gt;</b> tag adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void handle(TagArea adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;base&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;base&gt;</b> tag adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void handle(TagBase adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;br&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;br&gt;</b> tag adapter
	 */
	public abstract void handle(TagBr adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;embed&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;embed&gt;</b> tag adapter
	 */
	public abstract void handle(TagEmbed adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;hr&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;hr&gt;</b> tag adapter
	 */
	public abstract void handle(TagHr adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;img&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;img&gt;</b> tag adapter
	 */
	public abstract void handle(TagImg adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;input&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;input&gt;</b> tag adapter
	 */
	public abstract void handle(TagInput adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;link&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;link&gt;</b> tag adapter
	 */
	public abstract void handle(TagLink adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;meta&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;meta&gt;</b> tag adapter
	 */
	public abstract void handle(TagMeta adapter) throws HtmlWalkerException;	
	
	/**
	 * This abstract method is called when visiting a <b>&lt;option&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;option&gt;</b> tag adapter
	 */
	public abstract void handle(TagOption adapter) throws HtmlWalkerException;	
	
	/**
	 * This abstract method is called when visiting a <b>&lt;param&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;param&gt;</b> tag adapter
	 */
	public abstract void handle(TagParam adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;progress&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;progress&gt;</b> tag adapter
	 */
	public abstract void handle(TagProgress adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;script&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;&gt;</b> tag adapter
	 */
	public abstract void handle(TagScript adapter) throws HtmlWalkerException;	
	
	/**
	 * This abstract method is called when visiting a <b>&lt;source&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;source&gt;</b> tag adapter
	 */
	public abstract void handle(TagSource adapter) throws HtmlWalkerException;	
	
	/**
	 * This abstract method is called when visiting a <b>&lt;style&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;style&gt;</b> tag adapter
	 */
	public abstract void handle(TagStyle adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;textarea&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;textarea&gt;</b> tag adapter
	 */
	public abstract void handle(TagTextarea adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;title&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;title&gt;</b> tag adapter
	 */
	public abstract void handle(TagTitle adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;track&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;track&gt;</b> tag adapter
	 */
	public abstract void handle(TagTrack adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;wbr&gt;</b> tag adapter.
	 *
	 * @param adapter - the <b>&lt;wbr&gt;</b> tag adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void handle(TagWbr adapter) throws HtmlWalkerException;	
	
	/**
	 * This abstract method is called when visiting the document tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the document tag adapter
	 */
	public abstract void start(DocumentTag adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a document tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the document tag adapter
	 */
	public abstract void end(DocumentTag adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;a&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;a&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagA adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;a&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;a&gt;</b> adapter
	 */
	public abstract void end(TagA adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;abbr&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;abbr&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagAbbr adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;abbr&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;abbr&gt;</b> adapter
	 */
	public abstract void end(TagAbbr adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;acronym&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;acronym&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagAcronym adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;acronym&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;acronym&gt;</b> adapter
	 */
	public abstract void end(TagAcronym adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;address&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;address&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagAddress adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;address&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;address&gt;</b> adapter
	 */
	public abstract void end(TagAddress adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;article&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;article&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagArticle adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;article&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;&gt;</b> adapter
	 */
	public abstract void end(TagArticle adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;article&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;article&gt;</b> adapter
	 */
	public abstract void start(TagAside adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;aside&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;aside&gt;</b> adapter
	 */
	public abstract void end(TagAside adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;audio&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;audio&gt;</b> adapter
	 */
	public abstract void start(TagAudio adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;audio&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;audio&gt;</b> adapter
	 */
	public abstract void end(TagAudio adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;b&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;b&gt;</b> adapter
	 */
	public abstract void start(TagB adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;b&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;b&gt;</b> adapter
	 */
	public abstract void end(TagB adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;bdi&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;bdi&gt;</b> adapter
	 */
	public abstract void start(TagBdi adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;bdi&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;bdi&gt;</b> adapter
	 */
	public abstract void end(TagBdi adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;bdo&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;bdo&gt;</b> adapter
	 */
	public abstract void start(TagBdo adapter) throws HtmlWalkerException;
	
	public abstract void start(TagBig adapter) throws HtmlWalkerException;

	public abstract void end(TagBig adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;bdo&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;bdo&gt;</b> adapter
	 */
	public abstract void end(TagBdo adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;blockquote&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;blockquote&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagBlockquote adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;blockquote&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;blockquote&gt;</b> adapter
	 */
	public abstract void end(TagBlockquote adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;body&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;body&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagBody adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;body&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;body&gt;</b> adapter
	 */
	public abstract void end(TagBody adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;button&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;button&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagButton adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;button&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;button&gt;</b> adapter
	 */
	public abstract void end(TagButton adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;canvas&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;canvas&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagCanvas adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;canvas&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;canvas&gt;</b> adapter
	 */
	public abstract void end(TagCanvas adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;caption&gt;</b> adapter
	 */
	public abstract void start(TagCaption adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;caption&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;caption&gt;</b> adapter
	 */
	public abstract void end(TagCaption adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;cite&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;cite&gt;</b> adapter
	 */
	public abstract void start(TagCite adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;cite&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;cite&gt;</b> adapter
	 */
	public abstract void end(TagCite adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;cite&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;center&gt;</b> adapter
	 */
	public abstract void start(TagCenter adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;center&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;center&gt;</b> adapter
	 */
	public abstract void end(TagCenter adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;code&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;code&gt;</b> adapter
	 */
	public abstract void start(TagCode adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;code&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;code&gt;</b> adapter
	 */
	public abstract void end(TagCode adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;col&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;col&gt;</b> adapter
	 */
	public abstract void start(TagCol adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;col&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;col&gt;</b> adapter
	 */
	public abstract void end(TagCol adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;colgroup&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;colgroup&gt;</b> adapter
	 */
	public abstract void start(TagColgroup adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;colgroup&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;colgroup&gt;</b> adapter
	 */
	public abstract void end(TagColgroup adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;command&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;command&gt;</b> adapter
	 */
	public abstract void start(TagCommand adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;command&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;command&gt;</b> adapter
	 */
	public abstract void end(TagCommand adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;datalist&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;datalist&gt;</b> adapter
	 */
	public abstract void start(TagDatalist adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;datalist&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;datalist&gt;</b> adapter
	 */
	public abstract void end(TagDatalist adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;details&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;details&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagDetails adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;details&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;details&gt;</b> adapter
	 */
	public abstract void end(TagDetails adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;del&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;del&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagDel adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;del&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;del&gt;</b> adapter
	 */
	public abstract void end(TagDel adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;dfn&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;dfn&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagDfn adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;dfn&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;dfn&gt;</b> adapter
	 */
	public abstract void end(TagDfn adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;dialog&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;dialog&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagDialog adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;dialog&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;dialog&gt;</b> adapter
	 */
	public abstract void end(TagDialog adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;dl&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;dl&gt;</b> adapter
	 */
	public abstract void start(TagDl adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;dl&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;dl&gt;</b> adapter
	 */
	public abstract void end(TagDl adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;dt&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;dt&gt;</b> adapter
	 */
	public abstract void start(TagDt adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;dt&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;dt&gt;</b> adapter
	 */
	public abstract void end(TagDt adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;dd&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;dd&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagDd adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;dd&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;dd&gt;</b> adapter
	 */
	public abstract void end(TagDd adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;div&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;div&gt;</b> adapter
	 */
	public abstract void start(TagDiv adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;div&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;div&gt;</b> adapter
	 */
	public abstract void end(TagDiv adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;em&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;em&gt;</b> adapter
	 */
	public abstract void start(TagEm adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;em&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;em&gt;</b> adapter
	 */
	public abstract void end(TagEm adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;fieldset&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;fieldset&gt;</b> adapter
	 */
	public abstract void start(TagFieldset adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;fieldset&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;fieldset&gt;</b> adapter
	 */
	public abstract void end(TagFieldset adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;figcaption&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;figcaption&gt;</b> adapter
	 */
	public abstract void start(TagFigcaption adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;figcaption&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;figcaption&gt;</b> adapter
	 */
	public abstract void end(TagFigcaption adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;figure&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;figure&gt;</b> adapter
	 */
	public abstract void start(TagFigure adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;figure&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;figure&gt;</b> adapter
	 */
	public abstract void end(TagFigure adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;font&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;font&gt;</b> adapter
	 */
	public abstract void start(TagFont adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;font&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;font&gt;</b> adapter
	 */
	public abstract void end(TagFont adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;footer&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;footer&gt;</b> adapter
	 */
	public abstract void start(TagFooter adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;footer&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;footer&gt;</b> adapter
	 */
	public abstract void end(TagFooter adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;form&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;form&gt;</b> adapter
	 */
	public abstract void start(TagForm adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;form&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;form&gt;</b> adapter
	 */
	public abstract void end(TagForm adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;h1&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h1&gt;</b> adapter
	 */
	public abstract void start(TagH1 adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;h1&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h1&gt;</b> adapter
	 */
	public abstract void end(TagH1 adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;h2&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h2&gt;</b> adapter
	 */
	public abstract void start(TagH2 adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;h2&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h2&gt;</b> adapter
	 */
	public abstract void end(TagH2 adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;h3&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h3&gt;</b> adapter
	 */
	public abstract void start(TagH3 adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;h3&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h3&gt;</b> adapter
	 */
	public abstract void end(TagH3 adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;h4&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h4&gt;</b> adapter
	 */
	public abstract void start(TagH4 adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;h4&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h4&gt;</b> adapter
	 */
	public abstract void end(TagH4 adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;h5&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h5&gt;</b> adapter
	 */
	public abstract void start(TagH5 adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;h5&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h5&gt;</b> adapter
	 */
	public abstract void end(TagH5 adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;h6&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h6&gt;</b> adapter
	 */
	public abstract void start(TagH6 adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;h6&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;h6&gt;</b> adapter
	 */
	public abstract void end(TagH6 adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;head&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;head&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagHead adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;head&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;head&gt;</b> adapter
	 */
	public abstract void end(TagHead adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;header&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;header&gt;</b> adapter
	 */
	public abstract void start(TagHeader adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;header&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;header&gt;</b> adapter
	 */
	public abstract void end(TagHeader adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;hgroup&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;hgroup&gt;</b> adapter
	 */
	public abstract void start(TagHgroup adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;hgroup&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;hgroup&gt;</b> adapter
	 */
	public abstract void end(TagHgroup adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;html&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;html&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 */
	public abstract void start(TagHtml adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;html&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;html&gt;</b> adapter
	 */
	public abstract void end(TagHtml adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;i&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;i&gt;</b> adapter
	 */
	public abstract void start(TagI adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;i&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;i&gt;</b> adapter
	 */
	public abstract void end(TagI adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;iframe&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;iframe&gt;</b> adapter
	 */
	public abstract void start(TagIframe adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;iframe&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;iframe&gt;</b> adapter
	 */
	public abstract void end(TagIframe adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;ins&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;ins&gt;</b> adapter
	 */
	public abstract void start(TagIns adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;ins&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;ins&gt;</b> adapter
	 */
	public abstract void end(TagIns adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;kbd&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;kbd&gt;</b> adapter
	 */
	public abstract void start(TagKbd adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;kbd&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;kbd&gt;</b> adapter
	 */
	public abstract void end(TagKbd adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;keygen&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;keygen&gt;</b> adapter
	 */
	public abstract void start(TagKeygen adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;keygen&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;keygen&gt;</b> adapter
	 */
	public abstract void end(TagKeygen adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;label&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;label&gt;</b> adapter
	 */
	public abstract void start(TagLabel adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;label&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;label&gt;</b> adapter
	 */
	public abstract void end(TagLabel adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;legend&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;legend&gt;</b> adapter
	 */
	public abstract void start(TagLegend adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;legend&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;legend&gt;</b> adapter
	 */
	public abstract void end(TagLegend adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;li&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;li&gt;</b> adapter
	 */
	public abstract void start(TagLi adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;li&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;li&gt;</b> adapter
	 */
	public abstract void end(TagLi adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;main&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;main&gt;</b> adapter
	 */
	public abstract void start(TagMain adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;main&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;main&gt;</b> adapter
	 */
	public abstract void end(TagMain adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;map&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;map&gt;</b> adapter
	 */
	public abstract void start(TagMap adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;map&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;map&gt;</b> adapter
	 */
	public abstract void end(TagMap adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;mark&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;mark&gt;</b> adapter
	 */
	public abstract void start(TagMark adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;mark&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;mark&gt;</b> adapter
	 */
	public abstract void end(TagMark adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;menu&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;menu&gt;</b> adapter
	 */
	public abstract void start(TagMenu adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;menu&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;menu&gt;</b> adapter
	 */
	public abstract void end(TagMenu adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;menuitem&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;menuitem&gt;</b> adapter
	 */
	public abstract void start(TagMenuitem adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;menuitem&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;menuitem&gt;</b> adapter
	 */
	public abstract void end(TagMenuitem adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;meter&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;meter&gt;</b> adapter
	 */
	public abstract void start(TagMeter adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;meter&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;meter&gt;</b> adapter
	 */
	public abstract void end(TagMeter adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;nav&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;nav&gt;</b> adapter
	 */
	public abstract void start(TagNav adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;nav&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;nav&gt;</b> adapter
	 */
	public abstract void end(TagNav adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;noscript&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;noscript&gt;</b> adapter
	 */
	public abstract void start(TagNoscript adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;noscript&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;noscript&gt;</b> adapter
	 */
	public abstract void end(TagNoscript adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;object&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;object&gt;</b> adapter
	 */
	public abstract void start(TagObject adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;object&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;object&gt;</b> adapter
	 */
	public abstract void end(TagObject adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;ol&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;ol&gt;</b> adapter
	 */
	public abstract void start(TagOl adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;ol&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;ol&gt;</b> adapter
	 */
	public abstract void end(TagOl adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;optgroup&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;optgroup&gt;</b> adapter
	 */
	public abstract void start(TagOptgroup adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;optgroup&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;optgroup&gt;</b> adapter
	 */
	public abstract void end(TagOptgroup adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;output&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;output&gt;</b> adapter
	 */
	public abstract void start(TagOutput adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;output&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;output&gt;</b> adapter
	 */
	public abstract void end(TagOutput adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;p&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;p&gt;</b> adapter
	 */
	public abstract void start(TagP adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;p&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;p&gt;</b> adapter
	 */
	public abstract void end(TagP adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;picture&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;picture&gt;</b> adapter
	 */
	public abstract void start(TagPicture adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;picture&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;picture&gt;</b> adapter
	 */
	public abstract void end(TagPicture adapter) throws HtmlWalkerException;


	/**
	 * This abstract method is called when visiting a <b>&lt;pre&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;pre&gt;</b> adapter
	 */
	public abstract void start(TagPre adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;pre&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;pre&gt;</b> adapter
	 */
	public abstract void end(TagPre adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;q&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;q&gt;</b> adapter
	 */
	public abstract void start(TagQ adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;q&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;q&gt;</b> adapter
	 */
	public abstract void end(TagQ adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;rp&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;rp&gt;</b> adapter
	 */
	public abstract void start(TagRp adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;rp&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;rp&gt;</b> adapter
	 */
	public abstract void end(TagRp adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;rt&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;rt&gt;</b> adapter
	 */
	public abstract void start(TagRt adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;rt&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;rt&gt;</b> adapter
	 */
	public abstract void end(TagRt adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;rt&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;rt&gt;</b> adapter
	 */
	public abstract void start(TagRuby adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;ruby&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;ruby&gt;</b> adapter
	 */
	public abstract void end(TagRuby adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;s&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;s&gt;</b> adapter
	 */
	public abstract void start(TagS adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;s&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;s&gt;</b> adapter
	 */
	public abstract void end(TagS adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;select&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;select&gt;</b> adapter
	 */
	public abstract void start(TagSelect adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;select&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;select&gt;</b> adapter
	 */
	public abstract void end(TagSelect adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;samp&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;samp&gt;</b> adapter
	 */
	public abstract void start(TagSamp adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;samp&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;samp&gt;</b> adapter
	 */
	public abstract void end(TagSamp adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;section&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;section&gt;</b> adapter
	 */
	public abstract void start(TagSection adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;section&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;section&gt;</b> adapter
	 */
	public abstract void end(TagSection adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;small&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;small&gt;</b> adapter
	 */
	public abstract void start(TagSmall adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;small&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;small&gt;</b> adapter
	 */
	public abstract void end(TagSmall adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;span&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;span&gt;</b> adapter
	 */
	public abstract void start(TagSpan adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;span&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;span&gt;</b> adapter
	 */
	public abstract void end(TagSpan adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;strike&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;strike&gt;</b> adapter
	 */
	public abstract void start(TagStrike adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;strike&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;strike&gt;</b> adapter
	 */
	public abstract void end(TagStrike adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;strong&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;strong&gt;</b> adapter
	 */
	public abstract void start(TagStrong adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;strong&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;strong&gt;</b> adapter
	 */
	public abstract void end(TagStrong adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;sub&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;sub&gt;</b> adapter
	 */
	public abstract void start(TagSub adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;sub&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;sub&gt;</b> adapter
	 */
	public abstract void end(TagSub adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;summary&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;summary&gt;</b> adapter
	 */
	public abstract void start(TagSummary adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;summary&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;summary&gt;</b> adapter
	 */
	public abstract void end(TagSummary adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;sup&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;sup&gt;</b> adapter
	 */
	public abstract void start(TagSup adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;sup&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;sup&gt;</b> adapter
	 */
	public abstract void end(TagSup adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;table&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;table&gt;</b> adapter
	 */
	public abstract void start(TagTable adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;table&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;table&gt;</b> adapter
	 */
	public abstract void end(TagTable adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;tbody&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;tbody&gt;</b> adapter
	 */
	public abstract void start(TagTbody adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;tbody&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;tbody&gt;</b> adapter
	 */
	public abstract void end(TagTbody adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;td&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;td&gt;</b> adapter
	 */
	public abstract void start(TagTd adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;td&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;td&gt;</b> adapter
	 */
	public abstract void end(TagTd adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;tfoot&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;tfoot&gt;</b> adapter
	 */
	public abstract void start(TagTfoot adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;tfoot&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;tfoot&gt;</b> adapter
	 */
	public abstract void end(TagTfoot adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;th&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;th&gt;</b> adapter
	 */
	public abstract void start(TagTh adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;th&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;th&gt;</b> adapter
	 */
	public abstract void end(TagTh adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;thead&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;thead&gt;</b> adapter
	 */
	public abstract void start(TagThead adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;thead&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;thead&gt;</b> adapter
	 */
	public abstract void end(TagThead adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;time&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;time&gt;</b> adapter
	 */
	public abstract void start(TagTime adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;time&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;time&gt;</b> adapter
	 */
	public abstract void end(TagTime adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;tr&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;tr&gt;</b> adapter
	 */
	public abstract void start(TagTr adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;tr&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;tr&gt;</b> adapter
	 */
	public abstract void end(TagTr adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;tt&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;tt&gt;</b> adapter
	 */
	public abstract void start(TagTt adapter) throws HtmlWalkerException;

	/**
	 * This abstract method is called when visiting a <b>&lt;u&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;u&gt;</b> adapter
	 */
	public abstract void end(TagTt adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;u&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;u&gt;</b> adapter
	 */
	public abstract void start(TagU adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;u&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;u&gt;</b> adapter
	 */
	public abstract void end(TagU adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;ul&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;ul&gt;</b> adapter
	 */
	public abstract void start(TagUl adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;ul&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;ul&gt;</b> adapter
	 */
	public abstract void end(TagUl adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;var&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;var&gt;</b> adapter
	 */
	public abstract void start(TagVar adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;var&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;var&gt;</b> adapter
	 */
	public abstract void end(TagVar adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;video&gt;</b> tag adapter before
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;video&gt;</b> adapter
	 */
	public abstract void start(TagVideo adapter) throws HtmlWalkerException;
	
	/**
	 * This abstract method is called when visiting a <b>&lt;video&gt;</b> tag adapter after
	 * walking its child tags.
	 *
	 * @param adapter - the <b>&lt;video&gt;</b> adapter
	 */
	public abstract void end(TagVideo adapter) throws HtmlWalkerException;
		
	/**
	 * This private method walks the child tag of the owner tag passed.
	 *
	 * @param owner the owner
	 * @throws HtmlWalkerException the html walker exception
	 */
	private void walk(BaseTag owner) throws HtmlWalkerException
	{
		for (ITag adapter : owner.ownedTags())
			adapter.visit(this);
	}
	
	/**
	 * Visit a document tag adapter.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.Text)
	 */
	@Override
	public void visit(DocumentTag adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit a text tag adapter.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.Text)
	 */
	@Override
	public void visit(Text adapter) throws HtmlWalkerException { handle(adapter); }
	
	/**
	 * Visit a eol tag adapter.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.Tag.Eol)
	 */
	@Override
	public void visit(Eol adapter) throws HtmlWalkerException { handle(adapter); }
	
	/**
	 * Visit a text tag adapter.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(htmlwalker.tag.Entity)
	 */
	@Override
	public void visit(Entity adapter) throws HtmlWalkerException { handle(adapter); }
	
	@Override
	public void visit(Comment adapter) throws HtmlWalkerException { handle(adapter); }

	@Override
	public void visit(Unknown adapter) throws HtmlWalkerException { handle(adapter); }	
		
	/**
	 * Visit the <b>&lt;html&gt;</b> and then visit <b>&lt;head&gt;</b> and
	 * <b>&lt;body&gt;</b> tag.
	 * 
	 * This method uses the <b>getHead</b> and </b>getBody</b> methods to
	 * find the <b>&lt;head&gt;</b> and <b>&lt;body&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagHtml)
	 * @see HtmlWalker.TagHtml#getHead()
	 * @see HtmlWalker.TagHtml#getBody()
	 */
	@Override
	public void visit(TagHtml html) throws HtmlWalkerException
	{
		start(html);
		walk(html);
		end(html);				
	}

	/**
	 * Visit the <b>&lt;bodyl&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagBody)
	 */
	@Override
	public void visit(TagBody body) throws HtmlWalkerException
	{
		start(body);
		walk(body);
		end(body);
	}
	
	/**
	 * Visit the <b>&lt;table&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTable)
	 */
	@Override
	public void visit(TagTable table) throws HtmlWalkerException
	{
		start(table);
		walk(table);
		end(table);
	}
	
	/**
	 * Visit the <b>&lt;s&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagA)
	 */
	@Override
	public void visit(TagA adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;abbr&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagAbbr)
	 */
	@Override
	public void visit(TagAbbr adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;acronym&gt;</b> tag.
	 * @throws HtmlWalkerException 
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagAcronym)
	 */
	@Override
	public void visit(TagAcronym adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;address&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagAddress)
	 */
	@Override
	public void visit(TagAddress adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;area&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagArea)
	 */
	@Override
	public void visit(TagArea adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;article&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagArticle)
	 */
	@Override
	public void visit(TagArticle adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;aside&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagAside)
	 */
	@Override
	public void visit(TagAside adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;audio&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagAudio)
	 */
	@Override
	public void visit(TagAudio adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;b&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagB)
	 */
	@Override
	public void visit(TagB adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;base&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagBase)
	 */
	@Override
	public void visit(TagBase adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}

	/**
	 * Visit the <b>&lt;bdi&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagBdi)
	 */
	@Override
	public void visit(TagBdi adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;bdo&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagBdo)
	 */
	@Override
	public void visit(TagBdo adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	@Override
	public void visit(TagBig adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;blockquote&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagBlockquote)
	 */
	@Override
	public void visit(TagBlockquote adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;br&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagBr)
	 */
	@Override
	public void visit(TagBr adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;button&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagButton)
	 */
	@Override
	public void visit(TagButton adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;canvas&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagCanvas)
	 */
	@Override
	public void visit(TagCanvas adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;command&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagCommand)
	 */
	@Override
	public void visit(TagCommand adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;caption&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagCaption)
	 */
	@Override
	public void visit(TagCaption adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;center&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagCenter)
	 */
	@Override
	public void visit(TagCenter adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;cite&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagCite)
	 */
	@Override
	public void visit(TagCite adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;code&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagCode)
	 */
	@Override
	public void visit(TagCode adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;col&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagCol)
	 */
	@Override
	public void visit(TagCol adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;colgroup&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagColgroup)
	 */
	@Override
	public void visit(TagColgroup adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;datalist&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagDatalist)
	 */
	@Override
	public void visit(TagDatalist adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;dd&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagDd)
	 */
	@Override
	public void visit(TagDd adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;del&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagDel)
	 */
	@Override
	public void visit(TagDel adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;details&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagDetails)
	 */
	@Override
	public void visit(TagDetails adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;dfn&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagDfn)
	 */
	@Override
	public void visit(TagDfn adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;dialog&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagDialog)
	 */
	@Override
	public void visit(TagDialog adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;div&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagDiv)
	 */
	@Override
	public void visit(TagDiv adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;dl&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagDl)
	 */
	@Override
	public void visit(TagDl adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;dt&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagDt)
	 */
	@Override
	public void visit(TagDt adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;em&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagEm)
	 */
	@Override
	public void visit(TagEm adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;embed&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagEmbed)
	 */
	@Override
	public void visit(TagEmbed adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;fieldset&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagFieldset)
	 */
	@Override
	public void visit(TagFieldset adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;figcaption&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagFigcaption)
	 */
	@Override
	public void visit(TagFigcaption adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;figure&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagFigure)
	 */
	@Override
	public void visit(TagFigure adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;font&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagFont)
	 */
	@Override
	public void visit(TagFont adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;footer&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagFooter)
	 */
	@Override
	public void visit(TagFooter adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;form&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagForm)
	 */
	@Override
	public void visit(TagForm adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;h1&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagH1)
	 */
	@Override
	public void visit(TagH1 adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;h2&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagH2)
	 */
	@Override
	public void visit(TagH2 adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;h3&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagH3)
	 */
	@Override
	public void visit(TagH3 adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;h4&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagH4)
	 */
	@Override
	public void visit(TagH4 adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;h5&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagH5)
	 */
	@Override
	public void visit(TagH5 adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;h6&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagH6)
	 */
	@Override
	public void visit(TagH6 adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;head&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagHead)
	 */
	@Override
	public void visit(TagHead adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;header&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagHeader)
	 */
	@Override
	public void visit(TagHeader adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;hgroup&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagHgroup)
	 */
	@Override
	public void visit(TagHgroup adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;hr&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagHr)
	 */
	@Override
	public void visit(TagHr adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;i&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagI)
	 */
	@Override
	public void visit(TagI adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;iframe&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagIframe)
	 */
	@Override
	public void visit(TagIframe adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;img&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagImg)
	 */
	@Override
	public void visit(TagImg adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;input&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagInput)
	 */
	@Override
	public void visit(TagInput adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;ins&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagIns)
	 */
	@Override
	public void visit(TagIns adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;kbd&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagKbd)
	 */
	@Override
	public void visit(TagKbd adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;keygen&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagKeygen)
	 */
	@Override
	public void visit(TagKeygen adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;label&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagLabel)
	 */
	@Override
	public void visit(TagLabel adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;legend&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagLegend)
	 */
	@Override
	public void visit(TagLegend adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;li&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagLi)
	 */
	@Override
	public void visit(TagLi adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;link&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagLink)
	 */
	@Override
	public void visit(TagLink adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;main&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagMain)
	 */
	@Override
	public void visit(TagMain adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;map&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagMap)
	 */
	@Override
	public void visit(TagMap adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;mark&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagMark)
	 */
	@Override
	public void visit(TagMark adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;menu&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagMenu)
	 */
	@Override
	public void visit(TagMenu adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;menuitem&gt;</b> tag.
	 * @throws HtmlWalkerException 
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagMenuitem)
	 */
	@Override
	public void visit(TagMenuitem adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;meta&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagMeta)
	 */
	@Override
	public void visit(TagMeta adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;meter&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagMeter)
	 */
	@Override
	public void visit(TagMeter adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;nav&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagNav)
	 */
	@Override
	public void visit(TagNav adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;noscript&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagNoscript)
	 */
	@Override
	public void visit(TagNoscript adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;object&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagObject)
	 */
	@Override
	public void visit(TagObject adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;ol&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagOl)
	 */
	@Override
	public void visit(TagOl adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;optgroup&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagOptgroup)
	 */
	@Override
	public void visit(TagOptgroup adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;option&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagOption)
	 */
	@Override
	public void visit(TagOption adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;output&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagOutput)
	 */
	@Override
	public void visit(TagOutput adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;p&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagP)
	 */
	@Override
	public void visit(TagP adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;param&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagParam)
	 */
	@Override
	public void visit(TagParam adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}

	/**
	 * Visit the <b>&lt;picture&gt;</b> tag.
	 * @throws HtmlWalkerException 
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagPicture)
	 */
	@Override
	public void visit(TagPicture adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;pre&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagPre)
	 */
	@Override
	public void visit(TagPre adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;progress&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagProgress)
	 */
	@Override
	public void visit(TagProgress adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}

	/**
	 * Visit the <b>&lt;q&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagQ)
	 */
	@Override
	public void visit(TagQ adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;rp&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagRp)
	 */
	@Override
	public void visit(TagRp adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;rt&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagRt)
	 */
	@Override
	public void visit(TagRt adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;ruby&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagRuby)
	 */
	@Override
	public void visit(TagRuby adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;title&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTitle)
	 */
	@Override
	public void visit(TagTitle adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;s&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagS)
	 */
	@Override
	public void visit(TagS adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;samp&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagSamp)
	 */
	@Override
	public void visit(TagSamp adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;script&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagScript)
	 */
	@Override
	public void visit(TagScript adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}

	/**
	 * Visit the <b>&lt;section&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagSection)
	 */
	@Override
	public void visit(TagSection adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;select&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagSelect)
	 */
	@Override
	public void visit(TagSelect adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;small&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagSmall)
	 */
	@Override
	public void visit(TagSmall adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;source&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagSource)
	 */
	@Override
	public void visit(TagSource adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;span&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagSpan)
	 */
	@Override
	public void visit(TagSpan adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;strike&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagStrike)
	 */
	@Override
	public void visit(TagStrike adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;strong&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagStrong)
	 */
	@Override
	public void visit(TagStrong adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;style&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagStyle)
	 */
	@Override
	public void visit(TagStyle adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}
	
	/**
	 * Visit the <b>&lt;sub&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagSub)
	 */
	@Override
	public void visit(TagSub adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;summary&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagSummary)
	 */
	@Override
	public void visit(TagSummary adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;sup&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagSup)
	 */
	@Override
	public void visit(TagSup adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;tbody&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTbody)
	 */
	@Override
	public void visit(TagTbody adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;td&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTd)
	 */
	@Override
	public void visit(TagTd adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;textarea&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTextarea)
	 */
	@Override
	public void visit(TagTextarea adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}

	/**
	 * Visit the <b>&lt;tfoot&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTfoot)
	 */
	@Override
	public void visit(TagTfoot adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;th&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTh)
	 */
	@Override
	public void visit(TagTh adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;thead&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagThead)
	 */
	@Override
	public void visit(TagThead adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;time&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTime)
	 */
	@Override
	public void visit(TagTime adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;tr&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTr)
	 */
	@Override
	public void visit(TagTr adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;track&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTrack)
	 */
	@Override
	public void visit(TagTrack adapter) throws HtmlWalkerException
	{
		handle(adapter);
 	}	

	/**
	 * Visit the <b>&lt;tt&gt;</b> tag.
	 * @throws HtmlWalkerException 
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagTt)
	 */
	@Override
	public void visit(TagTt adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;u&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagU)
	 */
	@Override
	public void visit(TagU adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;ul&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagUl)
	 */
	@Override
	public void visit(TagUl adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;var&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagVar)
	 */
	@Override
	public void visit(TagVar adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}
	
	/**
	 * Visit the <b>&lt;video&gt;</b> tag and all its child tags.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagVideo)
	 */
	@Override
	public void visit(TagVideo adapter) throws HtmlWalkerException
	{
		start(adapter);
		walk(adapter);
		end(adapter);
	}

	/**
	 * Visit the <b>&lt;wbr&gt;</b> tag.
	 * 
	 * @see HtmlWalker.ITagVoidVisitor#visit(HtmlWalker.TagWbr)
	 */
	@Override
	public void visit(TagWbr adapter) throws HtmlWalkerException
	{
		handle(adapter);
	}	
}
