// Lilia.Shamsutdinova
// GrazieTest
// Core_App
// StringLiterals.cs

namespace Core_App;

public class StringLiterals
{
    public void StringLiterals1()
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
    }
}