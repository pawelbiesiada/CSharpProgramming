namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal interface IRainFall
    {
        double Average { get; }

        void AddRainFall(int month, double amount);
        double GetMonthlyRainFall(int month);
        double GetMonthlyRainFall(Month month);
        void ImportRainFall(RainFall rainFall);
    }
}