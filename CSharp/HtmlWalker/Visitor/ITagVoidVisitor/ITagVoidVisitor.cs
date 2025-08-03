using HtmlWalker.Tag.Html;
using HtmlWalker.Tag.Util;

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
        void Visit(DocumentTag adapter);

        /// <summary>
        ///   Visitor pattern method for <see cref="Text"/>
        /// </summary>
        /// <param name="adapter">the text adapter</param>
        void Visit(Text adapter);

        /// <summary>
        ///   Visitor pattern method for <see cref="Eol"/>
        /// </summary>
        /// <param name="adapter">the eol adapter</param>
        void Visit(Eol adapter);

        /// <summary>
        ///   Vistior pattern method for <see cref="Entity"/>
        /// </summary>
        /// <param name="adapter">the entity adapter</param>
        void Visit(Entity adapter);

        /// <summary>
        ///   Vistior pattern method for <b>comment</b> adapter
        /// </summary>
        /// <param name="adapter">the comment adapter</param>
        void Visit(Comment adapter);

        /// <summary>
        ///   Vistior pattern method for <b>skip</b> adapter
        /// </summary>
        /// <param name="adapter">the skip adapter</param>
        void Visit(Skip adapter);

        /// <summary>
        ///   Vistior pattern method for <see cref="Unknown"/>
        /// </summary>
        /// <param name="adapter">the uknown adapter</param>
        void Visit(Unknown adapter);
    }
}