using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the distance of traveled: "); 
            double x = Convert.ToDouble(Console.ReadLine()); 
            double y = 2.4 + x * 0.4;
            double dis = Math.Round(y, 1);

            Console.WriteLine("The total fare is ${0:0.00}", dis);
   

            
        }
    }
}
