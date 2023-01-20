using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject
{
    internal class Shared1
    {
        // Test my comment
        // I'm bit angry today

#if NET6_0
        // Tst my coment

        public void Tst()
        {
int t = 1;
        }
#else
        // Tst my coment
        // another coment is here

        public void Test2()
        {
        }

        public void Test()
        {
            int t = 1;
        }
#endif
    }
}
