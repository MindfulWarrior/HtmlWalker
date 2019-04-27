package xhtmlxsd;

import java.io.ByteArrayInputStream;
import java.io.IOException;
import java.io.InputStream;

import org.xml.sax.EntityResolver;
import org.xml.sax.InputSource;

public class XhtmlEntityResolver implements EntityResolver
{
	public static final XhtmlEntityResolver theInstance = new XhtmlEntityResolver();
	
	private XhtmlEntityResolver() { super(); }

	@Override
	public InputSource resolveEntity(String publicId, String systemId) throws IOException 
	{
		InputStream stream;
		
		if (systemId.toLowerCase().endsWith("xhtml1-transitional.dtd"))
			stream = XhtmlEntityResolver.class.getResource("xhtml1-transitional.dtd").openStream();
		else if (systemId.toLowerCase().endsWith("xhtml-lat1.ent"))  
			stream = XhtmlEntityResolver.class.getResource("xhtml-lat1.ent").openStream();
		else if (systemId.toLowerCase().endsWith("xhtml-symbol.ent"))  
			stream = XhtmlEntityResolver.class.getResource("xhtml-symbol.ent").openStream();
		else if (systemId.toLowerCase().endsWith("xhtml-special.ent"))  
			stream = XhtmlEntityResolver.class.getResource("xhtml-special.ent").openStream();
		else
			stream = new ByteArrayInputStream(new String("").getBytes());
		
		return new InputSource(stream);
	}
}
