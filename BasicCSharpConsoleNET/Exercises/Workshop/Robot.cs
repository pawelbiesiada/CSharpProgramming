using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class Robot
    {
        public string Name { get; set; }
        public ushort Age { get; set; }
        public bool IsOn { get; set; } = true;

        public Robot() : this("John", 20)
        {
        }

        public Robot(string name, ushort age)
        {
            Name = name;
            Age = age;
        }

        internal void SayHi()
        {
            if (IsOn)
            {
                Console.WriteLine($"Say Hi {Name}");
            }
        }
    }
}
