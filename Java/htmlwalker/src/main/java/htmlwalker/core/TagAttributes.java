package htmlwalker.core;

import java.util.Collection;
import java.util.Map;
import java.util.Set;

import htmlwalker.ITag;
import htmlwalker.platform.ITagApi;

public class TagAttributes implements Map<String, String>
{
	protected final ITag tag;
    protected final ITagApi api;

    private Map<String, String> map = null;

    private Map<String, String> attributes()
    {
        if (this.map == null)
            this.map = this.api.getAttributes(this.tag.tag());
        return this.map;
    }

    private String getAttribute(String attr)
    {
    	return this.api.platform().handleEntities(this.api.getAttribute(this.tag.tag(), attr), true);
    }

    private void setAttribute(String attr, String value)
    {
        attr = attr.toLowerCase().trim();
        if (value == null)
        {
            if (this.map != null)
            	this.map.remove(attr);
            this.api.setAttribute(this.tag.tag(), attr, null);
        }
        else
        {
            if (this.map != null)
                this.map.put(attr, value);
            this.api.setAttribute(this.tag.tag(), attr, this.api.platform().handleEntities(value, true));
        }
    }

    public TagAttributes(ITag tag, ITagApi api)
    {
    	this.tag = tag;
    	this.api = api;
    }

	@Override
	public void clear()
	{
		Set<String> attrs = keySet();
		for (String attr : attrs)
			remove(attr);
	}

	@Override
	public boolean containsKey(Object attr) { return getAttribute(attr.toString()) != null; }

	@Override
	public boolean containsValue(Object value) { return attributes().containsValue(value); }

	@Override
	public Set<Entry<String, String>> entrySet() { return attributes().entrySet(); }

	@Override
	public String get(Object attr) { return getAttribute(attr.toString()); }

	@Override
	public boolean isEmpty() { return attributes().isEmpty(); }

	@Override
	public Set<String> keySet() { return attributes().keySet(); }

	@Override
	public String put(String attr, String value)
	{
		String old = getAttribute(attr);
		setAttribute(attr, value);
		return old;
	}

	@Override
	public void putAll(Map<? extends String, ? extends String> attrs)
	{
		for (Entry<? extends String, ? extends String> entry : attrs.entrySet())
			put(entry.getKey(), entry.getValue());
	}

	@Override
	public String remove(Object attr) { return put(attr.toString(), null); }

	@Override
	public int size() { return attributes().size(); }

	@Override
	public Collection<String> values() { return attributes().values(); }

}
