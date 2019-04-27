package htmlwalker;

import java.util.ArrayList;
import java.util.List;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.tag.html.*;
import htmlwalker.tag.util.Comment;
import htmlwalker.tag.util.Entity;
import htmlwalker.tag.util.Eol;
import htmlwalker.tag.util.Text;
import htmlwalker.tag.util.Unknown;

public class JoinedWalker extends Walker
{
    public final List<IWalker> walkers = new ArrayList<IWalker>();

    public JoinedWalker() { super(); }

	@Override
	public void start(DocumentTag adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

    @Override
    public void end(DocumentTag adapter) throws HtmlWalkerException
    {
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
    }

	@Override
	public void handle(Text adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(Eol adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(Comment adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(Entity adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(Unknown adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagArea adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagBase adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagBr adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagEmbed adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagHr adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagImg adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagInput adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagLink adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagMeta adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagOption adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagParam adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagProgress adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagScript adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagSource adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagStyle adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagTextarea adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagTitle adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagTrack adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void handle(TagWbr adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).handle(adapter);
	}

	@Override
	public void start(TagA adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagA adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagAbbr adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagAbbr adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagAcronym adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagAcronym adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagAddress adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagAddress adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagArticle adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagArticle adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagAside adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagAside adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagAudio adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagAudio adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagB adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagB adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagBdi adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagBdi adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagBdo adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void start(TagBig adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagBig adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void end(TagBdo adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagBlockquote adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagBlockquote adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagBody adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagBody adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagButton adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagButton adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagCanvas adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagCanvas adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagCaption adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagCaption adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagCite adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagCite adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagCenter adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagCenter adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagCode adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagCode adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagCol adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagCol adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagColgroup adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagColgroup adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagCommand adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagCommand adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagDatalist adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagDatalist adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagDetails adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagDetails adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagDel adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagDel adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagDfn adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagDfn adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagDialog adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagDialog adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagDl adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagDl adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagDt adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagDt adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagDd adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagDd adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagDiv adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagDiv adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagEm adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagEm adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagFieldset adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagFieldset adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagFigcaption adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagFigcaption adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagFigure adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagFigure adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagFont adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagFont adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagFooter adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagFooter adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagForm adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagForm adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagH1 adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagH1 adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagH2 adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagH2 adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagH3 adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagH3 adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagH4 adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagH4 adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagH5 adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagH5 adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagH6 adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagH6 adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagHead adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagHead adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagHeader adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagHeader adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagHgroup adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagHgroup adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagHtml adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagHtml adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagI adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagI adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagIframe adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagIframe adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagIns adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagIns adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagKbd adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagKbd adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagKeygen adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagKeygen adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagLabel adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagLabel adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagLegend adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagLegend adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagLi adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagLi adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagMain adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagMain adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagMap adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagMap adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagMark adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagMark adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagMenu adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagMenu adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagMenuitem adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagMenuitem adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagMeter adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagMeter adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagNav adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagNav adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagNoscript adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagNoscript adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagObject adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagObject adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagOl adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagOl adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagOptgroup adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagOptgroup adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagOutput adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagOutput adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagP adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagP adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagPicture adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagPicture adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagPre adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagPre adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagQ adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagQ adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagRp adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagRp adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagRt adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagRt adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagRuby adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagRuby adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagS adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagS adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagSelect adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagSelect adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagSamp adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagSamp adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagSection adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagSection adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagSmall adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagSmall adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagSpan adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagSpan adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagStrike adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagStrike adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagStrong adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagStrong adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagSub adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagSub adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagSummary adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagSummary adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagSup adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagSup adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagTable adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagTable adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagTbody adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagTbody adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagTd adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagTd adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagTfoot adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagTfoot adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagTh adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagTh adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagThead adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagThead adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagTime adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagTime adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagTr adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagTr adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagTt adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagTt adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagU adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagU adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagUl adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagUl adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagVar adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagVar adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

	@Override
	public void start(TagVideo adapter) throws HtmlWalkerException
	{
        for (int n = 0; n < this.walkers.size(); n++)
            this.walkers.get(n).start(adapter);
	}

	@Override
	public void end(TagVideo adapter) throws HtmlWalkerException
	{
        for (int n = this.walkers.size() - 1; n >= 0; n--)
            this.walkers.get(n).end(adapter);
	}

}
