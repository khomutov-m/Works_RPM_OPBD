namespace Task1
{
    internal class MathOperations
    {
        public static double Perimeter(double side) => side * 4;

        public static double Perimeter(double width, double lenght) => (width + lenght) * 2;

        public static double Power(double x, int n)
        {
            if (n < 0) 
                return -1; 

            double result = 1;
            for (int i = n; i > 0; i--)
            {
                result = result * x;
            }
            return result;
        }

        public static double Power(double x) => x * x;
    }
}
