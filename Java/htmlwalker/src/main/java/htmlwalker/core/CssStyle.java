package htmlwalker.core;

import java.util.TreeMap;
import java.util.stream.Collectors;

@SuppressWarnings("serial")
public class CssStyle extends TreeMap<String, String> implements Cloneable
{
    public CssStyle() { super(String.CASE_INSENSITIVE_ORDER); }

    public CssStyle(String css)
    {
    	super(String.CASE_INSENSITIVE_ORDER);
    	setProperties(css);
    }
    
    public String getProperties()
    {
        if (size() == 0)
            return null;
        return entrySet().stream().map(p -> p.getKey() + ":" + p.getValue()).collect(Collectors.joining(";"));
    }

    public void setProperties(String list)
    {
        clear();
        
        if (null != list)
        {
            String[] pairs = list.split(";");
            for (String pair : pairs)
            {
                String[] prop = pair.split(":");
                if (prop.length == 2)
                	put(prop[0].toLowerCase().trim(), prop[1].trim());
            }
        }
    }
    
}

