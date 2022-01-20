using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject
{
    internal class Shared1
    {
        // Test my comment

#if NET6_0
        // Tst my comment

        public void Tst()
        {
int t = 1;
        }
#else
        // Tst my comment

        public void Tst()
        {
            int t = 1;
        }
#endif
    }
}
