using System;

namespace LineComparision
{
    class Program
    {
        
       static void Main(string[] args)
        {
            //genertaing a random valus using random method
            Random random = new Random();
            
            int equal = 0;

            int[] x1 = new int[2];
            int[] y1 = new int[2];
            int[] x2 = new int[2];
            int[] y2 = new int[2];
            
            //calling a Next() method
            for (int i = 0; i <= 1; i++)
            {
                x1[i] = random.Next(0, 10);
                y1[i] = random.Next(0, 10);
                x2[i] = random.Next(0, 10);
                y2[i] = random.Next(0, 10);
            }

            // calling the Length Method()
            double LineOneLength = Program.length(x1[0], y1[0], x2[0], y2[0]);
            double LineTwoLength = Program.length(x1[1], y1[1], x2[1], y2[1]);
            int compare = LineOneLength.CompareTo(LineTwoLength);

            if (compare>equal)
            {
                Console.WriteLine("The line one is greater");
            }
            else if(compare < equal)
            {
                Console.WriteLine("The line two is greater");
            }
            else
            {
                Console.WriteLine("The lines are Equal");
            }
            

        }
               
       //Calculating the length of the two lines
         static double length(int x1, int y1, int x2, int y2)
        {
            //Formula for calculating length

            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) +
                      Math.Pow(y2 - y1, 2) * 1.0);
            return result;



        }
    }
}
