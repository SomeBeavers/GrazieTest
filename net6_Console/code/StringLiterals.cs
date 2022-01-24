// lilia.shamsutdinova
// GrazieTest
// net6_Console
// StringLiterals.cs

using System.Text.RegularExpressions;
#pragma warning disable CS0219

namespace net6_Console.code;

public class StringLiterals
{
    private void Test(int id)
    {
        string myLocalString = "my local strin";
        string stringWithVerbatim = @"my local strin";
        string interpolatedString = $"my local = {myLocalString} = strin";
        var sqlInection = "select * from table where animal.ID = 1";
        string pattern = @"\b[M]\w+";
        Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");


        string stringFormat = string.Format("my local {0} strin", "onetwo");
        string concatenation = "Deep into that darkness peering, " +
                               "Long I stood there, wondering, fearing," +
                               "Doubting, dreaming dreams no mortals" +
                               "Ever dared to dream before;" +
                               "But the silence was unbroken," +
                               "And the stillness gave no token," +
                               "And the only word there spoken" +
                               @"Was the whispered word, ""Lenore!""" +
                               "This I whispered, and an echo" +
                               @"Murmured back the word, ""Lenore!""" +
                               "Merely this, and nothing more.";
        string verbatimInterpolation = $@"{stringFormat} is the formatted string
 with multiline and type here: coment";
    }
    // Path: C:\Projects\tests
    private void LanguageInjections()
    {
        string regex = "([A-Z])\\w++ \\D%% (?i-:xyz)";
        string html = "<p>test</p";
        string jso2n = "{\r\n    \"date\": \"2018-05-06\"}";
        string json = "[\r\n  {\r\n    \"date\": \"2018-05-06\",\r\n    \"temperatureC\": 1,\r\n    \"summary\": \"Freezing\"\r\n  },\r\n  {\r\n    \"date\": \"2018-05-07\",\r\n    \"temperatureC\": 14,\r\n    \"summary\": \"Bracing\"\r\n  },\r\n  {\r\n    \"date\": \"2018-05-08\",\r\n    \"temperatureC\": -13,\r\n    \"summary\": \"Freezing\"\r\n  },\r\n  {\r\n    \"date\": \"2018-05-09\",\r\n    \"temperatureC\": -16,\r\n    \"summary\": \"Balmy\"\r\n  },\r\n  {\r\n    \"date\": \"2018-05-10\",\r\n    \"temperatureC\": -2,\r\n    \"summary\": \"Chilly\"\r\n  }\r\n]";
        string xml = "<food><name>Name</name></food>";
        string js = "const name = 'James';const person = { first: name };console.log(person);var ref = /foo        bar/;\r\nconst message = 'Hello, World';\r\n\r\nconst sayHelloLinting = (fName) => {\r\n    console.log(`Hello linting, ${fName}`);\r\n};";
        string css = "\r\n.btn-primary {\r\n    color: #fff;\r\n    background-color: #1b6ec2;\r\n    border-color: #1861ac;\r\n}\r\n";

        string a = "a/{*x?}/";
    }
}