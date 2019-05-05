using HtmlWalker;
using HtmlWalker.Platform;
using System;

namespace HtmlTest.Base
{
    public class CloneTestWalker : TestWalker
    {
        public CloneTestWalker(WalkerPlatform platform) : base(platform)
            => Walkers.Add(new CloneWalker(Output));
    }
}
