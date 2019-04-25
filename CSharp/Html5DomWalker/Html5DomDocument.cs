using DomWalker;
using HtmlAgilityPack;

namespace Html5DomWalker
{
    public class Html5DomDocument
        : DomDocument<Html5DomPlatform.Html5DomFactory, Html5DomApi, HtmlDocument>
    {
        internal protected Html5DomDocument(HtmlDocument dom, Html5DomPlatform platform)
            : base(new Html5DomPlatform.Html5DomFactory(dom, platform)) { }
    }
}
