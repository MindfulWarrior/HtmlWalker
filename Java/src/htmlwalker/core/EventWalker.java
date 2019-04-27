/**
 * 
 */
package htmlwalker.core;

import java.util.ArrayList;
import java.util.List;

import htmlwalker.DocumentTag;
import htmlwalker.ITag;
import htmlwalker.Walker;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.exception.TagNotSupportedException;
import htmlwalker.tag.html.*;
import htmlwalker.tag.util.Comment;
import htmlwalker.tag.util.Entity;
import htmlwalker.tag.util.Eol;
import htmlwalker.tag.util.Text;
import htmlwalker.tag.util.Unknown;

/**
 * @author Robert Flores
 *
 */
public class EventWalker extends Walker
{
	public interface IEventHandler
	{
		void invoke(ITag adapter);
	}
	
    public final List<IEventHandler> startDocumentHandlers = new ArrayList<IEventHandler>();
    public final List<IEventHandler> endDocumentHandlers = new ArrayList<IEventHandler>();

    public final List<IEventHandler> startTagHandlers = new ArrayList<IEventHandler>();
    public final List<IEventHandler> endTagHandlers = new ArrayList<IEventHandler>();

    public final List<IEventHandler> tagHandlers = new ArrayList<IEventHandler>();

    public EventWalker() { super(); }

	protected void onStartDocument(DocumentTag adapter)
	{
		for (IEventHandler handler : startDocumentHandlers)
			handler.invoke(adapter);
	}

	protected void onEndDocument(DocumentTag adapter)
	{
		for (IEventHandler handler : endDocumentHandlers)
			handler.invoke(adapter);
	}

	protected void onStartTag(ITag adapter)
	{
		for (IEventHandler handler : startTagHandlers)
			handler.invoke(adapter);
	}

	protected void onEndTag(ITag adapter)
	{
		for (IEventHandler handler : endTagHandlers)
			handler.invoke(adapter);
	}

	protected void onTag(ITag adapter)
	{
		for (IEventHandler handler : tagHandlers)
			handler.invoke(adapter);
	}

	@Override
	public void handle(Text adapter) { onTag(adapter); }

	@Override
	public void handle(Eol adapter) { onTag(adapter); }

	@Override
	public void handle(Comment adapter) { onTag(adapter); }

	@Override
	public void handle(Entity adapter) { onTag(adapter); }

	@Override
	public void handle(Unknown adapter) throws HtmlWalkerException
	{
		// TODO: Do throw exception and let event handlers do it.
		throw new TagNotSupportedException(adapter);	
	}

	@Override
	public void handle(TagArea adapter) { onTag(adapter); }

	@Override
	public void handle(TagBase adapter) { onTag(adapter); }

	@Override
	public void handle(TagBr adapter) { onTag(adapter); }

	@Override
	public void handle(TagEmbed adapter) { onTag(adapter); }

	@Override
	public void handle(TagHr adapter) { onTag(adapter); }

	@Override
	public void handle(TagImg adapter) { onTag(adapter); }

	@Override
	public void handle(TagInput adapter) { onTag(adapter); }

	@Override
	public void handle(TagLink adapter) { onTag(adapter); }

	@Override
	public void handle(TagMeta adapter) { onTag(adapter); }

	@Override
	public void handle(TagOption adapter) { onTag(adapter); }

	@Override
	public void handle(TagParam adapter) { onTag(adapter); }

	@Override
	public void handle(TagProgress adapter) { onTag(adapter); }

	@Override
	public void handle(TagScript adapter) { onTag(adapter); }

	@Override
	public void handle(TagSource adapter) { onTag(adapter); }

	@Override
	public void handle(TagStyle adapter) { onTag(adapter); }

	@Override
	public void handle(TagTextarea adapter) { onTag(adapter); }

	@Override
	public void handle(TagTitle adapter) { onTag(adapter); }

	@Override
	public void handle(TagTrack adapter) { onTag(adapter); }

	@Override
	public void handle(TagWbr adapter) { onTag(adapter); }

	@Override
	public void start(DocumentTag adapter) { onStartDocument(adapter); }

	@Override
	public void end(DocumentTag adapter) { onEndDocument(adapter); }

	@Override
	public void start(TagA adapter) { onStartTag(adapter); }

	@Override
	public void end(TagA adapter) { onEndTag(adapter); }

	@Override
	public void start(TagAbbr adapter) { onStartTag(adapter); }

	@Override
	public void end(TagAbbr adapter) { onEndTag(adapter); }

	@Override
	public void start(TagAcronym adapter) { onStartTag(adapter); }

	@Override
	public void end(TagAcronym adapter) { onEndTag(adapter); }

	@Override
	public void start(TagAddress adapter) { onStartTag(adapter); }

	@Override
	public void end(TagAddress adapter) { onEndTag(adapter); }

	@Override
	public void start(TagArticle adapter) { onStartTag(adapter); }

	@Override
	public void end(TagArticle adapter) { onEndTag(adapter); }

	@Override
	public void start(TagAside adapter) { onStartTag(adapter); }

	@Override
	public void end(TagAside adapter) { onEndTag(adapter); }

	@Override
	public void start(TagAudio adapter) { onStartTag(adapter); }

	@Override
	public void end(TagAudio adapter) { onEndTag(adapter); }

	@Override
	public void start(TagB adapter) { onStartTag(adapter); }

	@Override
	public void end(TagB adapter) { onEndTag(adapter); }

	@Override
	public void start(TagBdi adapter) { onStartTag(adapter); }

	@Override
	public void end(TagBdi adapter) { onEndTag(adapter); }

	@Override
	public void start(TagBdo adapter) { onStartTag(adapter); }

	@Override
	public void start(TagBig adapter) { onStartTag(adapter); }

	@Override
	public void end(TagBig adapter) { onEndTag(adapter); }

	@Override
	public void end(TagBdo adapter) { onEndTag(adapter); }

	@Override
	public void start(TagBlockquote adapter) { onStartTag(adapter); }

	@Override
	public void end(TagBlockquote adapter) { onEndTag(adapter); }

	@Override
	public void start(TagBody adapter) { onStartTag(adapter); }

	@Override
	public void end(TagBody adapter) { onEndTag(adapter); }

	@Override
	public void start(TagButton adapter) { onStartTag(adapter); }

	@Override
	public void end(TagButton adapter) { onEndTag(adapter); }

	@Override
	public void start(TagCanvas adapter) { onStartTag(adapter); }

	@Override
	public void end(TagCanvas adapter) { onEndTag(adapter); }

	@Override
	public void start(TagCaption adapter) { onStartTag(adapter); }

	@Override
	public void end(TagCaption adapter) { onEndTag(adapter); }

	@Override
	public void start(TagCite adapter) { onStartTag(adapter); }

	@Override
	public void end(TagCite adapter) { onEndTag(adapter); }

	@Override
	public void start(TagCenter adapter) { onStartTag(adapter); }

	@Override
	public void end(TagCenter adapter) { onEndTag(adapter); }

	@Override
	public void start(TagCode adapter) { onStartTag(adapter); }

	@Override
	public void end(TagCode adapter) { onEndTag(adapter); }

	@Override
	public void start(TagCol adapter) { onStartTag(adapter); }

	@Override
	public void end(TagCol adapter) { onEndTag(adapter); }

	@Override
	public void start(TagColgroup adapter) { onStartTag(adapter); }

	@Override
	public void end(TagColgroup adapter) { onEndTag(adapter); }

	@Override
	public void start(TagCommand adapter) { onStartTag(adapter); }

	@Override
	public void end(TagCommand adapter) { onEndTag(adapter); }

	@Override
	public void start(TagDatalist adapter) { onStartTag(adapter); }

	@Override
	public void end(TagDatalist adapter) { onEndTag(adapter); }

	@Override
	public void start(TagDetails adapter) { onStartTag(adapter); }

	@Override
	public void end(TagDetails adapter) { onEndTag(adapter); }

	@Override
	public void start(TagDel adapter) { onStartTag(adapter); }

	@Override
	public void end(TagDel adapter) { onEndTag(adapter); }

	@Override
	public void start(TagDfn adapter) { onStartTag(adapter); }

	@Override
	public void end(TagDfn adapter) { onEndTag(adapter); }

	@Override
	public void start(TagDialog adapter) { onStartTag(adapter); }

	@Override
	public void end(TagDialog adapter) { onEndTag(adapter); }

	@Override
	public void start(TagDl adapter) { onStartTag(adapter); }

	@Override
	public void end(TagDl adapter) { onEndTag(adapter); }

	@Override
	public void start(TagDt adapter) { onStartTag(adapter); }

	@Override
	public void end(TagDt adapter) { onEndTag(adapter); }

	@Override
	public void start(TagDd adapter) { onStartTag(adapter); }

	@Override
	public void end(TagDd adapter) { onEndTag(adapter); }

	@Override
	public void start(TagDiv adapter) { onStartTag(adapter); }

	@Override
	public void end(TagDiv adapter) { onEndTag(adapter); }

	@Override
	public void start(TagEm adapter) { onStartTag(adapter); }

	@Override
	public void end(TagEm adapter) { onEndTag(adapter); }

	@Override
	public void start(TagFieldset adapter) { onStartTag(adapter); }

	@Override
	public void end(TagFieldset adapter) { onEndTag(adapter); }

	@Override
	public void start(TagFigcaption adapter) { onStartTag(adapter); }

	@Override
	public void end(TagFigcaption adapter) { onEndTag(adapter); }

	@Override
	public void start(TagFigure adapter) { onStartTag(adapter); }

	@Override
	public void end(TagFigure adapter) { onEndTag(adapter); }

	@Override
	public void start(TagFont adapter) { onStartTag(adapter); }

	@Override
	public void end(TagFont adapter) { onEndTag(adapter); }

	@Override
	public void start(TagFooter adapter) { onStartTag(adapter); }

	@Override
	public void end(TagFooter adapter) { onEndTag(adapter); }

	@Override
	public void start(TagForm adapter) { onStartTag(adapter); }

	@Override
	public void end(TagForm adapter) { onEndTag(adapter); }

	@Override
	public void start(TagH1 adapter) { onStartTag(adapter); }

	@Override
	public void end(TagH1 adapter) { onEndTag(adapter); }

	@Override
	public void start(TagH2 adapter) { onStartTag(adapter); }

	@Override
	public void end(TagH2 adapter) { onEndTag(adapter); }

	@Override
	public void start(TagH3 adapter) { onStartTag(adapter); }

	@Override
	public void end(TagH3 adapter) { onEndTag(adapter); }

	@Override
	public void start(TagH4 adapter) { onStartTag(adapter); }

	@Override
	public void end(TagH4 adapter) { onEndTag(adapter); }

	@Override
	public void start(TagH5 adapter) { onStartTag(adapter); }

	@Override
	public void end(TagH5 adapter) { onEndTag(adapter); }

	@Override
	public void start(TagH6 adapter) { onStartTag(adapter); }

	@Override
	public void end(TagH6 adapter) { onEndTag(adapter); }

	@Override
	public void start(TagHead adapter) { onStartTag(adapter); }

	@Override
	public void end(TagHead adapter) { onEndTag(adapter); }

	@Override
	public void start(TagHeader adapter) { onStartTag(adapter); }

	@Override
	public void end(TagHeader adapter) { onEndTag(adapter); }

	@Override
	public void start(TagHgroup adapter) { onStartTag(adapter); }

	@Override
	public void end(TagHgroup adapter) { onEndTag(adapter); }

	@Override
	public void start(TagHtml adapter) { onStartTag(adapter); }

	@Override
	public void end(TagHtml adapter) { onEndTag(adapter); }

	@Override
	public void start(TagI adapter) { onStartTag(adapter); }

	@Override
	public void end(TagI adapter) { onEndTag(adapter); }

	@Override
	public void start(TagIframe adapter) { onStartTag(adapter); }

	@Override
	public void end(TagIframe adapter) { onEndTag(adapter); }

	@Override
	public void start(TagIns adapter) { onStartTag(adapter); }

	@Override
	public void end(TagIns adapter) { onEndTag(adapter); }

	@Override
	public void start(TagKbd adapter) { onStartTag(adapter); }

	@Override
	public void end(TagKbd adapter) { onEndTag(adapter); }

	@Override
	public void start(TagKeygen adapter) { onStartTag(adapter); }

	@Override
	public void end(TagKeygen adapter) { onEndTag(adapter); }

	@Override
	public void start(TagLabel adapter) { onStartTag(adapter); }

	@Override
	public void end(TagLabel adapter) { onEndTag(adapter); }

	@Override
	public void start(TagLegend adapter) { onStartTag(adapter); }

	@Override
	public void end(TagLegend adapter) { onEndTag(adapter); }

	@Override
	public void start(TagLi adapter) { onStartTag(adapter); }

	@Override
	public void end(TagLi adapter) { onEndTag(adapter); }

	@Override
	public void start(TagMain adapter) { onStartTag(adapter); }

	@Override
	public void end(TagMain adapter) { onEndTag(adapter); }

	@Override
	public void start(TagMap adapter) { onStartTag(adapter); }

	@Override
	public void end(TagMap adapter) { onEndTag(adapter); }

	@Override
	public void start(TagMark adapter) { onStartTag(adapter); }

	@Override
	public void end(TagMark adapter) { onEndTag(adapter); }

	@Override
	public void start(TagMenu adapter) { onStartTag(adapter); }

	@Override
	public void end(TagMenu adapter) { onEndTag(adapter); }

	@Override
	public void start(TagMenuitem adapter) { onStartTag(adapter); }

	@Override
	public void end(TagMenuitem adapter) { onEndTag(adapter); }

	@Override
	public void start(TagMeter adapter) { onStartTag(adapter); }

	@Override
	public void end(TagMeter adapter) { onEndTag(adapter); }

	@Override
	public void start(TagNav adapter) { onStartTag(adapter); }

	@Override
	public void end(TagNav adapter) { onEndTag(adapter); }

	@Override
	public void start(TagNoscript adapter) { onStartTag(adapter); }

	@Override
	public void end(TagNoscript adapter) { onEndTag(adapter); }

	@Override
	public void start(TagObject adapter) { onStartTag(adapter); }

	@Override
	public void end(TagObject adapter) { onEndTag(adapter); }

	@Override
	public void start(TagOl adapter) { onStartTag(adapter); }

	@Override
	public void end(TagOl adapter) { onEndTag(adapter); }

	@Override
	public void start(TagOptgroup adapter) { onStartTag(adapter); }

	@Override
	public void end(TagOptgroup adapter) { onEndTag(adapter); }

	@Override
	public void start(TagOutput adapter) { onStartTag(adapter); }

	@Override
	public void end(TagOutput adapter) { onEndTag(adapter); }

	@Override
	public void start(TagP adapter) { onStartTag(adapter); }

	@Override
	public void end(TagP adapter) { onEndTag(adapter); }

	@Override
	public void start(TagPicture adapter) { onStartTag(adapter); }

	@Override
	public void end(TagPicture adapter) { onEndTag(adapter); }

	@Override
	public void start(TagPre adapter) { onStartTag(adapter); }

	@Override
	public void end(TagPre adapter) { onEndTag(adapter); }

	@Override
	public void start(TagQ adapter) { onStartTag(adapter); }

	@Override
	public void end(TagQ adapter) { onEndTag(adapter); }

	@Override
	public void start(TagRp adapter) { onStartTag(adapter); }

	@Override
	public void end(TagRp adapter) { onEndTag(adapter); }

	@Override
	public void start(TagRt adapter) { onStartTag(adapter); }

	@Override
	public void end(TagRt adapter) { onEndTag(adapter); }

	@Override
	public void start(TagRuby adapter) { onStartTag(adapter); }

	@Override
	public void end(TagRuby adapter) { onEndTag(adapter); }

	@Override
	public void start(TagS adapter) { onStartTag(adapter); }

	@Override
	public void end(TagS adapter) { onEndTag(adapter); }

	@Override
	public void start(TagSelect adapter) { onStartTag(adapter); }

	@Override
	public void end(TagSelect adapter) { onEndTag(adapter); }

	@Override
	public void start(TagSamp adapter) { onStartTag(adapter); }

	@Override
	public void end(TagSamp adapter) { onEndTag(adapter); }

	@Override
	public void start(TagSection adapter) { onStartTag(adapter); }

	@Override
	public void end(TagSection adapter) { onEndTag(adapter); }

	@Override
	public void start(TagSmall adapter) { onStartTag(adapter); }

	@Override
	public void end(TagSmall adapter) { onEndTag(adapter); }

	@Override
	public void start(TagSpan adapter) { onStartTag(adapter); }

	@Override
	public void end(TagSpan adapter) { onEndTag(adapter); }

	@Override
	public void start(TagStrike adapter) { onStartTag(adapter); }

	@Override
	public void end(TagStrike adapter) { onEndTag(adapter); }

	@Override
	public void start(TagStrong adapter) { onStartTag(adapter); }

	@Override
	public void end(TagStrong adapter) { onEndTag(adapter); }

	@Override
	public void start(TagSub adapter) { onStartTag(adapter); }

	@Override
	public void end(TagSub adapter) { onEndTag(adapter); }

	@Override
	public void start(TagSummary adapter) { onStartTag(adapter); }

	@Override
	public void end(TagSummary adapter) { onEndTag(adapter); }

	@Override
	public void start(TagSup adapter) { onStartTag(adapter); }

	@Override
	public void end(TagSup adapter) { onEndTag(adapter); }

	@Override
	public void start(TagTable adapter) { onStartTag(adapter); }

	@Override
	public void end(TagTable adapter) { onEndTag(adapter); }

	@Override
	public void start(TagTbody adapter) { onStartTag(adapter); }

	@Override
	public void end(TagTbody adapter) { onEndTag(adapter); }

	@Override
	public void start(TagTd adapter) { onStartTag(adapter); }

	@Override
	public void end(TagTd adapter) { onEndTag(adapter); }

	@Override
	public void start(TagTfoot adapter) { onStartTag(adapter); }

	@Override
	public void end(TagTfoot adapter) { onEndTag(adapter); }

	@Override
	public void start(TagTh adapter) { onStartTag(adapter); }

	@Override
	public void end(TagTh adapter) { onEndTag(adapter); }

	@Override
	public void start(TagThead adapter) { onStartTag(adapter); }

	@Override
	public void end(TagThead adapter) { onEndTag(adapter); }

	@Override
	public void start(TagTime adapter) { onStartTag(adapter); }

	@Override
	public void end(TagTime adapter) { onEndTag(adapter); }

	@Override
	public void start(TagTr adapter) { onStartTag(adapter); }

	@Override
	public void end(TagTr adapter) { onEndTag(adapter); }

	@Override
	public void start(TagTt adapter) { onStartTag(adapter); }

	@Override
	public void end(TagTt adapter) { onEndTag(adapter); }

	@Override
	public void start(TagU adapter) { onStartTag(adapter); }

	@Override
	public void end(TagU adapter) { onEndTag(adapter); }

	@Override
	public void start(TagUl adapter) { onStartTag(adapter); }

	@Override
	public void end(TagUl adapter) { onEndTag(adapter); }

	@Override
	public void start(TagVar adapter) { onStartTag(adapter); }

	@Override
	public void end(TagVar adapter) { onEndTag(adapter); }

	@Override
	public void start(TagVideo adapter) { onStartTag(adapter); }

	@Override
	public void end(TagVideo adapter) { onEndTag(adapter); }

}
