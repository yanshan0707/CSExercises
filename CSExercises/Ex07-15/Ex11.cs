using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.Write("put the distance traveled   ");
            double dis = Convert.ToDouble(Console.ReadLine());
            double fare = 2.40 + .4 * dis;
            Console.WriteLine("the total fare is  " + fare);



        }
    }
}
