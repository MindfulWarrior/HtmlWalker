package htmlwalker.core;

import java.util.ArrayList;
import java.util.List;

import htmlwalker.DocumentTag;
import htmlwalker.ITag;
import htmlwalker.exception.HtmlWalkerException;
import htmlwalker.exception.InvalidVisitorException;
import htmlwalker.exception.NoDocumentException;
import htmlwalker.platform.WalkerDocument;
import htmlwalker.visitor.ITagGenericVisitor;

public abstract class DocGeneratorWalker extends GenericWalker
{
    public interface IModifier extends ITagGenericVisitor<ITag> { }

	/** The cloned HTML output generated. */
	protected final WalkerDocument output;

	/**
	 * Access to the HTML output generated.
	 *
	 * @return the walker document representing the HTML output generated
	 */
	//protected WalkerDocument output() { return this.output; }
		
	/**
	 * Get the current tag adapter.
	 *
	 * @return the the current tag adapter
	 */
	protected ITag currentTag = null;

    public final List<IModifier> modifiers = new ArrayList<IModifier>();
	
	public DocGeneratorWalker(WalkerDocument document) { super();  this.output = document; }

    protected abstract <T extends ITag> ITag generateTag(T adapter);

    protected <T extends ITag> ITag generate(T adapter) throws HtmlWalkerException
    {
        ITag tag = generateTag(adapter);
        for (IModifier vistitor : modifiers)
        {
            tag = tag.visit(vistitor);
            if (tag == null)
                throw new InvalidVisitorException();
        }
        return tag;
    }

    protected void startDocument(DocumentTag adapter) throws HtmlWalkerException
    {
    	if (this.output == null)
    		throw new NoDocumentException();
    	currentTag = output.documentTag();
    }

    protected void endDocument(DocumentTag adapter) { }

    protected <T extends ITag> ITag handleTag(T adapter) throws HtmlWalkerException { return generate(adapter); }

	/**
	 * This method is used to clone a tag adapter, add it to the current tag's content
	 * and then make the newly cloned tag adapter the current tag.
	 *
	 * @param adapter - the original tag adapter
	 */
    protected <T extends ITag> ITag startTag(T adapter) throws HtmlWalkerException { return currentTag = generate(adapter); }

	/**
	 * This method returns the stack to the previous tag.
	 */
    protected void endTag() { currentTag = currentTag.owner(); }   
}
