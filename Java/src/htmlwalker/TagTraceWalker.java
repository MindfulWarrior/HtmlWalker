package htmlwalker;

import htmlwalker.core.EventWalker;

public class TagTraceWalker extends EventWalker
{
    private int traceIndex = 0;
    private int traceIndent = 0;

    private void traceBegin() { traceIndent++; }
    private void traceEnd() { traceIndent--; }

    private void trace(int verbosity, ITag tag)
    {
        if (this.verbosity >= verbosity)
        {
            String msg
                = Integer.toString(this.traceIndex) + ":"
                + new String(new char[this.traceIndent]).replace("\0", " ")
                + "<" + tag.name() + ">[" + (tag.getTextValue() == null ? tag.toString() : "") + "]";
            System.out.println(msg);
        }
        this.traceIndex++;
    }

    @SuppressWarnings("unused")
	private void trace(int verbosity, String str)
    {
        if (this.verbosity >= verbosity && str != null && !str.isEmpty())
        {
            String msg = Integer.toString(this.traceIndex) + ":" + new String(new char[this.traceIndent]).replace("\0", " ") + str;
            System.out.println(msg);
        }
        traceIndex++;
    }

    public int verbosity = 1;

    public TagTraceWalker() { super(); }

    @Override
    protected void onStartDocument(DocumentTag adapter) { }

    @Override
    protected void onEndDocument(DocumentTag adapter) { }

    @Override
    protected void onStartTag(ITag adapter)
    {
        traceBegin();
        trace(1, adapter);
    }

    @Override
    protected void onEndTag(ITag adapter) { traceEnd(); }

    @Override
    protected void onTag(ITag adapter) { trace(1, adapter); }
}

