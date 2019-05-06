﻿using Html5DomWalker;
using HtmlTest.Base;
using HtmlTest.Html5Dom;
using HtmlWalker.Platform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HtmlPrivateTest
{
    [TestClass]
    public class PrivateTest : BaseTest
    {
        protected const string SUB_FOLDER = "Private";
        public PrivateTest() : base(SUB_FOLDER) { }

        private readonly Html5DomCloneTest cloneTest = new Html5DomCloneTest(SUB_FOLDER);

        protected override WalkerPlatform Platform => Html5DomPlatform.Instance;

        protected override void CreateExpected(FileInfo expected, FileInfo testInput, Options options = null)
        {
            throw new NotImplementedException();
        }

        protected void DoTest(FileInfo testInput, string name)
        {
            // Clone Test
            var cloneExpected = cloneTest.GetTestExpected("expected.clone." + name + ".html", testInput, true);
            var cloneOutput = cloneTest.GetTestOutput("output.clone." + name + ".html");

            // TODO: Handle other encodings
            var options = new Options(Platform);
            options.DocumentOptions.Encoding = Encoding.UTF8;
            cloneTest.DoTest(testInput, cloneOutput, cloneExpected, options);
        }

        [TestMethod]
        public void TestAllInFolder()
        {
            foreach (var testInput in InputDirectory.GetFiles("test.*.html"))
            {
                var parts = testInput.Name.Split(".");
                var name = string.Empty;
                for (int n = 1; n < parts.Length - 1; n++)
                {
                    var part = parts[n];
                    if (!string.IsNullOrEmpty(name))
                        name += ".";
                    name += part;
                }
                if (!string.IsNullOrEmpty(name))
                    DoTest(testInput, name);
            }
        }
    }
}