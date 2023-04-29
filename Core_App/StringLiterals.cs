// Lilia.Shamsutdinova
// GrazieTest
// Core_App
// StringLiterals.cs

using NLog;
using NLog.Fluent;

namespace Core_App;

public partial class StringLiterals
{
    private static readonly Logger Log;
    public partial void TestMethod(string _regionName)
    {
        Log.Debug("caching query results in region: '{0}'; {1}", _regionName);
        string apparently = "caching query results in region apparently";

        EvaluateAndCheck(
            "window.setTimeout(function() { invoke_add(); }, 1);",
            "dotnet://debugger-test.dll/debugger-test.cs", 10, 8,
            "Math.IntAdd");

        var s = "I'm bit weak today";
    }

    private void EvaluateAndCheck(string windowSettimeoutFunctionInvokeAdd, string dotnetDebuggerTestDllDebuggerTestCs, int i, int i1, string mathIntadd)
    {
        throw new NotImplementedException();
    }
    // FIXME: Failing test CheckNumber (locals_m1, "i", 5);
    // FIXME: Failing test CheckString (locals_m1, "text", "Hello");

    public  void StringLiterals1()
    {
        String s = "I'm bit weak today. Realy";
        
        var string1 = "in future we will do better for sure!!!!";
        var string2 = @"lets
check how opened string 
is handled
";
        var string3=
        "lets test here too\r\ntest\r\n. lets test again";
        
        var string4=
        """    
        lets test here too
        test

        """;
        string iMBitWeakToday = "I'm bit weak today.";

        var string5 = $"I'm bit weak today. {iMBitWeakToday}'m bit weak today";
        Console.WriteLine("I'm bit weak today. {0}'m bit weak today", "");

        string.Format("I'm bit weak today. {0}'m bit weak today", "");

        // I'm bit weak today.

        // comment another


        // dank je wel frouw
        // dank je wel frouw 
        // Ik heb gekikerd
        void LocalFunctionWithtypoInName()
        {

        }
    }
    
    /**
     * This class : printing out text.
     *
     * @author Ken Arnold, Industrious Media LLC
     *
     */
    // Remember the "@" positions in last-to-first order (to make insertion easier)
    public void StringLiterals2()
    {
        string s = @"in
future.";
        string s1 = "\r\nLets test here";
        string replace = "select * from table".Replace("table", "table1");
        string s2 = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<start>\r\n\t<first> commonly used</first>\r\n\t<coment value=\"I'm bit angry today\"></coment>\r\n</start>";
        string expected = @"<?xml version=""1.0"" encoding=""utf-16""?>
<workbook xmlns:r=""http://schemas.openxmlformats.org/officeDocument/2006/relationships"" xmlns=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">
  <sheets />
</workbook>";

        Console.WriteLine($@"Getting list of Quantum jobs...");
        string s3 = "this is a verbatim string\r\nwhich spans across\r\nseveral lines.But\r\nthe check should\r\nstill be done. I'm\r\nbit\r\nconfused.\r\nThis time anything is \r\ndifferent then the last time\r\nso it is not the same.";

        string s4 = $$"""
            in future 
            {{s3}}
            is different then test
            {{s2}}.
            In future it does not matter 
            cause it is different then the last time.
            """;
        string s6 = string.Format("""
            in future 
            {0}
            is different then {{test}} = 
            {1}.
            In future it does not matter 
            cause it is different then {{0}} = {0}.
            """, s3, s2);
        string s7 = $$"""
            in future 
            {{s3}}
            is different then test = 
            {{s2}}.
            In future it does not matter 
            cause it is different then {0} = {{s3}}.
            """;
        string s5 = @"in future 
s3
is different then 
s2.
In future it does not matter.";
    }
}

public interface IA
{
    /// <summary>
    /// I'm bit weak today.
    /// </summary>
    void Method();
}
/**
         * {@inheritDoc}
         * <p/>
         * For text. This just printing the text.
         */
class A : IA
{
    /// <inheritdoc />
    void IA.Method()
    {
        throw new NotImplementedException();
    }
}

