using HtmlWalker.Core;
using System;
using System.Diagnostics;

namespace HtmlWalker
{
    // TODO: Make into a modifier
    public class TagTraceWalker : EventWalker
    {
        public static void StartTagTrace(object sender, EventArgs args)
        {
            if (sender is TagTraceWalker tracer && args is TagEventArgs tagArgs)
            {
                tracer.TraceBegin();
                tracer.Trace(tagArgs.Tag);
            }
        }

        public static void EndTagTrace(object sender, EventArgs args)
        {
            if (sender is TagTraceWalker tracer)
                tracer.TraceEnd();
        }

        public static void TagTrace(object sender, EventArgs args)
        {
            if (sender is TagTraceWalker tracer && args is TagEventArgs tagArgs)
                tracer.Trace(tagArgs.Tag);
        }

        #region Tracing

        private int traceIndex = 0;
        private int traceIndent = 0;

        private void TraceBegin() { traceIndent++; }
        private void TraceEnd() { traceIndent--; }

        private void Trace(ITag tag)
        {
            if (Verbosity >= 1)
            {
                var msg = traceIndex.ToString() + ":" + new string(' ', traceIndent) + "<" + tag.Name + ">";
                if (!String.IsNullOrWhiteSpace(tag.TextValue))
                    msg += "[" + tag.TextValue + "]";
                if (DebugTrace)
                    Debug.Print(msg);
                else
                    System.Console.WriteLine(msg);
            }
            traceIndex++;
        }

        private void Trace(int verbosity, string str)
        {
            if (Verbosity >= verbosity && !String.IsNullOrWhiteSpace(str))
            {
                var msg = traceIndex.ToString() + ":" + new string(' ', traceIndent) + str;
                if (DebugTrace)
                    Debug.Print(msg);
                else
                    Console.WriteLine(msg);
            }
            traceIndex++;
        }

        #endregion

        public int Verbosity = 1;

        public bool DebugTrace = false;

        public TagTraceWalker() : base()
        {
            StartTagHandler += StartTagTrace;
            EndTagHandler += EndTagTrace;
            TagHandler += TagTrace;
        }
    }
}
