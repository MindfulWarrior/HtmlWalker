using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlDocCleaner
{
    class CmdLine
    {
        delegate int ArgumentDelegate(string[] args, int pos);

        struct CmdArg
        {
            public string Help;
            public ArgumentDelegate Op;
        }

        static Dictionary<string, CmdArg> argMap = new Dictionary<string, CmdArg>()
        {
            {
                "h",
                new CmdArg()
                {
                    Help = "message",
                    Op = ShowHelp
                }
            },
            {
                "x",
                new CmdArg()
                {
                    Help = "Source is XHTML",
                    Op = SetIsXhtml
                }
            }
        };

        public static string Input = String.Empty;
        public static string Output = String.Empty;
        public static bool IsXhtml = false;

        static int ShowHelp(string[] args, int pos)
        {
            foreach (var arg in argMap.Keys)
            {
                var cmdArg = argMap[arg];
                if (!String.IsNullOrWhiteSpace(cmdArg.Help))
                    Console.WriteLine("-" + arg + "\t" + cmdArg.Help);
            }
            return pos + 1;
        }

        static int SetIsXhtml(string[] args, int pos)
        {
            IsXhtml = true;
            return pos + 1;
        }

        private CmdLine() { }

        public static bool Read(string[] args)
        {
            if (args.Length == 0)
            {
                ShowHelp(args, 0);
                return false;
            }
            else
            {
                int pos = 0;
                while (pos < args.Length)
                {
                    var arg = args[pos];
                    if (arg[0] == '=')
                    {
                        var cmdArg = argMap[arg.Substring(1)];
                        pos = cmdArg.Op(args, pos);
                    }
                    else
                    {
                        if (String.IsNullOrWhiteSpace(Input))
                            Input = arg;
                        else if (String.IsNullOrWhiteSpace(Output))
                            Output = arg;
                        pos++;
                    }
                }
                return !String.IsNullOrWhiteSpace(Input) && !String.IsNullOrWhiteSpace(Output);
            }
        }
    }
}
