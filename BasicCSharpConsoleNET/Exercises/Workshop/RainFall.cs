using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class RainFall : IRainFall
    {
        private readonly double[] monthlyRainfall;

        private double _avg;

        public RainFall()
        {
            monthlyRainfall = new double[12];

            //GetMonthlyRainFall(3);

            //GetMonthlyRainFall(Month.March);

        }

        public double Average
        {
            get
            {
                return monthlyRainfall.Average();
            }
        }

        /// <summary>
        /// Returns monthly rainfall for a given month
        /// </summary>
        /// <param name="month">number of a month</param>
        /// <returns>Returns fall for a month</returns>
        /// <exception cref="ArgumentOutOfRangeException">throws if month number does not exist</exception>
        public double GetMonthlyRainFall(int month)
        {
            double avg = Average; // avg = 0, Average = 0
            AddRainFall(1, 120);
            Console.WriteLine(avg); // avg = 0, Average = 120
            avg = Average;
            Console.WriteLine(avg);// avg = 120, Average = 120


            if (month < 1 || month > 12)
                throw new ArgumentOutOfRangeException("Miesiąc musi zawierać się między 1 a 12");

            return monthlyRainfall[month - 1];
        }

        public double GetMonthlyRainFall(Month month)
        {
            return GetMonthlyRainFall(month);
        }

        public void AddRainFall(int month, double amount)
        {
            if (month < 1 || month > 12)
                throw new ArgumentOutOfRangeException("Miesiąc musi zawierać się między 1 a 12");

            monthlyRainfall[month - 1] += amount;
        }
        public void ImportRainFall(RainFall rainFall)
        {
            ArgumentNullException.ThrowIfNull(rainFall);
            for (int month = 1; month <= 12; month++)
            {
                double otherRainfall = rainFall.GetMonthlyRainFall(month);
                AddRainFall(month, otherRainfall);
            }
        }
    }

    public enum Month
    {
        January = 1,
        February,
        March,
        April,
        May, 
    }


    public enum Status
    {
        /// <summary>
        /// User is active and can be Authenticated
        /// </summary>
        Active = 2,
        NonActive = 3,
        Blocked = 100,
        Unblocked = 2,
        New = 0
    }
}
