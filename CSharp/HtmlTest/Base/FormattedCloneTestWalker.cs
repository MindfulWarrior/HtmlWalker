﻿using HtmlWalker;
using HtmlWalker.Platform;
using System;

namespace HtmlTest.Base
{
    public class FormattedCloneTestWalker : TestWalker
    {
        public FormattedCloneTestWalker(WalkerPlatform platform, WalkerPlatform.IOptions options = null)
            : base(platform, options) => Walkers.Add(new FormattedCloneWalker(Output));
    }
}