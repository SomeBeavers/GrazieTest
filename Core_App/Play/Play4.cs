//[assembly: InternalsVisibleTo("FolkerKinzel.CsvTools.Tests")]
// Durch Festlegen von ComVisible auf "false" werden die Typen in dieser Assembly unsichtbar 
// für COM-Komponenten. Wenn Sie auf einen Typ in dieser Assembly von 
// COM zugreifen müssen, legen Sie das ComVisible-Attribut für diesen Typ auf "true" fest.

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

    // овт тут русский коммент. руский коммент помогает понять что тут происходит

    // овт тут русский коммент. руский коммент помогает понять что тут происходит



    // Nu gaat het niet zo goed met mij. Maar dat is niet erg.
    public void Test(string s2, string s3)
    {
        // ASDFOPQR is not a word.

        // coment with typo here is EXPECTED.
        string s4 = $"{s2} is different from {s3}"; // .ClearString(); для очистки от тегов

        string s5 = $"s2 is different from {s3}";

        string concatenation = "This is different " +
                               "from that." +
                               " " +
                               "A bit " +
                               "strange. That is" +
                               "";

        // stdafx.obj will contain the pre-compiled type information
        // stdafx.razor will contain the pre-compiled type information
        // stdafx.vb will contain the pre-compiled type information

        string s6 = string.Format("""
                                  in future
                                  {0}
                                  is different from test =
                                  {1}.
                                  In future it does not matter
                                  because it is different then {{0}} = {0}.
                                  """, s3, s2);



    }

    /// <summary>
    /// <see cref="ClasNameCCreatedByMeLiliaShamsutdinvoa"/>
    /// </summary>
    public class ClasNameCCreatedByMeLiliaShamsutdinvoa
    {

    }

}