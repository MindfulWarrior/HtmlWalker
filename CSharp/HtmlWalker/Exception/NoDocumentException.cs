namespace HtmlWalker.Exception
{
    /// <summary>
    ///   This exception is called when an atempt is made to walk HTML and the document
    ///   has been opened, <see cref="Walker.Open(WalkerPlatform.WalkerDocument)"/>.
    /// </summary>
    /// <author>Robert R Flores</author>
    public class NoDocumentException : HtmlWalkerException
    {
        public NoDocumentException() : base() { }

        public NoDocumentException(string msg) : base(msg) { }
    }
}
