namespace net6_Console;
//coment
public class TypoInComment
{
    // руский комент здсь

    /*
     руский коммент
     now i'm long coment with typo
     deal with it
    */

    public void Test(string s1)
    {
        var s = "     now " +
                @"i'm long coment with typo\r\n     deal with it";
        var t = 1;
    }
        } 