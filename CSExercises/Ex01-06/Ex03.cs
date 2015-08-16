using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("put a double number");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Pow(a, 2);

            Console.WriteLine("The square of the number is {0}",b);


            
        }
    }
}
