using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    public class PrimeNumberValidator   //[InternalsVisibleTo]
    {
        public void Execute(int liczba)
        {
            //int liczba = 11;
            PrintHi();
            var result = string.Empty;

            result = SprawdzCzyPierwsza(liczba) ? "To liczba pierwsza!" : "To NIE JEST liczba pierwsza!";

            Console.WriteLine(string.Empty);
        }

        public bool SprawdzCzyPierwsza(int X)
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

        private void PrintHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
