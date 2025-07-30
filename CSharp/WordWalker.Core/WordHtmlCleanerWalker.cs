using Html5DomWalker;
using HtmlDocCleaner;
using HtmlWalker;
using HtmlWalker.Platform;
using HtmlWalker.Tag.Html;

namespace WordWalker
{
    public class WordHtmlCleanerWalker : DocCleanerWalker
    {
        public WordHtmlCleanerWalker(Html5DomDocument document) : base(document)
        {
            Modifiers.Insert(0, new WordHtmlCleanerModifier(Output as Html5DomDocument));
        }

        public override void Start(TagP adapter)
        {
            base.Start(adapter);
        }

        public override void End(TagP adapter)
        {
            base.End(adapter);
        }
    }
}
