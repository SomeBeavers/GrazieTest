// lilia.shamsutdinova
// GrazieTest
// net6_Console
// Linked1.cs

using System;

namespace net6_Console
{
    public class Linked1
    {
        private const string Format = "test";

        private void Test()
        {
            int t = 1;
        }

        private void Test2()
        {
            const string format = Format;
            Console.WriteLine(format);
        }
    }
}