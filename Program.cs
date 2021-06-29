using System;

namespace LineComparision
{
    class Program
    {
        // Method for calculating length
        private static void length(int x1, int y1, int x2, int y2)
        {
            //Formula for calculating length

            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) +
                      Math.Pow(y2 - y1, 2) * 1.0);

            Console.WriteLine("Length of the line = " + result);

        }
        
        static void Main(string[] args)
        {
            // calling the method
            Program.length(3,4,4,3);
        }
    }
}
