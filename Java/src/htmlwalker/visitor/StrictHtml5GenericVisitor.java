package htmlwalker.visitor;

import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.exception.TagDeprecatedException;
import htmlwalker.tag.html.*;

public abstract class StrictHtml5GenericVisitor<T> implements ITagGenericVisitor<T>
{
     /*
	  * TODO: Deprecated tags that are missing
	  * <acronym>
	  * <applet>
	  * <basefont>
	  * <bgsound>
	  * <dir>
	  * <font>
	  * <frame>
	  * <frameset
	  * <isindex>
	  * <noframes>
	  * <tt>
	 */

    public T visit(TagBig adapter) throws HtmlWalkerException { throw new TagDeprecatedException(adapter); }

    public T visit(TagCenter adapter) throws HtmlWalkerException { throw new TagDeprecatedException(adapter); }

    public T visit(TagS adapter) throws HtmlWalkerException { throw new TagDeprecatedException(adapter); }

    public T visit(TagStrike adapter) throws HtmlWalkerException { throw new TagDeprecatedException(adapter); }

    public T visit(TagU adapter) throws HtmlWalkerException { throw new TagDeprecatedException(adapter); }

}
 
