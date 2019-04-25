using System;

namespace HtmlWalker.Exception
{
    /// <summary>
    ///   This exception class wraps a previous exception that occured while
    ///   processing html.
    ///
    ///   The purpose is to provide a single source to catch without having
    ///   to change code constantly as new exceptions are introduced.
    /// </summary>
    /// <author>Robert R Flores</author>
    public class HtmlWalkerException : System.Exception
    {
        /// <summary>
        ///  Default constructor
        /// </summary>
        public HtmlWalkerException() : base() { }

        /// <summary>
        ///   Consturctor to pass an error message to the base <see cref="System.Exception"/>
        /// </summary>
        /// <param name="msg">msg to pass</param>
        public HtmlWalkerException(string msg) : base(msg) { }
    }
}
