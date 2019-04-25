namespace HtmlWalker.Exception
{
    /// <summary>
    ///   This exception is called when a visitor has been given to
    ///   a <see cref="Walker"/> that does not meet it's specifications
    ///
    ///   See the <b>Walker</b> specification.
    /// </summary>
    /// <author>Robert R Flores</author>
    internal class InvalidVisitorException : HtmlWalkerException
    {
        public InvalidVisitorException() : base() { }

        public InvalidVisitorException(string msg) : base(msg) { }
    }
}