package htmlwalker.exception;

import htmlwalker.ITag;

@SuppressWarnings("serial")
public class TagNotSupportedException extends HtmlWalkerException
{
	
    public TagNotSupportedException(String msg) { super(msg); }

    public TagNotSupportedException(ITag adapter) { super(adapter.name()); }
    
}
