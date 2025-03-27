using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class StringExercises
    {
        public static void Execute()
        {
            var text = "Lorem ipsum dolor sit amet, consectetur   adipiscing elit.";  //"id;name;;;result"

            var wyrazy = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            int miejsceprzecinka = text.IndexOf(',');
            string przedprzecinkiem = text.Substring(0, miejsceprzecinka);
                        Console.WriteLine(przedprzecinkiem);

            Console.WriteLine(wyrazy[2]);


            string wynik = "";
            for (int i = 0; i < wyrazy.Length; i += 2)

            {
                wynik += wyrazy[i] + " ";
            }
            Console.WriteLine(wynik);

            int licznikE = 0;
            
            string.Equals("E", "e", StringComparison.CurrentCultureIgnoreCase);
            "e".Equals("E", StringComparison.CurrentCultureIgnoreCase);


            Console.WriteLine(text.ToLower().Split('e').Length - 1);

            foreach (char znak in text)
            {
                if (znak == 'e' || znak == 'E')
                    licznikE++;
            }
            Console.WriteLine(licznikE);
        }
    }
}
