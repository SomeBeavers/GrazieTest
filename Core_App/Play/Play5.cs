namespace net6_Console;

public class Play5
{
    /*
     *            this is a start of  string;
       and the end;
     */
    public void Test(string newVar)
    {
        string s = $$"""
                   {newVar} = {{newVar}}
                               this is a start of string;
                   and the end;
                   and the most ended end.
                   this is a strange combination of string and string;
                   """;
        string s2 = $$"""
                   тута русский текст;
                   с новой строки;
                   а тута снова русский текст;
                   """;

    }
}