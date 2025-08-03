using HtmlWalker.Tag.Util;

namespace HtmlWalker.Visitor
{
    /// <summary>
    ///   This class provides the ability for users of the HtmlWalker package to use
    ///   the visitor pattern.Any class that implements this interface can then use
    ///   it with the full set of tag adapters.
    ///   
    ///   Here 'T' specifies the return type of the <b>vist</b> methods
    ///   
    ///   The set of HTML tags is the intersection of HTML5 and XHTML. These tags are not
    ///   included as they conform to neither:
    ///    
    ///   &lt;applet&gt;
    ///   &lt;basefont&gt;
    ///   &lt;bgsound&gt;
    ///   &lt;dir&gt;
    ///   &lt;frame&gt;
    ///   &lt;frameset&gt;
    ///   &lt;isindex&gt;
    ///   &lt;noframes&gt;
    /// 
    /// </summary>
    /// <author>Robert R Flores</author>
    public partial interface ITagGenericVisitor<T>
    {
        /// <summary>
        ///  Visit the root element of the document
        /// </summary>
        /// <param name="adapter">document root adapter</param>
        /// <returns>T</returns>
        T Visit(DocumentTag adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>text</b> adapter
        /// </summary>
        /// <param name="adapter">the text adapter</param>
        /// <returns>T</returns>
        T Visit(Text adapter);

        /// <summary>
        ///   Visitor pattern method for the <b>eol</b> adapter
        /// </summary>
        /// <param name="adapter">the eol adapter</param>
        /// <returns>T</returns>
        T Visit(Eol adapter);

        /// <summary>
        ///   Vistior pattern method for <b>entity</b> adapter
        /// </summary>
        /// <param name="adapter">the entity adapter</param>
        /// <returns>T</returns>
        T Visit(Entity adapter);

        /// <summary>
        ///   Vistior pattern method for <b>comment</b> adapter
        /// </summary>
        /// <param name="adapter">the comment adapter</param>
        /// <returns>T</returns>
        T Visit(Comment adapter);

        /// <summary>
        ///   Vistior pattern method for <b>skip</b> adapter
        /// </summary>
        /// <param name="adapter">the skip adapter</param>
        /// <returns>T</returns>
        T Visit(Skip adapter);

        /// <summary>
        ///   Vistior pattern method for <b>unknown</b> tag adapter
        /// </summary>
        /// <param name="adapter">the uknown adapter</param>
        /// <returns>T</returns>
        T Visit(Unknown adapter);
    }
}