using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {      
            Console.WriteLine(Factorial(Convert.ToDouble(Console.ReadLine())));

               
        }
        static double Factorial (double x)
        {
            
            double fac = x;


            for (double i = x - 1; i >= 1; i--)
            {
                fac = fac * i;
            }
            return fac; 
        }
    }
}
