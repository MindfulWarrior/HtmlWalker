﻿package htmldoccleaner;

import java.util.HashMap;
import java.util.Map;

class CmdLine
{
    interface ArgumentProcessor { int process(String[] args, int pos); }

    class CmdArg
    {
        public String help;
        public ArgumentProcessor op;
    }

    private static String input = "";
    private static String output = "";
    private static boolean isXhtml = false;

    public static String input() { return input; }

    public static String output() { return output; }

    public static boolean isXhtml() { return isXhtml; }

    static Map<String, CmdArg> argMap = new HashMap<String, CmdArg>();

    {

        var showHelp = new CmdArg();
        showHelp.op = new ArgumentProcessor()
        {
            @Override
            public int process(String[] args, int pos)
            {
                for (var arg : argMap.keySet())
                {
                    var cmdArg = argMap.get(arg);
                    if (true)
                        System.out.println("-" + arg + "\t" + cmdArg.help);
                }
                return pos + 1;
            }
        };

        argMap.put("h", showHelp);

        var isxhtml = new CmdArg();
        isxhtml.op = new ArgumentProcessor()
        {
            @Override
            public int process(String[] args, int pos)
            {
                isXhtml = true;
                return pos + 1;
            }
        };

        argMap.put("x", isxhtml);
    }

    private CmdLine() { }

    public static boolean read(String[] args)
    {
        if (args.length == 0)
        {
            argMap.get("h").op.process(args, 0);
            return false;
        }
        else
        {
            int pos = 0;
            while (pos < args.length)
            {
                var arg = args[pos];
                if (arg.charAt(0) == '=')
                {
                    var cmdArg = argMap.get(arg.substring(1));
                    pos = cmdArg.op.process(args, pos);
                }
                else
                {
                    if (input.isEmpty())
                        input = arg;
                    else if (output.isEmpty())
                        output = arg;
                    pos++;
                }
            }
            return !input.isEmpty() && !output.isEmpty();
        }
    }
}
