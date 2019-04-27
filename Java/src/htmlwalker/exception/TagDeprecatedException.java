package htmlwalker.exception;

import htmlwalker.ITag;

@SuppressWarnings("serial")
public class TagDeprecatedException extends HtmlWalkerException
{
	
    public TagDeprecatedException(String msg) { super(msg); }

    public TagDeprecatedException(ITag adapter) { super(adapter.name()); }
    
}
