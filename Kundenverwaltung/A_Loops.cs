using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kundenverwaltung
{
    internal class A_Loops
    {
        public void Example()
        {
            // for
            for (int i = 0; i < 10; i++)
            {
                // hier kann etwas ausgeführt werden
            }

            // while
            while (1 == 1)
            {
                // hier kann etwas ausgeführt werden
            }

            // do-while
            do
            {
                // hier kann etwas ausgeführt werden
            } while (true);

            // foreach
            List<string> namen = new List<string> { "Stefan", "Hans", "Julia" };
            foreach (string name in namen)
            {
                // hier kann etwas ausgeführt werden
            }

            // Kurzschreibweiße für foreach
            namen.ForEach(name =>
            {
                // hier kann etwas ausgeführt werden
            });
        }
    }
}
