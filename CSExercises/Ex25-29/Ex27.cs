using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X\tY");
            Console.WriteLine("-------------------");
           

            double y;
            for (int x = -5; x >= -5 && x <= 5; x++)
            {
                y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("{0:0.0}\t{1:0.0}",x,y);
            }
            
        }
    }
}
