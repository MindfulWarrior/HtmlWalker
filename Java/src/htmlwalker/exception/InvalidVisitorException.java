package htmlwalker.exception;

@SuppressWarnings("serial")
public class InvalidVisitorException extends HtmlWalkerException
{

	public InvalidVisitorException() { super(new IllegalStateException()); }
	
	public InvalidVisitorException(String msg) { super(new IllegalStateException(msg)); }
	
}
