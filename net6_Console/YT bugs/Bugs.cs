// lilia.shamsutdinova
// GrazieTest
// net6_Console
// RSRP-487426.cs

using NLog;

namespace net6_Console.YT_bugs.coment.test;

public class Bugs
{
    private Logger log;

    private void Test()
    {
        // this text will not be considered by ReSpeller coment
        log.Info("this text will not be considered by ReSpeller coment");
        log.Info("this text will not be considered by ReSpeller coment" as string);
        // Unwriteable
        // NOTE: vatiable's states are unchecked.
        // See https://www.jetbrains.com/help/resharper/Code_Analysis__Index.html#finding-code-issues-visualstudio
        /*
         * This makes it possible to compile using clang as it doesn't support those classes.
         */

        /*
         * This makes it possible to compile using clang as it doesn't support those classes.
         */

        // Path: C:\Projects\tests

        var mamberName = log;
        using (var fs = File.OpenText("c:\\testing\\census-in.csv")) { }

        string outputResources = @"output\resources";
        // Initialzier
    }
}