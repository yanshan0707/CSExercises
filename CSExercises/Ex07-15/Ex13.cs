using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the distance of traveled: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 2.4 + x * 0.4;
            double fare = Math.Round(y, 1);
            if (fare>y)
            { Console.WriteLine("total fare is {0}  ",fare);}
            else
            { Console.WriteLine("total fare is   {0} ", fare + 0.1); }


        }
    }
}
