using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("the salary is ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a + 0.1 * a + 0.3 * a;
            Console.WriteLine("the total income is {0:c}",b);

            
        }
    }
}
