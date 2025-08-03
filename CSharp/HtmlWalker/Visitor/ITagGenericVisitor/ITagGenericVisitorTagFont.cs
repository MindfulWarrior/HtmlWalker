using HtmlWalker.Tag.Html;

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
        ///   Visitor pattern method for the <b>&lt;font&gt;</b> tag adapter
        /// </summary>
        /// <param name="adapter">the <b>&lt;font&gt;</b> tag adapter</param>
        T Visit(TagFont adapter);
   }
}