using HtmlWalker;
using HtmlWalker.Platform;
using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlTest.Base
{
    public class TestWalker : JoinedWalker, IDisposable
    {
        public readonly TagTraceWalker tracer = new TagTraceWalker();

        public TestWalker(WalkerPlatform platform, WalkerPlatform.IOptions options = null) : base()
        {
            Output = platform.NewDocument(options);
            Walkers.Add(tracer);
        }

        public WalkerPlatform.WalkerDocument Output { get; }

        public void Dispose() => Output.Close();
    }
}
