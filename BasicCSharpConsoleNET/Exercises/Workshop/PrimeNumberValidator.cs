using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class PrimeNumberValidator
    {
        public static void Execute(int liczba)
        {
            //int liczba = 11;

            var result = string.Empty;

            result = SprawdzCzyPierwsza(liczba) ? "To liczba pierwsza!" : "To NIE JEST liczba pierwsza!";

            Console.WriteLine(string.Empty);
        }

        private static bool SprawdzCzyPierwsza(int X)
        {
            if(X < 0) return false;

            int ile_dzielnikow = 0;

            for (int i = 1; i <= X; i++)
            {
                if (X % i == 0)
                    ile_dzielnikow++;

                if (ile_dzielnikow > 2)
                    return false;
            }

            if (ile_dzielnikow == 2)
                return true;
            else
                return false;
        }
    }
}
