using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO\tINVERSE\tSQRT\tSQR");
            Console.WriteLine("-----------------------------------");
            for (double i = 1.0; i <= 10.0; i++)
            {
                

                Console.WriteLine("{0:0.0}\t{1:0.0##}\t{2:0.0##}\t{3:0.0##}",i,1/i , Math.Sqrt(i), Math.Pow(i, 2));
            }
            
        }
    }
}
