namespace LabWorkFunctions
{
    public static class Functions
    {
        public static ulong GetFactorial(int n)
        {
            if (n == 0)
                return 1;
            if (n > 0)
                return (ulong)n * GetFactorial(n - 1);
            return 0;
        }

        public static double GetPower(double x, int n)
        {
            if (n == 0)
                return 1;

            if (n > 0)
                return x * GetPower(x, n - 1);

            return 1 / GetPower(x, -n);
        }

        public static double GetPowerSpeedy(double x, int n)
        {
            return n < 0 ? 1 / GetPower(x, -n) : n == 0 ? 1 : n == 1 ? x : n % 2 == 0 ? x * x * GetPowerSpeedy(x, n - 2) : x * x * x * GetPowerSpeedy(x, n - 3);
        }
    }
}
