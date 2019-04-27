/*
 * 
 */
package htmlwalker.core;

import java.util.HashMap;
import java.util.Map;

/**
 * During XML processing will often translate the XML entities, which is
 * what is not wanted when the HTML is walked. Instead, the entities need to be
 * preserved for other kinds of processing that will occur later.
 * 
 * This singleton is used to preserve the XML entities which would be consumed
 * during HTML/XML processing, otherwise. The methods are written to match the
 * <b>CharacterEscapeHandler</b> interface for later use.
 * 
 * @author Robert Flores
 */
public class EscHandler
{
	
	/**
	 * A constant mapping between the entitles and their character values.
	 **/
	@SuppressWarnings("serial")
	private static final Map<Integer, String> escChars = new HashMap<Integer, String>()
	{	
		{
			//put((int)'\"', "&quot;");
			//put((int)'\'', "&apos;");
			put((int)'<',  "&lt;");
			put((int)'>',  "&gt;");
			
			put( 128, "&euro;");		
			put( 130, "&sbquo;");		
			put( 131, "&fnof;");		
			put( 132, "&bdquo;");		
			put( 133, "&hellip;");	
			put( 134, "&dagger;");	
			put( 135, "&Dagger;");	
			put( 136, "&circ;");		
			put( 137, "&permil;");	
			put( 138, "&Scaron;");	
			put( 139, "&lsaquo;");
			put( 140, "&OElig;");		
			put( 142, "&Zcaron;");	
			put( 145, "&lsquo;");		
			put( 146, "&rsquo;");		
			put( 147, "&ldquo;");		
			put( 148, "&rdquo;");		
			put( 149, "&bull;");		
			put( 150, "&ndash;");		
			put( 151, "&mdash;");		
			put( 152, "&tilde;");		
			put( 153, "&trade;");		
			put( 154, "&scaron;");	
			put( 155, "&rsaquo;");
			put( 156, "&oelig;");		
			put( 158, "&zcaron;");	
			put( 159, "&Yuml;");
			put( 160, "&nbsp;");
			put( 161, "&iexcl;");		
			put( 162, "&cent;");		
			put( 163, "&pound;");		
			put( 164, "&curren;");	
			put( 165, "&yen;");		
			put( 166, "&brvbar;");	
			put( 167, "&sect;");		
			put( 168, "&uml;");		
			put( 169, "&copy;");		
			put( 170, "&ordf;");		
			put( 171, "&laquo;");
			put( 172, "&not;");		
			put( 173, "&shy;");		
			put( 174, "&reg;");		
			put( 175, "&macr;");		
			put( 176, "&deg;");		
			put( 177, "&plusmn;");	
			put( 178, "&sup2;");		
			put( 179, "&sup3;");		
			put( 180, "&acute;");		
			put( 181, "&micro;");		
			put( 182, "&para;");		
			put( 183, "&middot;");	
			put( 184, "&cedil;");		
			put( 185, "&sup1;");		
			put( 186, "&ordm;");		
			put( 187, "&raquo;");
			put( 188, "&frac14;");	
			put( 189, "&frac12;");	
			put( 190, "&frac34;");	
			put( 191, "&iquest;");	
			put( 192, "&Agrave;");
			put( 193, "&Aacute;");
			put( 194, "&Acirc;");
			put( 195, "&Atilde;");	
			put( 196, "&Auml;");
			put( 197, "&Aring;");
			put( 198, "&AElig;");		
			put( 199, "&Ccedil;");	
			put( 200, "&Egrave;");
			put( 201, "&Eacute;");
			put( 202, "&Ecirc;");
			put( 203, "&Euml;");
			put( 204, "&Igrave;");
			put( 205, "&Iacute;");
			put( 206, "&Icirc;");
			put( 207, "&Iuml;");
			put( 208, "&ETH;");		
			put( 209, "&Ntilde;");	
			put( 210, "&Ograve;");
			put( 211, "&Oacute;");
			put( 212, "&Ocirc;");
			put( 213, "&Otilde;");	
			put( 214, "&Ouml;");
			put( 215, "&times;");		
			put( 216, "&Oslash;");	
			put( 217, "&Ugrave;");	
			put( 218, "&Uacute;");
			put( 219, "&Ucirc;");
			put( 220, "&Uuml;");
			put( 221, "&Yacute;");	
			put( 222, "&THORN;");		
			put( 223, "&szlig;");		
			put( 224, "&agrave;");
			put( 225, "&aacute;");
			put( 226, "&acirc;");		
			put( 227, "&atilde;");	
			put( 228, "&auml;");
			put( 229, "&aring;");		
			put( 230, "&aelig;");		
			put( 231, "&ccedil;");	
			put( 232, "&egrave;");
			put( 233, "&eacute;");
			put( 234, "&ecirc;");		
			put( 235, "&euml;");
			put( 236, "&igrave;");
			put( 237, "&iacute;");
			put( 238, "&icirc;");		
			put( 239, "&iuml;");
			put( 240, "&eth;");		
			put( 241, "&ntilde;");	
			put( 242, "&ograve;");
			put( 243, "&oacute;");
			put( 244, "&ocirc;");		
			put( 245, "&otilde;");	
			put( 246, "&ouml;");
			put( 247, "&divide;");	
			put( 248, "&oslash;");	
			put( 249, "&ugrave;");
			put( 250, "&uacute;");
			put( 251, "&ucirc;");		
			put( 252, "&uuml;");
			put( 253, "&yacute;");	
			put( 254, "&thorn;");		
			put( 255, "&yuml;");

			put( 338, "&OElig;");		
			put( 339, "&oelig;");		
			put( 352, "&Scaron;");	
			put( 353, "&scaron;");		
			put( 376, "&Yuml;");
			put( 402, "&fnof;");	
			put( 710, "&circ;");	
			put( 732, "&tilde;");	
			put( 913, "&Alpha;");	
			put( 914, "&Beta;");	
			put( 915, "&Gamma;");	
			put( 916, "&Delta;");	
			put( 917, "&Epsilon;");	
			put( 918, "&Zeta;");
			put( 919, "&Eta;");			
			put( 920, "&Theta;");	
			put( 921, "&Iota;");	
			put( 922, "&Kappa;");	
			put( 923, "&Lambda;");	
			put( 924, "&Mu;");
			put( 925, "&Nu;");	
			put( 926, "&Xi;");	
			put( 927, "&Omicron;");		
			put( 928, "&Pi;");
			put( 929, "&Rho;");
			put( 931, "&Sigma;");	
			put( 932, "&Tau;");	
			put( 933, "&Upsilon;");		
			put( 934, "&Phi;");
			put( 935, "&Chi;");	
			put( 936, "&Psi;");	
			put( 937, "&Omega;");	
			put( 945, "&alpha;");	
			put( 946, "&beta;");	
			put( 947, "&gamma;");	
			put( 948, "&delta;");	
			put( 949, "&epsilon;");	
			put( 950, "&zeta;");
			put( 951, "&eta;");	
			put( 952, "&theta;");	
			put( 953, "&iota;");	
			put( 954, "&kappa;");	
			put( 955, "&lambda;");	
			put( 956, "&mu;");
			put( 957, "&nu;");	
			put( 958, "&xi;");	
			put( 959, "&omicron;");		
			put( 960, "&pi;");
			put( 961, "&rho;");	
			put( 962, "&sigmaf;");	
			put( 963, "&sigma;");
			put( 964, "&tau;");	
			put( 965, "&upsilon;");		
			put( 966, "&phi;");
			put( 967, "&chi;");	
			put( 968, "&psi;");	
			put( 969, "&omega;");	
			put( 977, "&thetasym;");	
			put( 978, "&upsih;");
			put( 982, "&piv;");	
			put(8194, "&ensp;");	
			put(8195, "&emsp;");	
			put(8201, "&thinsp;");	
			put(8204, "&zwnj;");
			put(8205, "&zwj;");	
			put(8206, "&lrm;");	 		
			put(8207, "&rlm;");	
			put(8211, "&ndash;");		
			put(8212, "&mdash;");	
			put(8216, "&lsquo;");	
			put(8217, "&rsquo;");	
			put(8218, "&sbquo;");	
			put(8220, "&ldquo;");	
			put(8221, "&rdquo;");	
			put(8222, "&bdquo;");	
			put(8224, "&dagger;");	
			put(8225, "&Dagger;");
			put(8226, "&bull;");
			put(8230, "&hellip;");	
			put(8240, "&permil;");
			put(8242, "&prime;");
			put(8243, "&Prime;");	
			put(8249, "&lsaquo;");	
			put(8250, "&rsaquo;");
			put(8254, "&oline;");		
			put(8260, "&frasl;");	
			put(8364, "&euro;");	
			put(8465, "&image;");	
			put(8472, "&weierp;");	
			put(8476, "&real;");
			put(8482, "&trade;");	
			put(8501, "&alefsym;");	
			put(8592, "&larr;");
			put(8593, "&uarr;");	
			put(8594, "&rarr;");	
			put(8595, "&darr;");	
			put(8596, "&harr;");	
			put(8629, "&crarr;");	
			put(8656, "&lArr;");	
			put(8657, "&uArr;");	
			put(8658, "&rArr;");	
			put(8659, "&dArr;");	
			put(8660, "&hArr;");	
			put(8704, "&forall;");	
			put(8706, "&part;");
			put(8707, "&exist;");	
			put(8709, "&empty;");	
			put(8711, "&nabla;");	
			put(8712, "&isin;");	
			put(8713, "&notin;");	
			put(8715, "&ni;");	
			put(8719, "&prod;");
			put(8721, "&sum;");	
			put(8722, "&minus;");	
			put(8727, "&lowast;");	
			put(8730, "&radic;");
			put(8733, "&prop;");	
			put(8734, "&infin;");	
			put(8736, "&ang;");	
			put(8743, "&and;");	
			put(8744, "&or;");	
			put(8745, "&cap;");	
			put(8746, "&cup;");	
			put(8747, "&int;");	
			put(8756, "&there4;");	
			put(8764, "&sim;");
			put(8773, "&cong;");	
			put(8776, "&asymp;");	
			put(8800, "&ne;");	
			put(8801, "&equiv;");		
			put(8804, "&le;");	
			put(8805, "&ge;");	
			put(8834, "&sub;");	
			put(8835, "&sup;");	
			put(8836, "&nsub;");	
			put(8838, "&sube;");	
			put(8839, "&supe;");	
			put(8853, "&oplus;");	
			put(8855, "&otimes;");	
			put(8869, "&perp;");
			put(8901, "&sdot;");	
			put(8942, "&vellip;");	
			put(8968, "&lceil;");
			put(8969, "&rceil;");	
			put(8970, "&lfloor;");	
			put(8971, "&rfloor;");
			put(9001, "&lang;");
			put(9002, "&rang;");	
			put(9674, "&loz;");	
			put(9824, "&spades;");	
			put(9827, "&clubs;");
			put(9829, "&hearts;");	
			put(9830, "&diams;");			
		};	
	};
	
	/** The singleton instance. */
	public static final EscHandler theInstance = new EscHandler();
	
	/**
	 * Instantiates a new escape handler.
	 */
	private EscHandler() { super(); }

	/**
	 * Overload of <b>escape(char[], int, int)</b> for general use.
	 *
	 * @param content - string to restore/preserve entities
	 * @return resulting string
	 */
	public String escape(String content)
	{
		if (null == content)
			return null;
		return escape(content.toCharArray(), 0, content.length());
	}
	
	/** Whether in a comment or not. */
	private static boolean comment = false;
	
	/** Whether in a cdata block or not. */
	private static boolean cdata = false;
	
	/**
	 * Implementation of the <b>CharacterEscapeHandler.escape</b> method.
	 * 
	 * This method is written to preserve or restore entities
	 * (such as &amp;lt; and &amp;rdsquo;) that may have been removed in
	 * processing. The mapping is as per the XHTML Transitional and
	 * Window-1252 specifications.
	 * 
	 * See <a href="http://www.w3.org/tr/xhtml1/dtds.html">XHTML Specification</a>
	 * and <a href="http://msdn.microsoft.com/en-is/goglobal/cc305145">Microsoft Windows-1252 Specification</a>
	 *
	 * @param ch - char array passed by processing objects
	 * @param start - start index of char array
	 * @param length - length of char array
	 * @return contents of char array with entities preserved or restored
	 */
	public String escape(char[] ch, int start, int length)
	{
		String text = new String();
		
		int limit = start + length;
		
		for (int i = start; i < limit; i++)
		{
			if (EscHandler.comment)
			{
				text += ch[i];
				if (2 < length - i && '-' == ch[i] && '-' == ch[i+1] && '>' == ch[i+2])
				{
					EscHandler.comment = false;
					text += "->";
					i += 2;
				}
			}
			else if (EscHandler.cdata)
			{
				text += ch[i];
				if (2 < length - i && ']' == ch[i] && ']' == ch[i+1] && '>' == ch[i+2])
				{
					EscHandler.cdata = false;
					text += "]>";
					i += 2;
				}
			}
			else if (3 < length - i && '<' == ch[i] && '!' == ch[i+1] && '-' == ch[i+2] && '-' == ch[i+3])
			{
				EscHandler.comment = true;
				text += "<!--";
				i += 3;				
			}
			else if (8 < length - i && '<' == ch[i] && '!' == ch[i+1] && '[' == ch[i+2] && 'C' == ch[i+3])
			{
				EscHandler.cdata = true;
				text += "<![CDATA[";
				i += 8;				
			}
			else if ('&' == ch[i])
			{
				String entity = "&";
				
				boolean done = false;
				int pos = i + 1;
				for (; !done && pos < limit; pos++)
				{
					entity += Character.toString(ch[pos]);
					if (';' == ch[pos])
						done = true;
				}
				
				if (entity.equals("&amp;") || EscHandler.escChars.containsValue(entity))
				{
					text += entity;
					i = pos - 1;
				}
                else if (entity.length() > 3 && entity.charAt(1) == '#')
                {
                	try
                	{
	                	String value_str = entity.substring(2, entity.length() - 3);
	                    int entity_value = Integer.parseInt(value_str);
	                    if (EscHandler.escChars.containsKey(entity_value))
	                        text += EscHandler.escChars.get(entity_value);
	                    else
	                        text += entity;                		
                	}
                	catch (NumberFormatException e)
                	{
                        text += entity;                		
                	}
                    i = pos - 1;
                }
                else
                    text += "&amp;";
			}
			else
			{
				Integer escChar = (int)ch[i];
				if (EscHandler.escChars.containsKey(escChar))
					text += EscHandler.escChars.get(escChar);
				else if (ch[i] > '\u007f')
					text += "&#" + escChar.toString() + ";";
				else
					text += ch[i];
			}
		}
		
		return text;
	}
}		
