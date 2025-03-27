using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises
{

    public class StringConcat
    {
        public int Numb { get; set; }


        public void Execute()
        {
            var stringConcat = new StringConcat();
            var loopCount = 10_000;
            var timer = Stopwatch.StartNew();

            stringConcat.ConcatUsingString(loopCount);
            Console.WriteLine($"Concatenating strings took {timer.ElapsedMilliseconds} ms.");
            timer.Restart();
            stringConcat.ConcatWithStringBuilder(loopCount);
            Console.WriteLine($"Concatenating StringBuilder took {timer.ElapsedMilliseconds} ms.");
            //timer.Reset();

            var i = 3; //int - valueType
            ModifyInt(i);


            Console.WriteLine(i); //3

            StringConcat sc2;

            //sc2.Execute();


            stringConcat.Numb = 3;
            ModifyRef(stringConcat);

            Console.WriteLine(stringConcat.Numb);  //5
        }


        void ModifyInt(int number) //3
        {
            number = number + 5; //8
        }

        void ModifyRef(StringConcat sc)
        {
            sc.Numb = 5;
        }

        public void ConcatUsingString(int count)
        {
            var str = string.Empty;
            for (int i = 0; i < count; i++)
            {
                str += " ";
            }
        }

        public void ConcatWithStringBuilder(int count)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(" ");
                
            }
            var text = sb.ToString();
        }
    }
}
