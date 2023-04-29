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

        /// <summary>
        /// This metod gets the value of the <see cref="Tst"/> property which is
        /// different then the <see cref="Tst"/> method.
        /// </summary>
        public void GetSometingWithTypo()
        {

        }
#else
        // Tst my coment
        // another coment is here

        public void Coment()
        {
            string s = "This is different from that";
        }

        public void Test()
        {
            int t = 1;
        }
#endif
    }
}
