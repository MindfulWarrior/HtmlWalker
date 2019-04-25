using HtmlWalker.Core;

namespace HtmlWalker.Exception
{
    public class TagDeprecatedException : HtmlWalkerException
    {
        public TagDeprecatedException(string msg) : base(msg) { }

        public TagDeprecatedException(ITag adapter) : base(adapter.Name) { }
    }
}
