using System;
using System.Globalization;

namespace Framework_Lib.Playground
{
    // shamsutdinova
    public class Play4
    {
        public void Test(string s)
        {
            String s2 = "s" + "::Test";
        }

        // Controleer of twee strings gelijk zijn en niet null zijn
        public bool VergelijkStrings(string string1, string string2)
        {
            if (string1 != null && string2 != null) {
                return string1 == string2;
            }
            return false;
        }


    }
}