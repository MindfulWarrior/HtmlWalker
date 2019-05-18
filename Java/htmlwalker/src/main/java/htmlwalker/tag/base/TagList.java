package htmlwalker.tag.base;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.List;
import java.util.ListIterator;

import htmlwalker.*;
import htmlwalker.platform.WalkerFactory;
import htmlwalker.tag.util.Eol;
import htmlwalker.tag.util.Text;

public class TagList implements List<ITag>
{
    public List<ITag> tags = new ArrayList<ITag>();

    protected final BaseTag owner;
    protected final BaseTag nodeOwner;
    
    public TagList(BaseTag owner) { this(owner, owner); }

    public TagList(BaseTag owner, BaseTag nodeOnwer)
    {
        this.owner = owner;
        this.nodeOwner = nodeOnwer;
    }
    
    public TagList initialize(WalkerFactory factory)
    {
        List<Object> content = factory.createContent(this.owner);
        for (Object item : content)
        {
            ITag adapter = factory.createAdapter(this.owner, item);
            if (!factory.provideEol || adapter.name() != "#text" || !adapter.getTextValue().contains(System.lineSeparator()))
            	this.tags.add(adapter);
            else
            {
                String original = adapter.getTextValue();
                int endEols = 0;

                // Handle extra item when EOL is at end
                while (original.endsWith(System.lineSeparator()))
                {
                    original = original.substring(0, original.length() - System.lineSeparator().length());
                    endEols++;
                }
                    
				if (!original.isEmpty())
                {
					String[] lines = original.split(System.lineSeparator());
                    for (int n = 0; n < lines.length - 1; n++)
                    {
                        if (!lines[n].isEmpty())
                            this.tags.add(new Text(factory, lines[n]));
                        this.tags.add(new Eol(factory, System.lineSeparator()));
                    }
                    this.tags.add(new Text(factory, lines[lines.length - 1]));

                }

                // Add EOLs back if needed
                for (int n = 0; n < endEols; n++)
                    this.tags.add(new Eol(factory, System.lineSeparator()));
            }
            //((BaseTag)adapter).owner(this.owner);
        }
        return this;
    }
    
	@Override
	public boolean add(ITag adapter)
	{
		this.tags.add(adapter);
		this.nodeOwner.api.add(this.nodeOwner.tag(), adapter);
		((BaseTag)adapter).owner(this.owner);
		return true;
	}

	@Override
	public void add(int index, ITag adapter)
	{
		this.tags.add(index, adapter);
		this.owner.api.add(this.owner.tag(), adapter);
	}

	@Override
	public boolean addAll(Collection<? extends ITag> tags)
	{
		for (ITag adapter : tags)
			add(adapter);
		return true;
	}

	@Override
	public boolean addAll(int index, Collection<? extends ITag> tags)
	{
		// TODO Auto-generated method stub
		throw new UnsupportedOperationException();
	}

	@Override
	public void clear()
	{
		for (ITag tag : tags)
			remove(tag);
	}

	@Override
	public boolean contains(Object adapter) { return this.tags.contains(adapter); }

	@Override
	public boolean containsAll(Collection<?> tags) { return this.tags.containsAll(tags); }

	@Override
	public ITag get(int index) { return this.tags.get(index); }

	@Override
	public int indexOf(Object adapter) { return this.tags.indexOf(adapter); }

	@Override
	public boolean isEmpty() { return this.tags.isEmpty(); }

	@Override
	public Iterator<ITag> iterator() { return this.tags.iterator(); }

	@Override
	public int lastIndexOf(Object adapter) { return this.tags.lastIndexOf(adapter); }

	@Override
	public ListIterator<ITag> listIterator() { return this.tags.listIterator(); }

	@Override
	public ListIterator<ITag> listIterator(int index) { return this.tags.listIterator(index); }

	@Override
	public boolean remove(Object obj)
	{
		ITag adapter = (ITag)obj;
		this.owner.api.remove(this.owner, adapter);
		((BaseTag)adapter).owner(null);
		return this.tags.remove(obj);
	}

	@Override
	public ITag remove(int index)
	{
		ITag adapter = get(index);
		remove(adapter);
		return adapter;
	}

	@Override
	public boolean removeAll(Collection<?> objs)
	{
		for (Object obj : objs)
			remove(obj);
		return true;
	}

	@Override
	public boolean retainAll(Collection<?> tags)
	{
		// TODO Auto-generated method stub
		throw new UnsupportedOperationException();
	}

	@Override
	public ITag set(int index, ITag adapter)
	{
		// TODO Auto-generated method stub
		//return this.tags.set(index, adapter);
		throw new UnsupportedOperationException();
	}

	@Override
	public int size() { return this.tags.size(); }

	@Override
	public List<ITag> subList(int fromIndex, int toIndex) { return this.tags.subList(fromIndex, toIndex); }

	@Override
	public Object[] toArray() { return this.tags.toArray(); }

	@Override
	public <T> T[] toArray(T[] a) { return this.tags.toArray(a); }
}
