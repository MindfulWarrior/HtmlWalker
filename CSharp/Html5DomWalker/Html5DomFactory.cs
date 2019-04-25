using DomWalker;
using HtmlAgilityPack;

namespace Html5DomWalker
{
    public partial class Html5DomPlatform
    {
        public class Html5DomFactory : DomFactory<Html5DomApi, HtmlDocument>
        {
            internal Html5DomFactory(HtmlDocument dom, Html5DomPlatform platform)
                : base(Html5DomApi.Instance, dom, platform) { }

            protected override ITagApi Api => Html5DomTagApi.Instance;

            protected override object CloneTag(object tag) { return ((HtmlNode)tag).CloneNode(false); }

            public override void Close() => Dom = null;
        }
    }
}