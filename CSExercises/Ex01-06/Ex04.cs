using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("put a double number");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Sqrt(a);
            Console.WriteLine("the square root of the number is   " + b);

        }
    }
}
