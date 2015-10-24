using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej '{0}'", Environment.UserName);
            Console.WriteLine();

            Console.WriteLine("Tryck på en knapp");

            bool keepLooping = true;
            while(keepLooping)
            {
                var key = Console.ReadKey(true);

                //-------------------------------------------------------------------------
                // Ändra på förjande rad så att den tryckta tangenten skrivs ut tillsammans
                // med resten av teksten.
                // Tips! Jämför med rad 13.

                Console.WriteLine("Du tryckte på ''", key.KeyChar);
                //-------------------------------------------------------------------------

                keepLooping = key.Key != ConsoleKey.Escape;
            }
        }
    }
}
