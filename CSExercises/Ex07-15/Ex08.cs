using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("put a temperature");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = 1.8 * a + 32;

            Console.WriteLine("Fahrenheit is " + b);

            
        }
    }
}
