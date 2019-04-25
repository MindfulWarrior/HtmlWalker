using HtmlWalker;
using HtmlWalker.Platform;
using System;

namespace HtmlTest.Base
{
    public class TestWalker : JoinedWalker, IDisposable
    {
        public readonly TagTraceWalker tracer;

        public TestWalker(WalkerPlatform platform, bool formatted = true) : base()
        {
            Output = platform.NewDocument();

            tracer = new TagTraceWalker();

            CloneWalker cloner;
            if (formatted && !platform.IsXml)
                cloner = new FormattedCloneWalker(Output);
            else
                cloner = new CloneWalker(Output);

            Walkers.Add(tracer);
            Walkers.Add(cloner);
        }

        public WalkerPlatform.WalkerDocument Output { get; }

        public void Dispose() { Output.Close(); }
    }
}
