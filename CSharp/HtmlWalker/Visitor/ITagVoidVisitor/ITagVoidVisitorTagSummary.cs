using HtmlWalker.Tag.Html;

namespace HtmlWalker.Visitor
{
    /// <summary>
    ///   This an HTML tag visitor used to define <see cref="Walker"/> and any other case were
    ///   a return value is not required.
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
    public partial interface ITagVoidVisitor
    {
        /// <summary>
        ///  Visit the root element of the document
        /// </summary>
        /// <param name="adapter">document root adapter</param>
        void Visit(TagSummary adapter);
   }
}