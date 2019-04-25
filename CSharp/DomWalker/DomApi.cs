using HtmlWalker;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DomWalker
{
    public abstract class DomApi<D>
    {
        internal protected DomApi() { }

        internal protected abstract object DocumentNode(D dom);

        internal protected abstract object HtmlElement(D dom);

        internal protected abstract string Html(D dom);

        internal protected abstract object CreateElement(D dom, string name);

        internal protected abstract object CreateTextNode(D dom, string text);

        internal protected abstract object CreateEntityNode(D dom, string entity);

        internal protected abstract IList<object> GetContent(D dom, ITag adapter);

        internal protected abstract void Load(D dom, string path);

        internal protected abstract void Load(D dom, TextReader reader);

        internal protected abstract void LoadHtml(D dom, string html);

        internal protected abstract void Save(D dom, string path, Encoding encoding);

        internal protected abstract void Save(D dom, TextWriter writer);
    }
}
