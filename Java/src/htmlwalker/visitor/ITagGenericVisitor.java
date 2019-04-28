/*
 * 
 */
package htmlwalker.visitor;

import htmlwalker.DocumentTag;
import htmlwalker.exception.*;
import htmlwalker.tag.html.*;
import htmlwalker.tag.util.*;

/**
 * This class provides the ability for users of the HtmlWalker package to use
 * the visitor pattern. Any class that implements this interface can then use
 * it with the full set of tag adapters.
 *
 * @param <T> - type returned by each <b>visit</b> method
 * 
 * @author Robert Flores
*/
public interface ITagGenericVisitor<T>
{

	public T visit(DocumentTag adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the text adapter
	 *
	 * @param text - the text adapter
	 * @return T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(Text adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the eol tag adapter
	 *
	 * @param eol - the eol tag adapter
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(Eol adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the eol tag adapter
	 *
	 * @param entity - the entity tag adapter
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(Entity adapter) throws HtmlWalkerException;

	public T visit(Comment adapter) throws HtmlWalkerException;
	
	public T visit(Unknown adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;a&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;a&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagA adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;abbr&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;abbr&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagAbbr adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;acronym&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;acronym&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagAcronym adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;address&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;address&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagAddress adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;area&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;area&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagArea adapter) throws HtmlWalkerException;   
	
	/**
	 * Visitor pattern method for the <b>&lt;article&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;article&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagArticle adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;aside&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;aside&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagAside adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;audio&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;audio&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagAudio adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;b&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;b&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagB adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;base&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;base&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagBase adapter) throws HtmlWalkerException;		
	
	/**
	 * Visitor pattern method for the <b>&lt;bdi&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;bdi&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagBdi adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;bdo&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;bdo&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagBdo adapter) throws HtmlWalkerException;
	
	public T visit(TagBig adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;blockquote&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;blockquote&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagBlockquote adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;body&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;body&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagBody adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;br&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;br&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagBr adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;button&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;button&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagButton adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;canvas&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;canvas&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagCanvas adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagCaption adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagCenter adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagCite adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagCode adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;col&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;col&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagCol adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;colgroup&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;colgroup&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagColgroup adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;command&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;command&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagCommand adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;datalist&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;datalist&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagDatalist adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;dd&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;dd&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagDd adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;del&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;del&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagDel adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;details&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;details&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagDetails adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;dfn&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;dfn&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagDfn adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;dialog&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;dialog&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagDialog adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;div&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;div&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagDiv adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;dl&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;dl&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagDl adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;dt&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;dt&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagDt adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;em&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;em&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagEm adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;embed&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;embed&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagEmbed adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;fieldset&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;fieldset&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagFieldset adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;figcaption&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;figcaption&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagFigcaption adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;figure&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;figure&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagFigure adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;font&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;font&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagFont adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;footer&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;footer&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagFooter adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;form&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;form&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagForm adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;h1&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;h1&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagH1 adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;h2&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;h2&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagH2 adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;h3&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;h3&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagH3 adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;h4&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;h4&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagH4 adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;h5&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;h5&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagH5 adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;h6&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;h6&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagH6 adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;head&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;head&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagHead adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;header&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;header&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagHeader adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;hgroup&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;hgroup&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagHgroup adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;hr&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;hr&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagHr adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;html&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;html&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagHtml adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;i&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;i&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagI adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;iframe&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;iframe&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagIframe adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;img&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;img&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagImg adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;input&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;input&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagInput adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;ins&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;ins&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagIns adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;kbd&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;kbd&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagKbd adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;keygen&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;keygen&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagKeygen adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;label&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;label&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagLabel adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;legend&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;legend&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagLegend adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;li&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;li&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagLi adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;link&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;link&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagLink adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;main&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;main&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagMain adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;map&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;map&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagMap adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;mark&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;mark&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagMark adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;menu&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;menu&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagMenu adapter) throws HtmlWalkerException;

	/**
	 * Visitor pattern method for the <b>&lt;menuitem&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;menuitem&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagMenuitem adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;meta&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;meta&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagMeta adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;meter&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;meter&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagMeter adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;nav&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;nav&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagNav adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;noscript&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;noscript&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagNoscript adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;object&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;object&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagObject adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;ol&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;ol&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagOl adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;optgroup&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;optgroup&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagOptgroup adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;option&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;option&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagOption adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;output&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;output&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagOutput adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;p&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;p&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagP adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;param&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;param&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagParam adapter) throws HtmlWalkerException;

	/**
	 * Visitor pattern method for the <b>&lt;picture&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;picture&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagPicture adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;pre&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;pre&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagPre adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;progress&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;progress&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagProgress adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;q&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;q&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagQ adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;rp&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;rp&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagRp adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;rt&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;rt&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagRt adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;ruby&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;ruby&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagRuby adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;s&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;s&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagS adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;samp&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;samp&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagSamp adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;script&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;script&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagScript adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;&sectiongt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;section&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagSection adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;select&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;select&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagSelect adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;small&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;small&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagSmall adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&ltsource;&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;source&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagSource adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;span&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;span&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagSpan adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;strike&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;strike&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagStrike adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;strong&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;strong&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagStrong adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;style&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;style&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagStyle adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;sub&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;sub&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagSub adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;summary&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;summary&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagSummary adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;sup&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;sup&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagSup adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;table&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;table&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTable adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;tbody&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;tbody&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTbody adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;td&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;td&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTd adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;textarea&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;textarea&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTextarea adapter) throws HtmlWalkerException;	
	
	/**
	 * Visitor pattern method for the <b>&lt;tfoot&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;tfoot&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTfoot adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;th&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;th&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTh adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;thead&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;thead&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagThead adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;time&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;time&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTime adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;title&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;title&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTitle adapter) throws HtmlWalkerException;	
	
	/**
	 * Visitor pattern method for the <b>&lt;tr&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;tr&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTr adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;track&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;track&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTrack adapter) throws HtmlWalkerException;

	/**
	 * Visitor pattern method for the <b>&lt;tt&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;tt&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagTt adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;u&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;u&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagU adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;ul&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;ul&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagUl adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;var&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;var&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagVar adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;video&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;video&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagVideo adapter) throws HtmlWalkerException;
	
	/**
	 * Visitor pattern method for the <b>&lt;wbr&gt;</b> tag adapter
	 *
	 * @param adapter - the <b>&lt;wbr&gt;</b> tag adapter
	 * @return the T
	 * @throws HtmlWalkerException the html walker exception
	 */
	public T visit(TagWbr adapter) throws HtmlWalkerException;
}
