using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject
{
    internal class Shared1
    {

        /*
         * English(Canada)
         * ---------------------
         * no typo:
         * theatre
         *
         * typo:
         * theater
         *
         * English(Great Britain)
         * ---------------------
         * no typo:
         * travelling
         * flavour
         *
         * typo:
         * 	traveling
         *
         * Русский
         * ---------------------
         * no typo:
         * ох, русский сложно
         *
         * typo:
         * Ощень сложно ←-----------------------------------------
         * Локалная
         *
         * English(Canada)
         * ---------------------
         * no typo:
         * theatre
         *
         * typo:
         * theater
         *
         * English(Great Britain)
         * ---------------------
         * no typo:
         * travelling
         * flavour
         *
         * typo:
         * 	traveling
         *
         *coment
         */

        // Ощень сложно ←-----------------------------------------



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
        // another coment is here.
        // I'm bit angry today.

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
