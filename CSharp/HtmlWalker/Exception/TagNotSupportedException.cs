using HtmlWalker.Core;

namespace HtmlWalker.Exception
{
    public class TagNotSupportedException : HtmlWalkerException
    {
        public TagNotSupportedException(string msg) : base(msg) { }

        public TagNotSupportedException(ITag adapter) : base(adapter.Name) { }
    }
}
