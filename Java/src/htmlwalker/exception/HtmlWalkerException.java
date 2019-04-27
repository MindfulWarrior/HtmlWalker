/*
 * 
 */
package htmlwalker.exception;

/**
 * This exception class wraps a previous exception that occured while
 * processing html.
 * 
 * The purpose is to provide a single source to catch without having
 * to change code constantly as new exceptions are introduced.
 * 
 * @author Robert Flores
 */
@SuppressWarnings("serial")
public class HtmlWalkerException extends Exception
{
	
	/** The exception which prompts this one. */
	private final Exception exception;
	
	public HtmlWalkerException()
	{
		super();
		this.exception = new Exception();
	}
	
	public HtmlWalkerException(String msg)
	{
		super(msg);
		this.exception = new Exception(msg);
	}
	
	/**
	 * Instantiates a new html walker exception from an existing exception.
	 *
	 * @param e - the exception this one is based on
	 */
	public HtmlWalkerException(Exception e)
	{
		super(e);
		this.exception = e;
	}
	
	/**
	 * The exception that prompted this exception.
	 *
	 * @return the exception
	 */
	public Exception innerException() { return this.exception; }
}
