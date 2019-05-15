package htmlwalker.visitor;

import htmlwalker.DocumentTag;
import htmlwalker.ITag;
import htmlwalker.core.DocGeneratorWalker;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.tag.html.*;
import htmlwalker.tag.util.Comment;
import htmlwalker.tag.util.Entity;
import htmlwalker.tag.util.Eol;
import htmlwalker.tag.util.Text;
import htmlwalker.tag.util.Unknown;

public class EchoModifier implements DocGeneratorWalker.IModifier
{

	@Override
	public ITag visit(DocumentTag adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(Text adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(Eol adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(Entity adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(Comment adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(Unknown adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagA adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagAbbr adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagAcronym adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagAddress adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagArea adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagArticle adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagAside adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagAudio adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagB adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagBase adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagBdi adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagBdo adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagBig adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagBlockquote adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagBody adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagBr adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagButton adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagCanvas adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagCaption adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagCenter adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagCite adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagCode adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagCol adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagColgroup adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagCommand adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagDatalist adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagDd adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagDel adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagDetails adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagDfn adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagDialog adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagDiv adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagDl adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagDt adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagEm adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagEmbed adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagFieldset adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagFigcaption adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagFigure adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagFont adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagFooter adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagForm adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagH1 adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagH2 adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagH3 adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagH4 adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagH5 adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagH6 adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagHead adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagHeader adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagHgroup adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagHr adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagHtml adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagI adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagIframe adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagImg adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagInput adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagIns adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagKbd adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagKeygen adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagLabel adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagLegend adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagLi adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagLink adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagMain adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagMap adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagMark adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagMenu adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagMenuitem adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagMeta adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagMeter adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagNav adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagNoscript adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagObject adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagOl adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagOptgroup adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagOption adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagOutput adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagP adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagParam adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagPicture adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagPre adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagProgress adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagQ adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagRp adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagRt adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagRuby adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagS adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagSamp adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagScript adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagSection adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagSelect adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagSmall adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagSource adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagSpan adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagStrike adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagStrong adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagStyle adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagSub adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagSummary adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagSup adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTable adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTbody adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTd adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTextarea adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTfoot adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTh adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagThead adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTime adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTitle adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTr adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTrack adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagTt adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagU adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagUl adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagVar adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagVideo adapter) throws HtmlWalkerException { return adapter;  }

	@Override
	public ITag visit(TagWbr adapter) throws HtmlWalkerException { return adapter;  }

}