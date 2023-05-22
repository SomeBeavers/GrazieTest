namespace net6_Console;

public class Play4
{
    public void Run(string iMBitWeakToday)
    {
        var s = "     now " +
                $"i'm long coment with typo\r\n     deal with it";
        var heloWorld = $"I'm bit weak today. {iMBitWeakToday}'m bit weak today";
        Console.WriteLine("I'm bit weak today. {0}'m bit weak today", "");

        string.Format("I'm bit weak today. {0}'m bit weak today", "");

        Console.WriteLine("Play4");
        Console.WriteLine("Helo, Wrld!");

#pragma warning disable CS0219
        int coutVariable = 1;
#pragma warning restore CS0219

        // AFAIR , this method is not used anywhere in the code, AFAICS so lets skipp  it and return to it later when 
        // we will have more time to deal with it
        // AFAIR , this method is not used anywhere in the code, AFAICS so lets skipp  it.

    }

    // ReSharper disable once IdentifierTypo

    public void Test()
    {
        // ASDFOPQR is not a word.

        // coment with typo here is EXEPCTED.

    }
}