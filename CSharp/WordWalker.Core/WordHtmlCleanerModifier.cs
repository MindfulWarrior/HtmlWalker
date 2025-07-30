using Html5DomWalker;
using HtmlDocCleaner;
using HtmlWalker;
using HtmlWalker.Tag.Html;
using static HtmlWalker.Platform.WalkerPlatform;

namespace WordWalker
{
    public class WordHtmlCleanerModifier : DocCleanerModifier
    {
        private readonly Html5DomDocument document;

        public WordHtmlCleanerModifier(Html5DomDocument document) : base(document.Factory)
        {
            this.document = document;
        }

        public override ITag Visit(TagP adapter)
        {
            var attrClass = adapter.Attributes["class"];
            if (!(attrClass is null) && attrClass.Equals("MsoTitle"))
            {
                var titleH1 = new TagH1(document.Factory);
                adapter.Owner.OwnedTags.Replace(ref adapter, ref titleH1);
                return base.Visit(titleH1);
            }
            return base.Visit(adapter);
        }
    }
}
