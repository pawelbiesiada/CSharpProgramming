using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class BirthdayCalc
    {
        public static void Execute()
        {
            var dayToCalculateFrom = new DateTime(2000, 1, 1);

            var days = (DateTime.Now - dayToCalculateFrom);
            var hours = (DateTime.Now - dayToCalculateFrom).Hours;

            var dateStr = "01-07-2023";

            var ci = new CultureInfo("en-US"); //en-en, pl-pl

            CultureInfo.CurrentCulture = ci;

            var date = DateTime.Parse(dateStr, ci);


            //"20230107135500"
            var dateAndTime = DateTime.ParseExact("20230107135500", "yyyyMMddHHmmss", ci);


            // 1 000 000,00 - pl
            // 1,000,000.00 - us
        }
    }
}
