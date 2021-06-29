using System;

namespace LineComparision
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            // calling a methods

            double result2 = Program.line1Length(5,5,4,3);
            double result1 = Program.line2Length(4,4,4,3);
            // Comparing the Two lines using CompareTo method
            int compare = result1.CompareTo(result2);
            int equal = 0;


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
               
         static double line1Length(int x1, int y1, int x2, int y2)
        {
           double result2 = Program.length(5,5,4,3);
            return result2;

        }
         static double line2Length(int x1, int y1, int x2, int y2)
        {
            double result1=Program.length(4,4,4,3);
            return result1;
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
