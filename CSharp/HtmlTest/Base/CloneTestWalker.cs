using HtmlWalker;
using HtmlWalker.Platform;
using System;

namespace HtmlTest.Base
{
    public class CloneTestWalker : TestWalker
    {
        public CloneTestWalker(WalkerPlatform platform, WalkerPlatform.IOptions options = null)
            : base(platform, options) => Walkers.Add(new CloneWalker(Output));
    }
}
