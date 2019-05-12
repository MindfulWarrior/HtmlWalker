using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlDocCleaner
{
    class CmdLine
    {
        delegate int ArgumentDelegate(CmdLine caller, string[] args, int pos);

        struct CmdArg
        {
            public string ShortOpt;
            public string LongOpt;
            public string Help;
            public ArgumentDelegate Op;
        }

        static readonly List<CmdArg> cmdArgs = new List<CmdArg>()
        {
            new CmdArg()
            {
                ShortOpt = "h",
                LongOpt = "help",
                Help = "message",
                Op = ShowHelp
            },
            new CmdArg()
            {
                ShortOpt = "x",
                LongOpt = "xml",
                Help = "Source is XHTML",
                Op = SetIsXhtml
            },
            new CmdArg()
            {
                ShortOpt = "ei",
                LongOpt = "input-encoding",
                Help = "Codepage of the input",
                Op = SetEncodingInput
            },
            new CmdArg()
            {
                ShortOpt = "eo",
                LongOpt = "output-encoding",
                Help = "Codepage used for output",
                Op = SetEncodingOutput
            }
        };

        static int ShowHelp(CmdLine caller, string[] args, int pos)
        {
            foreach (var arg in cmdArgs)
            {
                if (!String.IsNullOrWhiteSpace(arg.Help))
                    Console.WriteLine("-" + arg.ShortOpt + ", --" + arg.LongOpt + "\t" + arg.Help);
            }
            return pos + 1;
        }

        static int SetIsXhtml(CmdLine caller, string[] args, int pos)
        {
            caller.IsXhtml = true;
            return pos + 1;
        }

        static int SetEncodingInput(CmdLine caller, string[] args, int pos)
        {
            caller.EncodingInput = caller.GetEncoding(args[pos + 1]);
            return pos + 2;
        }

        static int SetEncodingOutput(CmdLine caller, string[] args, int pos)
        {
            caller.EncodingInput = caller.GetEncoding(args[pos + 1]);
            return pos + 2;
        }

        static readonly Dictionary<string, CmdArg> cmdArgsMap = new Dictionary<string, CmdArg>();

        static CmdLine()
        {
            foreach (var cmdArg in cmdArgs)
            {
                cmdArgsMap.Add(cmdArg.ShortOpt, cmdArg);
                cmdArgsMap.Add(cmdArg.LongOpt, cmdArg);
            }
        }

        public CmdLine() { }

        public string Input = String.Empty;
        public string Output = String.Empty;
        public bool IsXhtml = false;
        public Encoding EncodingInput = Encoding.UTF8;
        public Encoding EncodingOutput = Encoding.UTF8;

        Encoding GetEncoding(string codepage)
        {
            // TODO: Support more encodings
            switch (codepage)
            {
                case "1252":
                    return CodePagesEncodingProvider.Instance.GetEncoding(1252);
                default:
                    return Encoding.UTF8;
            }
        }

        public bool Read(string[] args)
        {
            if (args.Length == 0)
            {
                ShowHelp(this, args, 0);
                return false;
            }
            else
            {
                int pos = 0;
                while (pos < args.Length)
                {
                    var arg = args[pos];
                    if (arg[0] == '-')
                    {
                        if (arg.Length > 2)
                        {
                            var key = arg.Substring(arg[1] == '-' ? 2 : 1);
                            if (cmdArgsMap.ContainsKey(key))
                            {
                                var cmdArg = cmdArgsMap[key];
                                pos = cmdArg.Op(this, args, pos);
                            }
                        }
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
