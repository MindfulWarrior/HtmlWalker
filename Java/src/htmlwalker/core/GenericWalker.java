package htmlwalker.core;

import htmlwalker.DocumentTag;
import htmlwalker.ITag;
import htmlwalker.Walker;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.tag.html.*;
import htmlwalker.tag.util.Comment;
import htmlwalker.tag.util.Entity;
import htmlwalker.tag.util.Eol;
import htmlwalker.tag.util.Text;
import htmlwalker.tag.util.Unknown;

public abstract class GenericWalker extends Walker
{
	public GenericWalker() { super(); }

    protected abstract void startDocument(DocumentTag adapter) throws HtmlWalkerException;

    protected abstract void endDocument(DocumentTag adapter) throws HtmlWalkerException;

    protected abstract <T extends ITag> void handleTag(T adapter) throws HtmlWalkerException;

	/**
	 * This method is used to clone a tag adapter, add it to the current tag's content
	 * and then make the newly cloned tag adapter the current tag.
	 *
	 * @param adapter - the original tag adapter
	 */
    protected abstract <T extends ITag> void startTag(T adapter) throws HtmlWalkerException;

	/**
	 * This method returns the stack to the previous tag.
	 */
    protected abstract void endTag();

    /**
	 * Add a text string to the current tag's content.
	 *
	 * @param owner - (Not used)
	 * @param text - the text string
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handleContent(HtmlWalker.ITag, java.lang.String)
	 */
	@Override
	public void handle(Text adapter) throws HtmlWalkerException { handleTag(adapter); }
	/**
	 * Add a eol's to the current tag's content.
	 *
	 * @param owner - owner of the eol's
	 * @param count - number of eol's
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handleEol(HtmlWalker.ITag, int)
	 */
	@Override
	public void handle(Eol adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Add a text string to the current tag's content.
	 *
	 * @param owner - (Not used)
	 * @param text - the text string
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handleEntity(HtmlWalker.ITag, java.lang.Object)
	 */
	@Override
	public void handle(Entity adapter) throws HtmlWalkerException { handleTag(adapter); }

	@Override
	public void handle(Comment adapter) throws HtmlWalkerException { handleTag(adapter); }

	@Override
	public void handle(Unknown adapter)
	{
        throw new UnsupportedOperationException("Unknown -> " + adapter.name());
	}
	
	/**
	 * Sets the current <b>&lt;html&gt;</b> tag adapter.
	 * 
	 * If not yet set, clones the adapter given. Otherwise, the stack of tag
	 * is unwound to the one previously set. This has the affect of appending
	 * the child tags of the adapter given.
	 *
	 * @param adapter - the <b>&lt;html&gt;</b> tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagHtml)
	 */
	@Override
	public void start(TagHtml adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Does nothing.
	 * 
	 * Defined to satisfy the abstract Walker class and for future use.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagHtml)
	 */
	@Override
	public void end(TagHtml adapter) { endTag(); }

	/**
	 * Sets the current <b>&lt;head&gt;</b> tag adapter.
	 * 
	 * If not yet set, clones the adapter given. Otherwise, the stack of tag
	 * is unwound to the one previously set. This has the affect of appending
	 * the child tags of the adapter given.
	 *
	 * @param adapter - the <b>&lt;head&gt;</b> tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagHead)
	 */
	@Override
	public void start(TagHead adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;head&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagHead)
	 */
	@Override
	public void end(TagHead adapter) { endTag(); }

	/**
	 * Sets the current <b>&lt;body&gt;</b> tag adapter.
	 * 
	 * If not yet set, clones the adapter given. Otherwise, the stack of tag
	 * is unwound to the one previously set. This has the affect of appending
	 * the child tags of the adapter given.
	 *
	 * @param adapter - the <b>&lt;body&gt;</b> tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagBody)
	 */
	@Override
	public void start(TagBody adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;body&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagBody)
	 */
	@Override
	public void end(TagBody adapter) { endTag(); }

	
	/**
	 * Clones the given <b>&lt;area&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;area&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagArea)
	 */
	@Override
	public void handle(TagArea adapter) throws HtmlWalkerException { handleTag(adapter); }	

	/**
	 * Clones the given <b>&lt;base&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;base&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagBase)
	 */
	@Override
	public void handle(TagBase adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;br&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;br&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagBr)
	 */
	@Override
	public void handle(TagBr adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;embed&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;embed&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagEmbed)
	 */
	@Override
	public void handle(TagEmbed adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;hr&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;hr&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagHr)
	 */
	@Override
	public void handle(TagHr adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;img&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;img&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagImg)
	 */
	@Override
	public void handle(TagImg adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;input&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;input&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagInput)
	 */
	@Override
	public void handle(TagInput adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;link&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;ling&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagLink)
	 */
	@Override
	public void handle(TagLink adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;meta&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;meta&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagMeta)
	 */
	@Override
	public void handle(TagMeta adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;option&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;option&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagOption)
	 */
	@Override
	public void handle(TagOption adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;param&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;param&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagParam)
	 */
	@Override
	public void handle(TagParam adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;progress&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;progress&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagProgress)
	 */
	@Override
	public void handle(TagProgress adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;script&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;script&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagScript)
	 */
	@Override
	public void handle(TagScript adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;source&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;source&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagSource)
	 */
	@Override
	public void handle(TagSource adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;style&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;style&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagStyle)
	 */
	@Override
	public void handle(TagStyle adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;title&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;title&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagTitle)
	 */
	@Override
	public void handle(TagTitle adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;textarea&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;textarea&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagTextarea)
	 */
	@Override
	public void handle(TagTextarea adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;track&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;track&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagTrack)
	 */
	@Override
	public void handle(TagTrack adapter) throws HtmlWalkerException { handleTag(adapter); }

	/**
	 * Clones the given <b>&lt;wbr&gt;</b>tag adapter and adds it the current tags content.
	 *
	 * @param adapter - the <b>&lt;wbr&gt;</b>tag adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#handle(HtmlWalker.TagWbr)
	 */
	@Override
	public void handle(TagWbr adapter) throws HtmlWalkerException { handleTag(adapter); }

	public void start(DocumentTag adapter) throws HtmlWalkerException { startDocument(adapter); }
	
	public void end(DocumentTag adapter) throws HtmlWalkerException { endDocument(adapter); }

	/**
	 * Clones the given <b>&lt;a&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;a&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagA)
	 */
	@Override
	public void start(TagA adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;a&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagA)
	 */
	@Override
	public void end(TagA adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;abbr&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;abbr&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagAbbr)
	 */
	@Override
	public void start(TagAbbr adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;abbr&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagAbbr)
	 */
	@Override
	public void end(TagAbbr adapter) { endTag(); }
	
	/**
	 * Clones the given <b>&lt;acronym&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;acronym&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagVideo)
	 */
	@Override
	public void start(TagAcronym adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;acronym&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagVideo)
	 */
	@Override
	public void end(TagAcronym adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;address&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;address&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagAddress)
	 */
	@Override
	public void start(TagAddress adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;address&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagAddress)
	 */
	@Override
	public void end(TagAddress adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;article&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;article&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagArticle)
	 */
	@Override
	public void start(TagArticle adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;article&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagArticle)
	 */
	@Override
	public void end(TagArticle adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;aside&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;aside&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagAside)
	 */
	@Override
	public void start(TagAside adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;aside&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagAside)
	 */
	@Override
	public void end(TagAside adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;audio&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;audio&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagAudio)
	 */
	@Override
	public void start(TagAudio adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;audio&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagAudio)
	 */
	@Override
	public void end(TagAudio adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;b&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;b&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagB)
	 */
	@Override
	public void start(TagB adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;b&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagB)
	 */
	@Override
	public void end(TagB adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;bdi&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;bdi&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagBdi)
	 */
	@Override
	public void start(TagBdi adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;bdi&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagBdi)
	 */
	@Override
	public void end(TagBdi adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;bdo&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;bdo&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagBdo)
	 */
	@Override
	public void start(TagBdo adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;bdo&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagBdo)
	 */
	@Override
	public void end(TagBdo adapter) { endTag(); }
	
	@Override
	public void start(TagBig adapter) throws HtmlWalkerException { startTag(adapter); }
	
	@Override
	public void end(TagBig adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;blockquote&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;blockquote&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagBlockquote)
	 */
	@Override
	public void start(TagBlockquote adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;blockquote&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagBlockquote)
	 */
	@Override
	public void end(TagBlockquote adapter) { endTag(); }
	
	/**
	 * Clones the given <b>&lt;button&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;button&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagButton)
	 */
	@Override
	public void start(TagButton adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;button&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagButton)
	 */
	@Override
	public void end(TagButton adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;canvas&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;canvas&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagCanvas)
	 */
	@Override
	public void start(TagCanvas adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;canvas&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagCanvas)
	 */
	@Override
	public void end(TagCanvas adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;caption&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;caption&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagCaption)
	 */
	@Override
	public void start(TagCaption adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;caption&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagCaption)
	 */
	@Override
	public void end(TagCaption adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;center&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;center&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagCenter)
	 */
	@Override
	public void start(TagCenter adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;center&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagCenter)
	 */
	@Override
	public void end(TagCenter adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;cite&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;cite&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagCite)
	 */
	@Override
	public void start(TagCite adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;cite&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagCite)
	 */
	@Override
	public void end(TagCite adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;code&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;code&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagCode)
	 */
	@Override
	public void start(TagCode adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;code&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagCode)
	 */
	@Override
	public void end(TagCode adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;col&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;col&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagCol)
	 */
	@Override
	public void start(TagCol adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;col&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagCol)
	 */
	@Override
	public void end(TagCol adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;colgroup&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;colgroup&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagColgroup)
	 */
	@Override
	public void start(TagColgroup adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;colgroup&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagColgroup)
	 */
	@Override
	public void end(TagColgroup adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;command&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;command&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagCommand)
	 */
	@Override
	public void start(TagCommand adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;command&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagCommand)
	 */
	@Override
	public void end(TagCommand adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;datalist&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;datalist&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagDatalist)
	 */
	@Override
	public void start(TagDatalist adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;datalist&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagDatalist)
	 */
	@Override
	public void end(TagDatalist adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;dd&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;dd&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagDd)
	 */
	@Override
	public void start(TagDd adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;dd&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagDd)
	 */
	@Override
	public void end(TagDd adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;del&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;del&gt;</b> adapter
	 * @throws HtmlWalkerException 
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagDel)
	 */
	@Override
	public void start(TagDel adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;del&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagDel)
	 */
	@Override
	public void end(TagDel adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;details&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;details&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagDetails)
	 */
	@Override
	public void start(TagDetails adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;details&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagDetails)
	 */
	@Override
	public void end(TagDetails adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;dfn&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;dfn&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagDfn)
	 */
	@Override
	public void start(TagDfn adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;dfn&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagDfn)
	 */
	@Override
	public void end(TagDfn adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;dialog&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;dialog&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagDialog)
	 */
	@Override
	public void start(TagDialog adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;dialog&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagDialog)
	 */
	@Override
	public void end(TagDialog adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;div&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;div&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagDiv)
	 */
	@Override
	public void start(TagDiv adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;div&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagDiv)
	 */
	@Override
	public void end(TagDiv adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;dl&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;dl&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagDl)
	 */
	@Override
	public void start(TagDl adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;dl&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagDl)
	 */
	@Override
	public void end(TagDl adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;dt&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;dt&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagDt)
	 */
	@Override
	public void start(TagDt adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;dt&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagDt)
	 */
	@Override
	public void end(TagDt adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;em&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;em&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagEm)
	 */
	@Override
	public void start(TagEm adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;em&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagEm)
	 */
	@Override
	public void end(TagEm adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;fieldset&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;fieldset&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagFieldset)
	 */
	@Override
	public void start(TagFieldset adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;fieldset&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagFieldset)
	 */
	@Override
	public void end(TagFieldset adapter) { endTag(); }
	
	/**
	 * Clones the given <b>&lt;figcaption&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;figcaption&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagFigcaption)
	 */
	@Override
	public void start(TagFigcaption adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;figcaption&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagFigcaption)
	 */
	@Override
	public void end(TagFigcaption adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;figure&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;figure&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagFigure)
	 */
	@Override
	public void start(TagFigure adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;figure&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagFigure)
	 */
	@Override
	public void end(TagFigure adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;font&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;font&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagFont)
	 */
	@Override
	public void start(TagFont adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;font&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagFont)
	 */
	@Override
	public void end(TagFont adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;footer&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;footer&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagFooter)
	 */
	@Override
	public void start(TagFooter adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;footer&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagFooter)
	 */
	@Override
	public void end(TagFooter adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;header&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;header&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagHeader)
	 */
	@Override
	public void start(TagHeader adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;header&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagHeader)
	 */
	@Override
	public void end(TagHeader adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;hgroup&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;hgroup&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagHgroup)
	 */
	@Override
	public void start(TagHgroup adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;hgroup&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagHgroup)
	 */
	@Override
	public void end(TagHgroup adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;form&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;form&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagForm)
	 */
	@Override
	public void start(TagForm adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;form&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagForm)
	 */
	@Override
	public void end(TagForm adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;h1&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;h1&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagH1)
	 */
	@Override
	public void start(TagH1 adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;h1&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagH1)
	 */
	@Override
	public void end(TagH1 adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;h2&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;h2&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagH2)
	 */
	@Override
	public void start(TagH2 adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;h2&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagH2)
	 */
	@Override
	public void end(TagH2 adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;h3&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;h3&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagH3)
	 */
	@Override
	public void start(TagH3 adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;h3&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagH3)
	 */
	@Override
	public void end(TagH3 adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;h4&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;h4&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagH4)
	 */
	@Override
	public void start(TagH4 adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;h4&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagH4)
	 */
	@Override
	public void end(TagH4 adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;h5&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;h5&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagH5)
	 */
	@Override
	public void start(TagH5 adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;h5&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagH5)
	 */
	@Override
	public void end(TagH5 adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;h6&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;h6&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagH6)
	 */
	@Override
	public void start(TagH6 adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;h6&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagH6)
	 */
	@Override
	public void end(TagH6 adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;i&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;i&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagI)
	 */
	@Override
	public void start(TagI adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;i&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagI)
	 */
	@Override
	public void end(TagI adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;iframe&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;iframe&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagIframe)
	 */
	@Override
	public void start(TagIframe adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;iframe&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagIframe)
	 */
	@Override
	public void end(TagIframe adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;ins&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;ins&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagIns)
	 */
	@Override
	public void start(TagIns adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;ins&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagIns)
	 */
	@Override
	public void end(TagIns adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;kbd&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;kbd&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagKbd)
	 */
	@Override
	public void start(TagKbd adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;kbd&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagKbd)
	 */
	@Override
	public void end(TagKbd adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;keygen&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagKeygen)
	 */
	@Override
	public void start(TagKeygen adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;keygen&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagKeygen)
	 */
	@Override
	public void end(TagKeygen adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;label&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;label&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagLabel)
	 */
	@Override
	public void start(TagLabel adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;label&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagLabel)
	 */
	@Override
	public void end(TagLabel adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;legend&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;legend&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagLegend)
	 */
	@Override
	public void start(TagLegend adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;legend&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagLegend)
	 */
	@Override
	public void end(TagLegend adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;li&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;li&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagLi)
	 */
	@Override
	public void start(TagLi adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;li&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagLi)
	 */
	@Override
	public void end(TagLi adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;main&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;main&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagMain)
	 */
	@Override
	public void start(TagMain adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;main&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagMain)
	 */
	@Override
	public void end(TagMain adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;map&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;map&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagMap)
	 */
	@Override
	public void start(TagMap adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;map&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagMap)
	 */
	@Override
	public void end(TagMap adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;mark&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;mark&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagMark)
	 */
	@Override
	public void start(TagMark adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;mark&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagMark)
	 */
	@Override
	public void end(TagMark adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;menu&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;menu&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagMenu)
	 */
	@Override
	public void start(TagMenu adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;menu&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagMenu)
	 */
	@Override
	public void end(TagMenu adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;menuitem&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;menuitem&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagVideo)
	 */
	@Override
	public void start(TagMenuitem adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;menuitem&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagVideo)
	 */
	@Override
	public void end(TagMenuitem adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;meter&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;meter&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagMeter)
	 */
	@Override
	public void start(TagMeter adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;meter&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagMeter)
	 */
	@Override
	public void end(TagMeter adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;nav&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;nav&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagNav)
	 */
	@Override
	public void start(TagNav adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;nav&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagNav)
	 */
	@Override
	public void end(TagNav adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;noscript&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;nnoscript&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagNoscript)
	 */
	@Override
	public void start(TagNoscript adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;noscript&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagNoscript)
	 */
	@Override
	public void end(TagNoscript adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;object&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;object&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagObject)
	 */
	@Override
	public void start(TagObject adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;object&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagObject)
	 */
	@Override
	public void end(TagObject adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;ol&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;ol&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagOl)
	 */
	@Override
	public void start(TagOl adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;ol&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagOl)
	 */
	@Override
	public void end(TagOl adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;optgroup&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;optgroup&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagOptgroup)
	 */
	@Override
	public void start(TagOptgroup adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;optgroup&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagOptgroup)
	 */
	@Override
	public void end(TagOptgroup adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;output&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;output&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagOutput)
	 */
	@Override
	public void start(TagOutput adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;output&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagOutput)
	 */
	@Override
	public void end(TagOutput adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;p&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;p&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagP)
	 */
	@Override
	public void start(TagP adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;p&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagP)
	 */
	@Override
	public void end(TagP adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;picture&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;picture&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagVideo)
	 */
	@Override
	public void start(TagPicture adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;picture&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagVideo)
	 */
	@Override
	public void end(TagPicture adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;pre&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;pre&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagPre)
	 */
	@Override
	public void start(TagPre adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;pre&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagPre)
	 */
	@Override
	public void end(TagPre adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;q&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;q&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagQ)
	 */
	@Override
	public void start(TagQ adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;q&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagQ)
	 */
	@Override
	public void end(TagQ adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;rp&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;rp&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagRp)
	 */
	@Override
	public void start(TagRp adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;rp&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagRp)
	 */
	@Override
	public void end(TagRp adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;rt&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;rt&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagRt)
	 */
	@Override
	public void start(TagRt adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;rt&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagRt)
	 */
	@Override
	public void end(TagRt adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;ruby&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;ruby&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagRuby)
	 */
	@Override
	public void start(TagRuby adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;ruby&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagRuby)
	 */
	@Override
	public void end(TagRuby adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;s&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;s&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagS)
	 */
	@Override
	public void start(TagS adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;s&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagS)
	 */
	@Override
	public void end(TagS adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;samp&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;samp&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagSamp)
	 */
	@Override
	public void start(TagSamp adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;samp&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagSamp)
	 */
	@Override
	public void end(TagSamp adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;section&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;section&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagSection)
	 */
	@Override
	public void start(TagSection adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;section&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagSection)
	 */
	@Override
	public void end(TagSection adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;select&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;select&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagSelect)
	 */
	@Override
	public void start(TagSelect adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;select&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagSelect)
	 */
	@Override
	public void end(TagSelect adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;small&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;small&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagSmall)
	 */
	@Override
	public void start(TagSmall adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;small&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagSmall)
	 */
	@Override
	public void end(TagSmall adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;span&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;span&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagSpan)
	 */
	@Override
	public void start(TagSpan adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;span&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagSpan)
	 */
	@Override
	public void end(TagSpan adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;strike&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;strike&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagStrike)
	 */
	@Override
	public void start(TagStrike adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;strike&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagStrike)
	 */
	@Override
	public void end(TagStrike adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;strong&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;strong&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagStrong)
	 */
	@Override
	public void start(TagStrong adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;strong&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagStrong)
	 */
	@Override
	public void end(TagStrong adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;sub&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;sub&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagSub)
	 */
	@Override
	public void start(TagSub adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;sub&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagSub)
	 */
	@Override
	public void end(TagSub adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;summary&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;summary&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagSummary)
	 */
	@Override
	public void start(TagSummary adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;summary&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagSummary)
	 */
	@Override
	public void end(TagSummary adapter) { endTag(); }	
	
	/**
	 * Clones the given <b>&lt;sup&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;sup&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagSup)
	 */
	@Override
	public void start(TagSup adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;sup&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagSup)
	 */
	@Override
	public void end(TagSup adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;table&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;table&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagTable)
	 */
	@Override
	public void start(TagTable adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;table&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagTable)
	 */
	@Override
	public void end(TagTable adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;tbody&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;tbody&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagTbody)
	 */
	@Override
	public void start(TagTbody adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;tbody&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagTbody)
	 */
	@Override
	public void end(TagTbody adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;td&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;td&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagTd)
	 */
	@Override
	public void start(TagTd adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;td&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagTd)
	 */
	@Override
	public void end(TagTd adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;tfoot&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;tfoot&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagTfoot)
	 */
	@Override
	public void start(TagTfoot adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;tfoot&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagTfoot)
	 */
	@Override
	public void end(TagTfoot adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;th&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;th&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagTh)
	 */
	@Override
	public void start(TagTh adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;th&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagTh)
	 */
	@Override
	public void end(TagTh adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;thead&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;thead&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagThead)
	 */
	@Override
	public void start(TagThead adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;thead&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagThead)
	 */
	@Override
	public void end(TagThead adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;time&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;time&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagTime)
	 */
	@Override
	public void start(TagTime adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;time&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagTime)
	 */
	@Override
	public void end(TagTime adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;tr&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;tr&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagTr)
	 */
	@Override
	public void start(TagTr adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;tr&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagTr)
	 */
	@Override
	public void end(TagTr adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;tt&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;tt&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagVideo)
	 */
	@Override
	public void start(TagTt adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;tt&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagVideo)
	 */
	@Override
	public void end(TagTt adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;u&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;u&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagU)
	 */
	@Override
	public void start(TagU adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;u&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagU)
	 */
	@Override
	public void end(TagU adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;ul&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;ul&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagUl)
	 */
	@Override
	public void start(TagUl adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;ul&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagUl)
	 */
	@Override
	public void end(TagUl adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;var&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;var&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagVar)
	 */
	@Override
	public void start(TagVar adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;var&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagVar)
	 */
	@Override
	public void end(TagVar adapter) { endTag(); }

	/**
	 * Clones the given <b>&lt;video&gt;</b> tag adapter and set it as the current tag.
	 *
	 * @param adapter - the <b>&lt;video&gt;</b> adapter
	 * @see HtmlWalker.Walker#start(HtmlWalker.TagVideo)
	 */
	@Override
	public void start(TagVideo adapter) throws HtmlWalkerException { startTag(adapter); }

	/**
	 * Closes the <b>&lt;video&gt;</b> tag.
	 *
	 * @param adapter - (Not used. May so in the future)
	 * @see HtmlWalker.Walker#end(HtmlWalker.TagVideo)
	 */
	@Override
	public void end(TagVideo adapter) { endTag(); }
}
