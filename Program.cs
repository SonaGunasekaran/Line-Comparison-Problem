﻿using System;

namespace LineComparision
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            // calling a methods

            double result2 = Program.line1Length(3,4,4,3);
            double result1 = Program.line2Length(3,4,4,3);
           // check whether the two lines are equal or not

            if (result1.Equals(result1))
            {
                Console.WriteLine("The lines are Equal");
            }
            else
            {
                Console.WriteLine("The lines are not Equal");
            }
            

        }

         static double line1Length(int x1, int y1, int x2, int y2)
        {
           double result2 = Program.length(3,4,4,3);
            return result2;

        }
         static double line2Length(int x1, int y1, int x2, int y2)
        {
            double result1=Program.length(3,4,4,3);
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
