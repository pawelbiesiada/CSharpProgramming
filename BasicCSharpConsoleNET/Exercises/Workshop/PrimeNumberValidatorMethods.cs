using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class PrimeNumberValidatorMethods
    {
        public void Execute()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var pnv = assembly.DefinedTypes
                .FirstOrDefault(t => t.Name == "PrimeNumberValidator");

            var methods = pnv.GetMethods();
            var obj = assembly.CreateInstance(pnv.FullName);


            Console.WriteLine("\nMetody prywatne:");
            foreach (MethodInfo method in pnv.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine($"- {method.Name}()");
            }
        

            foreach (var method in methods)
            {
                if (method.Name == "PrintHi")
                {
                    method.Invoke(obj, null);
                }

                Console.WriteLine(method.Name);
            }

        }
    }
}
