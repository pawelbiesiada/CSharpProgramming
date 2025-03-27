using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicCSharpConsoleNET.Samples.Class.Inheritance;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    public static class StringExtensions
    {
        public static int GetWordsCount(this string str)
        {
            //return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            return str.Split([' ', '\n', '\t'], StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int CountCharacter(this string str, char character)
        {
            return str.Count(c => c == character);
        }

        public static void LoadTrunkAll(this FamilyCar car, List<int> items)
        {
            items.ForEach(car.LoadTrunk);
        }
    }
}
