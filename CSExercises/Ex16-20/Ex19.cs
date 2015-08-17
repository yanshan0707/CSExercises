using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("put the distance in km :   ");
            double put  = Convert.ToDouble(Console.ReadLine());
            double dis  = Math.Ceiling(put * 10) / 10;
         
            if (dis <= 0.5&&dis>0)
            {
                Console.WriteLine("the cost is ${0:0.00}", 2.40);
            }
            else if (dis > 0.5 && dis <= 9.0)
            {
                Console.WriteLine("the cost is ${0:0.00}", 2.40+0.04*(dis-0.5)*10);
            }
            else if (dis > 9)
            {
                Console.WriteLine("the cost is ${0:0.00}", 2.40 + 0.04 * (dis - 0.5) * 10 + 0.05 * (dis - 9));
            }
            else
            {
                Console.WriteLine("error");
            }

            
        }
    }
}