using HtmlWalker;
using HtmlWalker.Platform;
using System;

namespace HtmlTest.Base
{
    public class FormattedCloneTestWalker : TestWalker
    {
        public FormattedCloneTestWalker(WalkerPlatform platform) : base(platform)
            => Walkers.Add(new FormattedCloneWalker(Output));
    }
}
