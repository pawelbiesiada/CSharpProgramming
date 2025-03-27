using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class TriangleValidator
    {
        public static void Execute()
        {
            var edgeA = 3.5;
            var edgeB = 7;
            var edgeC = 5;

            var result = string.Empty;

            if (IsTriangle(edgeA, edgeB, edgeC))
            {
                result = "It's a triangle!";
            }
            else
            {
                result = "It's not a triangle";
            }

            Console.WriteLine(result);
        }


        static bool IsTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        static bool IsTriangle(int a, int b, int c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
