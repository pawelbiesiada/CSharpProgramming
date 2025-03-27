using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    public class CapacityExceededException : ApplicationException
    {
        public int MaxCapacity { get; private set; }
        public int AttemptedValue { get; }

        public CapacityExceededException(int maxCapacity, int attemptedValue)
            : base($"Próba przypisania wartości {attemptedValue}kg przekroczyła maksymalną pojemność {maxCapacity}kg o {attemptedValue - maxCapacity} kg.")
        {
            MaxCapacity = maxCapacity;
            AttemptedValue = attemptedValue;
        }
    }
}
